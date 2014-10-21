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
    public partial class frmHabitaciones : Form
    {
        Habitacion habitacionSeleccionada = new Habitacion();

        public frmHabitaciones()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Tengo que crear el objeto usuario con los datos del seleccionado
            this.HabitacionSeleccionada();

            frmModifHabitacion frmModifHabitacion = new frmModifHabitacion(habitacionSeleccionada);
            frmModifHabitacion.StartPosition = FormStartPosition.CenterScreen;
            frmModifHabitacion.ShowDialog();
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + frmPrincipal.hotel;

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerHabitacionesPorHotel";

                SqlParameter hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                grdHabitaciones.DataSource = table;
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

            this.ConfigurarGrilla();
        }

        private void ConfigurarGrilla()
        {
            grdHabitaciones.Columns["idHabitacion"].Visible = false;
        }

        private void HabitacionSeleccionada()
        {
            this.habitacionSeleccionada.Id = Int32.Parse(grdHabitaciones.SelectedRows[0].Cells["idHabitacion"].Value.ToString());
            this.habitacionSeleccionada.Descripcion = grdHabitaciones.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            this.habitacionSeleccionada.Estado = grdHabitaciones.SelectedRows[0].Cells["Estado"].Value.ToString();
            this.habitacionSeleccionada.Frente = grdHabitaciones.SelectedRows[0].Cells["Frente"].Value.ToString();
            this.habitacionSeleccionada.Numero = Int32.Parse(grdHabitaciones.SelectedRows[0].Cells["Numero"].Value.ToString());
            this.habitacionSeleccionada.Piso = Int32.Parse(grdHabitaciones.SelectedRows[0].Cells["Piso"].Value.ToString());
            this.habitacionSeleccionada.TipoHabitacion = grdHabitaciones.SelectedRows[0].Cells["TipoHabitacion"].Value.ToString();
        }
    }
}
