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
    public partial class frmPrincipal : Form
    {
        int idUsuario;
        int idHotel;
        int idRol;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mLogin_Click(object sender, EventArgs e)
        {
            login frmLogin = new login();
            frmLogin.ShowDialog();
        }

        public void LoguearUsuarioConPermisos(int idUsuario, int idHotel, int idRol)
        {
            this.idUsuario = idUsuario;
            this.idHotel = idHotel;
            this.idRol = idRol;

            // Acá tengo que obtener las funcionalidades por rol y actualizar el menú (el login lo saco).
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerFuncionalidadesPorRol";

                SqlParameter rol = new SqlParameter("@rol", idRol);
                rol.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(rol);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    foreach (ToolStripMenuItem item in menuStrip.Items)
                    {
                        foreach (ToolStripMenuItem item2 in item.DropDown.Items)
                        {
                            if ((item2.Tag != null) && (!string.IsNullOrEmpty(item2.Tag.ToString())) && (Int32.Parse(item2.Tag.ToString()) == Int32.Parse(reader["id"].ToString())))
                                item2.Visible = true;   
                        }
                    }
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

            mLogin.Visible = false;
        }
    }
}
