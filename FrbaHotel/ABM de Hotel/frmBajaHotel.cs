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
    public partial class frmBajaHotel : Form
    {
        int idHotel;

        public frmBajaHotel()
        {
            InitializeComponent();
        }

        public frmBajaHotel(int idHotel)
        {
            InitializeComponent();
            this.idHotel = idHotel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /* Tengo que validar que en las fechas indicadas el hotel se encuentre vacío */            
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.InhabilitarHotel";

                SqlParameter fDesde = new SqlParameter("@fechaDesde", fechaDesde.Value);
                fDesde.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fDesde);
                SqlParameter fHasta = new SqlParameter("@fechaHasta", fechaHasta.Value);
                fHasta.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fHasta);
                SqlParameter motivo = new SqlParameter("@idMotivo", ((Motivo)cmbMotivo.SelectedItem).Id);
                motivo.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(motivo);
                SqlParameter observaciones = new SqlParameter("@observaciones", txtMotivo.Text);
                observaciones.SqlDbType = SqlDbType.VarChar;
                observaciones.Size = 255;
                cmd.Parameters.Add(observaciones);

                cmd.ExecuteNonQuery();
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

        private void frmBajaHotel_Load(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerMotivosCierre";
                reader = cmd.ExecuteReader();

                while(reader.Read())
                    cmbMotivo.Items.Add(new TipoHabitacion(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
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
        }
    }
}
