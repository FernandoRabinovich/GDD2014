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
    public partial class frmModificarReserva : Form
    {
        public frmModificarReserva()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
             
            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ModificarReserva";

                SqlParameter fDesde = new SqlParameter("@fechaDesde", fechaDesde.Value);
                fDesde.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fDesde);
                SqlParameter fHasta = new SqlParameter("@fechaHasta", fechaHasta.Value);
                fHasta.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fHasta);
                SqlParameter hotel = new SqlParameter("@idHotel", ((Hotel)cmbHotel.SelectedItem).Id);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);
                SqlParameter fechaCreacion = new SqlParameter("@fechaCreacion", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                fechaCreacion.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fechaCreacion);
                SqlParameter regimen = new SqlParameter("@idRegimen", ((Regimen)cmbRegimenHotel.SelectedItem).Id);
                regimen.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(regimen);
                SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);

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

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Aca tengo que buscar la reserva y cargar los datos
        }

        private void frmModificarReserva_Load(object sender, EventArgs e)
        {
            // Aca tengo que cargar los combos
        }
    }
}
