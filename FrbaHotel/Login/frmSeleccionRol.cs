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
    public partial class frmSeleccionRol : Form
    {
        int idUsuario;
        int idHotel;
        string hotel;

        public frmSeleccionRol()
        {
            InitializeComponent();
        }

        public frmSeleccionRol(int idUsuario, int idHotel, string hotel)
        {
            InitializeComponent();
            this.idHotel = idHotel;
            this.idUsuario = idUsuario;
            this.hotel = hotel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstRol.SelectedItem != null)
            {
                int idRol = ((Rol)lstRol.SelectedItem).Id;
                frmPrincipal.idUsuario = idUsuario;
                frmPrincipal.idHotel = idHotel;
                frmPrincipal.idRol = idRol;
                frmPrincipal.hotel = this.hotel;
                this.Close();
            }
            else
                MessageBox.Show("Debe seleccionar un rol", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmSeleccionRol_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRolesPorUsuario";

                SqlParameter usuario = new SqlParameter("@user", this.idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (Int32.Parse(reader["pertenece"].ToString()) == 1)
                        lstRol.Items.Add(new Rol(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
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
