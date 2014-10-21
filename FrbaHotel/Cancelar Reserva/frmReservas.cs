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
    public partial class frmReservas : Form
    {
        /* Acá listo las reservas pertenecientes al hotel logueado. Además, solo se ven las que no fueron utilizadas (estadia) o las que no se cancelaron por
         * cualquier motivo o las que no se encuentren menores a la fecha de hoy (en este caso la del sistema).
         */
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + frmPrincipal.hotel;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerReservasAlDiaPorHotel";

                if(!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    SqlParameter codigo = new SqlParameter("@codigo", Int32.Parse(txtCodigo.Text));
                    codigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(codigo);
                }
                SqlParameter hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);
                if (!string.IsNullOrEmpty(txtNroDocumento.Text))
                {
                    SqlParameter nroDoc = new SqlParameter("@nroDoc", Int32.Parse(txtNroDocumento.Text));
                    nroDoc.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(nroDoc);
                }
                SqlParameter fecha = new SqlParameter("@fecha", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                fecha.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fecha);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);

                grdReservas.DataSource = table;
                
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmCancelarReserva frmCancelar = new frmCancelarReserva(Int32.Parse(grdReservas.SelectedRows[0].Cells["Codigo"].ToString()));
            frmCancelar.StartPosition = FormStartPosition.CenterScreen;
            frmCancelar.ShowDialog();
        }
    }
}
