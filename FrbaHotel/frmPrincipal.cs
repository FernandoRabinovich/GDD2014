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
        public static int idUsuario;
        public static int idHotel;
        public static int idRol;

        public frmPrincipal()
        {
            InitializeComponent();

            login login = new login();
            login.Closed += new EventHandler(DisposeChildForm);
            login.ShowDialog();

            this.LoguearUsuarioConPermisos(idUsuario, idHotel, idRol);
        }

        public void LoguearUsuarioConPermisos(int idUser, int idDeHotel, int idDeRol)
        {
            idUsuario = idUser;
            idHotel = idDeHotel;
            idRol = idDeRol;

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
                            {
                                item2.Visible = true;
                                item.Visible = true;
                            }
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
        }

        private void DisposeChildForm(object sender, System.EventArgs e)
        {
            ((Form)sender).Dispose();
            this.Show();
        }

        private void mEstadistico_Click(object sender, EventArgs e)
        {
            frmListadoEstadistico frmEstadistico = new frmListadoEstadistico();
            frmEstadistico.StartPosition = FormStartPosition.CenterScreen;
            frmEstadistico.MdiParent = this;
            frmEstadistico.Show();
        }

        private void mAltaRol_Click(object sender, EventArgs e)
        {
            frmAltaRol frmRol = new frmAltaRol();
            frmRol.MdiParent = this;
            frmRol.StartPosition = FormStartPosition.CenterScreen;
            frmRol.Show();
        }

        private void mBajaRol_Click(object sender, EventArgs e)
        {
            frmRoles frmRoles = new frmRoles();
            frmRoles.MdiParent = this;
            frmRoles.StartPosition = FormStartPosition.CenterScreen;
            frmRoles.Show();
        }
    }
}
