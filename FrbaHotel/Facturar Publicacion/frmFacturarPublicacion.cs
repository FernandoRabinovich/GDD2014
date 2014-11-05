using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FrbaHotel
{
    public partial class frmFacturarPublicacion : Form
    {
        int codigoReserva;

        public frmFacturarPublicacion()
        {
            InitializeComponent();
        }

        public frmFacturarPublicacion(int codigoReserva)
        {            
            InitializeComponent();
            this.codigoReserva = codigoReserva;
        }

        private void frmFacturarPublicacion_Load(object sender, EventArgs e)
        {
            try
            {
                ObtenerInformacionEstadia(this.codigoReserva);
                lblFechaFacturacion.Text = (System.Configuration.ConfigurationSettings.AppSettings["fechasistema"].ToString());
                ObtenerMediosPago();
                CargarLineasFactura();
                CalcularTotalAPagar();
                lblHotel.Text = frmPrincipal.hotel;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos de la facturación de la estadía. (" + ex.Message + ")", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLineasFactura()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtencionLineasFactura";

                SqlParameter reserva = new SqlParameter("@codigoReserva", this.codigoReserva);
                reserva.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(reserva);                                      
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                                     
                grdLineasFactura.DataSource = table;

                grdLineasFactura.Columns["Tipo"].Visible = false;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
               throw ex;
            }
            finally
            {
               cn.Close();
               if (cmd != null)
                   cmd.Dispose();
            }
        }
       
        private void CalcularTotalAPagar()
        {
            foreach(DataGridViewRow row in grdLineasFactura.Rows)
            {
                lblTotal.Text = (decimal.Parse(lblTotal.Text) + decimal.Parse(row.Cells["Total"].ToString())).ToString();
            }
        }

        private void ObtenerMediosPago()
        {                                        
            SqlConnection cn1 = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd1 = null;
            SqlDataReader reader = null;

            try
            {
                cn1.Open();
                cmd1 = new SqlCommand();
                cmd1.Connection = cn1;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "GRAFO_LOCO.ObtenerMediosPago";
                reader = cmd1.ExecuteReader();

                while(reader.Read())
                    cmbMedioPago.Items.Add(new TipoPago(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                cn1.Close();
                if (cmd1 != null)
                    cmd1.Dispose();
            }
        }                   
              
        private void ObtenerInformacionEstadia (int estadia)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerDatosEstadia";
                SqlParameter reserva = new SqlParameter("@codigoReserva", this.codigoReserva);
                reserva.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(reserva);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {                    
                    lblEstadia.Text = reader["idEstadia"].ToString();
                    lblCliente.Text = reader["cliente"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlTransaction sqlTran = null;

            try
            {
                cn.Open();
                sqlTran = cn.BeginTransaction();
                cmd = cn.CreateCommand();
                cmd.Transaction = sqlTran;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.CargarFactura";

                SqlParameter fecha = new SqlParameter("@FechaCreacion", DateTime.Parse(lblFechaFacturacion.Text));
                fecha.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fecha);
                SqlParameter total = new SqlParameter("@Monto", decimal.Parse(lblTotal.Text));
                total.SqlDbType = SqlDbType.Decimal;
                cmd.Parameters.Add(total);
                SqlParameter estadia = new SqlParameter("@IdEstadia", Int32.Parse(lblEstadia.Text));
                estadia.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(estadia);
                SqlParameter mediopago = new SqlParameter("@IdTipoPago", ((TipoPago)cmbMedioPago.SelectedItem).Id);
                mediopago.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(mediopago);
                if (grpTarjeta.Enabled)
                {
                    SqlParameter nombreTarjeta = new SqlParameter("@NombreTarjeta", txtNombreTarjeta.Text);
                    nombreTarjeta.SqlDbType = SqlDbType.VarChar;
                    nombreTarjeta.Size = 50;
                    cmd.Parameters.Add(nombreTarjeta);
                    SqlParameter numeroTarjeta = new SqlParameter("@NumeroTarjeta", txtNumeroTarjeta.Text);
                    numeroTarjeta.SqlDbType = SqlDbType.BigInt;
                    cmd.Parameters.Add(numeroTarjeta);
                }

                int idFactura = (Int32)cmd.ExecuteScalar();

                cmd.Parameters.Clear();
                cmd.CommandText = "GRAFO_LOCO.CargarLineasFactura";

                foreach(DataRow r in grdLineasFactura.Rows)
                {
                    if (r["Tipo"].ToString().Equals("consumible"))
                    {
                        SqlParameter factura = new SqlParameter("@IdFactura", idFactura);
                        factura.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(factura);
                        SqlParameter consumible = new SqlParameter("@IdConsumible", decimal.Parse(r["Item"].ToString()));
                        consumible.SqlDbType = SqlDbType.Decimal;
                        cmd.Parameters.Add(consumible);
                        SqlParameter cantidad = new SqlParameter("@Cantidad", decimal.Parse(r["Cantidad"].ToString()));
                        cantidad.SqlDbType = SqlDbType.Decimal;
                        cmd.Parameters.Add(cantidad);
                        SqlParameter precioUni = new SqlParameter("@PrecioUnitario", decimal.Parse(r["Total"].ToString()) / decimal.Parse(r["Cantidad"].ToString()));
                        precioUni.SqlDbType = SqlDbType.Decimal;
                        cmd.Parameters.Add(precioUni);
                        SqlParameter precioTot = new SqlParameter("@PrecioTotal", decimal.Parse(r["Total"].ToString()));
                        precioTot.SqlDbType = SqlDbType.Decimal;
                        cmd.Parameters.Add(precioTot);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }

                sqlTran.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    sqlTran.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            } 
        }

        private void cmbMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TipoPago)cmbMedioPago.SelectedItem).Descripcion.Equals("Efectivo")) // Efectivo
                grdLineasFactura.Enabled = false;
            else
                grdLineasFactura.Enabled = true; // Tarjeta
        }
    }
  }



