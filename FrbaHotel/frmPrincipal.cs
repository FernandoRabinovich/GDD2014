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
        public static string hotel;

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

                if (idUsuario != 3) //Guest
                    mCambiarPass.Visible = true;
                else
                    mCambiarPass.Visible = false;
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

        private void mAltaUsuario_Click(object sender, EventArgs e)
        {
            frmAltaUsuario frmAltaUsuario = new frmAltaUsuario();
            frmAltaUsuario.MdiParent = this;
            frmAltaUsuario.StartPosition = FormStartPosition.CenterScreen;
            frmAltaUsuario.Show();
        }

        private void mBajaUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.StartPosition = FormStartPosition.CenterScreen;
            frmUsuarios.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarPassword frmPass = new frmCambiarPassword();
            frmPass.MdiParent = this;
            frmPass.StartPosition = FormStartPosition.CenterScreen;
            frmPass.Show();
        }

        private void mAltaHabitacion_Click(object sender, EventArgs e)
        {
            frmAltaHabitacion frmAltaHab = new frmAltaHabitacion();
            frmAltaHab.MdiParent = this;
            frmAltaHab.StartPosition = FormStartPosition.CenterScreen;
            frmAltaHab.Show();
        }

        private void mModifHabitacion_Click(object sender, EventArgs e)
        {
            frmHabitaciones frmHab = new frmHabitaciones();
            frmHab.MdiParent = this;
            frmHab.StartPosition = FormStartPosition.CenterScreen;
            frmHab.Show();
        }

        private void mAltaRegimen_Click(object sender, EventArgs e)
        {
            frmAltaRegimen frmRegimen = new frmAltaRegimen();
            frmRegimen.MdiParent = this;
            frmRegimen.StartPosition = FormStartPosition.CenterScreen;
            frmRegimen.Show();
        }

        private void mCancelarReserva_Click(object sender, EventArgs e)
        {
            frmReservas frmReservas = new frmReservas();
            frmReservas.MdiParent = this;
            frmReservas.StartPosition = FormStartPosition.CenterScreen;
            frmReservas.Show();
        }
    }
}
