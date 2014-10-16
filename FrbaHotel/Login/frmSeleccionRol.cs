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

        public frmSeleccionRol()
        {
            InitializeComponent();
        }

        public frmSeleccionRol(int idUsuario, int idHotel)
        {
            InitializeComponent();
            this.idHotel = idHotel;
            this.idUsuario = idUsuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lstRol.SelectedItem != null)
            {
                int idRol = ((Rol)lstRol.SelectedItem).Id;
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.LoguearUsuarioConPermisos(idUsuario, idHotel, idRol);

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
