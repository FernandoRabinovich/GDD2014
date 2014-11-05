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
    public partial class frmModificarHotel : Form
    {
        Hotel hotel;
        
        public frmModificarHotel()
        {
            InitializeComponent();
        }

        public frmModificarHotel(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Cargo los regimenes nuevos para el hotel
            List<Regimen> regimenesNuevos = new List<Regimen>();
            foreach(Regimen r in chkRegimenes.CheckedItems)
                regimenesNuevos.Add(r);

            if (this.ValidarCamposRequeridos())
            { 
                /* Tengo que validar que si borra un regimen, no hay reservas hechas o huespedes actualmente bajo dicho regimen.*/
                /* Voy a eliminar las que destilta e insertar las nuevas que tilda */
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                cn.Open();
                SqlTransaction sqlTran = cn.BeginTransaction();
                cmd = cn.CreateCommand();
                cmd.Transaction = sqlTran;

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.ActualizarHotel";

                    SqlParameter IdHotel = new SqlParameter("@idHotel", hotel.Id);
                    IdHotel.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(IdHotel);
                    SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                    nombre.SqlDbType = SqlDbType.VarChar;
                    nombre.Size = 50;
                    cmd.Parameters.Add(nombre);
                    SqlParameter mail = new SqlParameter("@mail", txtMail.Text);
                    mail.SqlDbType = SqlDbType.VarChar;
                    mail.Size = 50;
                    cmd.Parameters.Add(mail);
                    SqlParameter estrellas = new SqlParameter("@estrellas", cantEstrellas.Value);
                    estrellas.SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.Add(estrellas);
                    SqlParameter telefono = new SqlParameter("@telefono", txtTelefono.Text);
                    telefono.SqlDbType = SqlDbType.VarChar;
                    telefono.Size = 15;
                    cmd.Parameters.Add(telefono);
                    SqlParameter direccion = new SqlParameter("@direccion", txtDireccion.Text);
                    direccion.SqlDbType = SqlDbType.VarChar;
                    direccion.Size = 255;
                    cmd.Parameters.Add(direccion);
                    SqlParameter ciudad = new SqlParameter("@ciudad", ((Ciudad)cmbCiudad.SelectedItem).Id);
                    ciudad.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(ciudad);
                    SqlParameter pais = new SqlParameter("@pais", txtPais.Text);
                    pais.SqlDbType = SqlDbType.VarChar;
                    pais.Size = 50;
                    cmd.Parameters.Add(pais);
                    SqlParameter numeroCalle = new SqlParameter("@numeroCalle", Int32.Parse(txtNumeroCalle.Text));
                    numeroCalle.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(numeroCalle);

                    cmd.ExecuteNonQuery();
                    
                    cmd.Parameters.Clear();
                    cmd.CommandText = "GRAFO_LOCO.ActualizarRegimenPorHotel";
                    cmd.Parameters.Add(hotel);
                    SqlParameter fechaSistema = new SqlParameter("@fechaSistema", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                    fechaSistema.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fechaSistema);
                    SqlParameter regimenes = new SqlParameter("@regimenes", regimenesNuevos);
                    regimenes.SqlDbType = SqlDbType.Structured;
                    cmd.Parameters.Add(regimenes);

                    cmd.ExecuteNonQuery();

                    sqlTran.Commit();

                    MessageBox.Show("La operación se realizó correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void frmModificarHotel_Load(object sender, EventArgs e)
        {
            #region CARGAR COMBOS

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRegimen";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow r in table.Rows)
                {
                    chkRegimenes.Items.Add(new Regimen(Int32.Parse(r["id"].ToString()), r["descripcion"].ToString(), decimal.Parse(r["precio"].ToString())));
                }

                foreach(Regimen r in hotel.Regimenes)
                {
                    chkRegimenes.SetItemChecked(chkRegimenes.Items.IndexOf(r), true);
                }

                cmd.CommandText = "GRAFO_LOCO.ObtenerCiudades";
                reader = cmd.ExecuteReader();

                while(reader.Read())
                    cmbCiudad.Items.Add(new Ciudad(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                reader.Close();
                if (cmd != null)
                    cmd.Dispose();
            }

            #endregion CARGAR COMBOS

            #region CARGAR DATOS

            txtNombre.Text = hotel.Descripcion;
            txtMail.Text = hotel.Mail;
            cantEstrellas.Value = hotel.Estrellas;
            txtTelefono.Text = hotel.Telefono;
            txtDireccion.Text = hotel.Direccion;
            txtNumeroCalle.Text = hotel.NumeroCalle.ToString();
            txtPais.Text = hotel.Pais;
            cmbCiudad.SelectedItem = hotel.Ciudad;


            #endregion CARGAR DATOS
        }

        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;

            if (txtNombre.Text.Length == 0)
                campo = txtNombre.Tag.ToString();
            if (txtMail.Text.Length == 0)
                campo = txtMail.Tag.ToString();
            if (txtTelefono.Text.Length == 0)
                campo = txtTelefono.Tag.ToString();
            if (txtDireccion.Text.Length == 0)
                campo = txtDireccion.Tag.ToString();
            if (txtPais.Text.Length == 0)
                campo = txtPais.Tag.ToString();
            if (cmbCiudad.SelectedItem == null)
                campo = cmbCiudad.Tag.ToString();
            if (chkRegimenes.CheckedItems.Count == 0)
                campo = chkRegimenes.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
