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
    public partial class frmSeleccionHotel : Form
    {
        int idUsuario;

        public frmSeleccionHotel()
        {
            InitializeComponent();
        }

        public frmSeleccionHotel(int idUsuario)
        {
            InitializeComponent();

            this.idUsuario = idUsuario;
        }

        private void frmSeleccionHotel_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerHotelesPorUsuario";

                SqlParameter usuario = new SqlParameter("@user", this.idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstHotel.Items.Add(new Hotel(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstHotel.SelectedItem != null)
            {
                int idHotel = ((Hotel)lstHotel.SelectedItem).Id;
                frmSeleccionRol frmSelectRol = new frmSeleccionRol(idUsuario, idHotel);
                frmSelectRol.StartPosition = FormStartPosition.CenterScreen;
                frmSelectRol.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Debe seleccionar un hotel", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
