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
    public partial class frmUsuarios : Form
    {
        Usuario usuarioSeleccionado = new Usuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //Tengo que cargar todos los usuarios que pertenecen al hotel logueado (en un grid con todos los datos).
            //Tengo que guardar el nombre del hotel en la "sesion" para no tener que preguntarle a la BDD.

            this.Text = this.Text + " - " + frmPrincipal.hotel;

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerUsuariosPorHotel";

                SqlParameter hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                grdUsuarios.DataSource = table;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Tengo que crear el objeto usuario con los datos del seleccionado
            this.UsuarioSeleccionado();

            frmModifUsuario frmModifUsuario = new frmModifUsuario(usuarioSeleccionado);
            frmModifUsuario.StartPosition = FormStartPosition.CenterScreen;
            frmModifUsuario.ShowDialog();
        }

        private void UsuarioSeleccionado()
        {
            this.usuarioSeleccionado.Id = Int32.Parse(grdUsuarios.SelectedRows[0].Cells["idUsuario"].Value.ToString());
            this.usuarioSeleccionado.Apellido = grdUsuarios.SelectedRows[0].Cells["Apellido"].Value.ToString();
            this.usuarioSeleccionado.Direccion = grdUsuarios.SelectedRows[0].Cells["Direccion"].Value.ToString();
            this.usuarioSeleccionado.Estado = grdUsuarios.SelectedRows[0].Cells["Estado"].Value.ToString();
            this.usuarioSeleccionado.FechaNacimiento = DateTime.Parse(grdUsuarios.SelectedRows[0].Cells["FechaNacimiento"].Value.ToString());
            this.usuarioSeleccionado.Mail = grdUsuarios.SelectedRows[0].Cells["Mail"].Value.ToString();
            this.usuarioSeleccionado.Nonbre = grdUsuarios.SelectedRows[0].Cells["Nonbre"].Value.ToString();
            this.usuarioSeleccionado.Numero = Int32.Parse(grdUsuarios.SelectedRows[0].Cells["Numero"].Value.ToString());
            this.usuarioSeleccionado.NumeroDoc = Int32.Parse(grdUsuarios.SelectedRows[0].Cells["NumeroDoc"].Value.ToString());
            this.usuarioSeleccionado.Piso = Int32.Parse(grdUsuarios.SelectedRows[0].Cells["Piso"].Value.ToString());
            this.usuarioSeleccionado.Telefono = grdUsuarios.SelectedRows[0].Cells["Telefono"].Value.ToString();
            this.usuarioSeleccionado.TipoDoc = grdUsuarios.SelectedRows[0].Cells["TipoDoc"].Value.ToString();
            this.usuarioSeleccionado.UserName = grdUsuarios.SelectedRows[0].Cells["UserName"].Value.ToString();
        }

        private void ConfigurarGrilla()
        {
            grdUsuarios.Columns["idUsuario"].Visible = false;
        }
    }
}
