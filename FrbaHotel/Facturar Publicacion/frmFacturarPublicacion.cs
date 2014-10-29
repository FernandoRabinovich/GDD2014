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
        int IdHotel;
        int nroDeEstadia;
        public frmFacturarPublicacion(int idDeHotel, int nroEstadia)
        {
            
            InitializeComponent();
            IdHotel = idDeHotel;
            nroDeEstadia = nroEstadia;
        }

               private void frmFacturarPublicacion_Load(object sender, EventArgs e)
        {
            ObtenerNroFactura();
            ObtenerNombreHotel();
            ObtenerInformacionEstadia (nroDeEstadia);
            FechaFactura.Text = (System.Configuration.ConfigurationSettings.AppSettings["fechasistema"].ToString());
            ObtenerMediosPago();
                   }

               private void ObtenerMediosPago()
               {
                                        
            SqlConnection cn1 = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd1 = null;            

            try
            {
                cn1.Open();
                cmd1 = new SqlCommand();
                cmd1.Connection = cn1;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "GRAFO_LOCO.ObtenerMediosPago";
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable("MediosPago");
            da.Fill(dt);
            MedioPago.DataSource = dt;
            MedioPago.DisplayMember = "DESCRIPCION";
            MedioPago.ValueMember = "IDTIPOPAGO";
            MedioPago.SelectedIndex = -1;

        }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn1.Close();
                if (cmd1 != null)
                    cmd1.Dispose();
            }
                    }

        

        
        private void NroDeFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaFactura_TextChanged(object sender, EventArgs e)
        {

        }

        
      
        private void NroDeEstadia_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void MedioDePago_Leave(object sender, EventArgs e)
        {
            if (MedioPago.Text == "Tarjeta")
            {
                NombreTarjeta.Enabled = true;
                NumeroTarjeta.Enabled = true;
            }
            else
            {
                NombreTarjeta.Enabled = false;
                NumeroTarjeta.Enabled = false;
            }
          }

        private void ObtenerNroFactura()
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerNúmeroDeFacturaSiguiente";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    NroDeFactura.Text = reader["Número Factura"].ToString();
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
        }
        

        private void ObtenerNombreHotel()          
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerNombreHotel";
                SqlParameter idHotel = new SqlParameter("@IdHotel", IdHotel);
                cmd.Parameters.Add(idHotel);
                reader = cmd.ExecuteReader();
                if (reader.Read()){
                    NombreHotel.Text = reader["Nombre"].ToString();
                    NombreHotel.Enabled = false;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();

                 



        }
    }

        private void ObtenerInformacionEstadia (int estadia){
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
                SqlParameter idestadia = new SqlParameter("@idestadia", nroDeEstadia);
                cmd.Parameters.Add(idestadia);
                reader = cmd.ExecuteReader();
                if (reader.Read()){
                    NroPasaporte.Text = reader["Numero Pasaporte"].ToString();
                    NroPasaporte.Enabled = false;
                    NombreCliente.Text = reader["Nombre Cliente"].ToString();
                    NombreCliente.Enabled = false;
                    NroDeEstadia.Enabled = false;
                    NroDeEstadia.Text = estadia.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
            }
  }
}
