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
    public partial class frmModifUsuario : Form
    {
        Usuario usuario = new Usuario();

        public frmModifUsuario()
        {
            InitializeComponent();
        }

        public frmModifUsuario(Usuario user)
        {
            InitializeComponent();

            this.usuario = user;
        }

        private void frmModifUsuario_Load(object sender, EventArgs e)
        {
            /* Tengo que levantar los roles asignados a este usuario */
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "GRAFO_LOCO.ObtenerRolesPorUsuario";

                SqlParameter usuario = new SqlParameter("@user", this.usuario.Id);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstRol.Items.Add(new Rol(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()), Int32.Parse(reader["pertenece"].ToString()) == 1 ? true:false);
                }

                /* Tengo que levantar los hoteles asignados a este usuario pero que pertenezcan al usuario logueado también (solo puede modificar los
                hoteles a los que pertenece). */
                cmd.Parameters.Clear();
                reader.Close();
                cmd.CommandText = "GRAFO_LOCO.ObtenerHotelesPorUsuarioPorAdministrador";

                SqlParameter admin = new SqlParameter("@idAdmin", frmPrincipal.idUsuario);
                admin.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(admin);
                cmd.Parameters.Add(usuario);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                    lstHoteles.Items.Add(new Hotel(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()), Int32.Parse(reader["pertenece"].ToString()) == 1 ? true:false);

                cmd.Parameters.Clear();
                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoDocumento";
                reader.Close();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    cmbTipoDoc.Items.Add(new TipoDoc(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));

                //Acá tengo que cargar los datos del usuario para poder modificarlo.
                txtApellido.Text = this.usuario.Apellido;
                txtDireccion.Text = this.usuario.Direccion;
                chkEstado.Checked = this.usuario.Estado.Equals("Activo") ? true : false;
                fechaNacimiento.Value = this.usuario.FechaNacimiento;
                txtMail.Text = this.usuario.Mail;
                txtNombre.Text = this.usuario.Nombre;
                txtNumero.Text = this.usuario.Numero.ToString();
                txtNroDocumento.Text = this.usuario.NumeroDoc.ToString();
                txtPiso.Text = this.usuario.Piso.ToString();
                txtTelefono.Text = this.usuario.Telefono;
                cmbTipoDoc.SelectedValue = this.usuario.TipoDoc;
                txtUsername.Text = this.usuario.UserName;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposRequeridos())
            {
                //Actualizar los datos del usuario
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                cn.Open();
                SqlTransaction sqlTran = cn.BeginTransaction();
                cmd = cn.CreateCommand();
                cmd.Transaction = sqlTran;

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    /* ACTUALIZO EL USUARIO */
                    cmd.CommandText = "GRAFO_LOCO.ActualizarUsuario";

                    SqlParameter usuario = new SqlParameter("@idUsuario", this.usuario.Id);
                    usuario.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(usuario);
                    SqlParameter userName = new SqlParameter("@userName", txtUsername.Text);
                    userName.SqlDbType = SqlDbType.VarChar;
                    userName.Size = 20;
                    cmd.Parameters.Add(userName);
                    SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                    nombre.SqlDbType = SqlDbType.VarChar;
                    nombre.Size = 30;
                    cmd.Parameters.Add(nombre);
                    SqlParameter apellido = new SqlParameter("@apellido", txtApellido.Text);
                    apellido.SqlDbType = SqlDbType.VarChar;
                    apellido.Size = 30;
                    cmd.Parameters.Add(apellido);
                    SqlParameter tipoDoc = new SqlParameter("@tipoDoc", ((TipoDoc)cmbTipoDoc.SelectedItem).Id);
                    tipoDoc.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(tipoDoc);
                    SqlParameter nroDoc = new SqlParameter("@nroDoc", txtNroDocumento.Text);
                    nroDoc.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(nroDoc);
                    SqlParameter mail = new SqlParameter("@mail", txtMail.Text);
                    mail.SqlDbType = SqlDbType.VarChar;
                    mail.Size = 30;
                    cmd.Parameters.Add(mail);
                    SqlParameter telefono = new SqlParameter("@telefono", txtTelefono.Text);
                    telefono.SqlDbType = SqlDbType.VarChar;
                    telefono.Size = 15;
                    cmd.Parameters.Add(telefono);
                    SqlParameter direccion = new SqlParameter("@direccion", txtDireccion.Text);
                    direccion.SqlDbType = SqlDbType.VarChar;
                    direccion.Size = 40;
                    cmd.Parameters.Add(direccion);
                    SqlParameter fechaNac = new SqlParameter("@fechaNac", fechaNacimiento.Value);
                    fechaNac.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fechaNac);
                    SqlParameter estado = new SqlParameter("@estado", chkEstado.Checked);
                    estado.SqlDbType = SqlDbType.Bit;
                    cmd.Parameters.Add(estado);
                    SqlParameter numero = new SqlParameter("@numero", Int32.Parse(txtNumero.Text));
                    numero.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(numero);
                    SqlParameter piso = new SqlParameter("@piso", Int32.Parse(txtPiso.Text));
                    piso.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(piso);

                    cmd.ExecuteNonQuery();

                    /* ELIMINO LOS ROLES */
                    cmd.Parameters.Clear();
                    cmd.CommandText = "GRAFO_LOCO.EliminarRolesPorUsuario";
                    cmd.Parameters.Add(usuario);

                    /* RECREO LOS ROLES */
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(usuario);

                    foreach (Rol r in lstRol.CheckedItems)
                    {
                        SqlParameter rol = new SqlParameter("@idRol", r.Id);
                        rol.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(rol);

                        cmd.ExecuteNonQuery();

                        cmd.Parameters.RemoveAt("@idRol");
                    }

                    /* ELIMINO LOS HOTELES */
                    cmd.Parameters.Clear();
                    cmd.CommandText = "GRAFO_LOCO.EliminarHotelesPorUsuarioPorAdmin";
                    SqlParameter admin = new SqlParameter("@idAdmin", frmPrincipal.idUsuario);
                    admin.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(admin);
                    cmd.Parameters.Add(usuario);

                    /* RECREO LOS HOTELES */
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(usuario);

                    foreach (Hotel h in lstHoteles.CheckedItems)
                    {
                        SqlParameter hotel = new SqlParameter("@idHotel", h.Id);
                        hotel.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(hotel);

                        cmd.ExecuteNonQuery();

                        cmd.Parameters.RemoveAt("@idHotel");
                    }

                    sqlTran.Commit();

                    MessageBox.Show("La operación se realizó correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    try
                    {
                        sqlTran.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    cn.Close();

                    if (cmd != null)
                        cmd.Dispose();
                }
            }
        }

        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;

            if (txtUsername.Text.Length == 0)
                campo = txtUsername.Tag.ToString();
            if (txtNombre.Text.Length == 0)
                campo = txtNombre.Tag.ToString();
            if (txtApellido.Text.Length == 0)
                campo = txtApellido.Tag.ToString();
            if (txtNroDocumento.Text.Length == 0)
                campo = txtNroDocumento.Tag.ToString();
            if (cmbTipoDoc.SelectedItem == null)
                campo = cmbTipoDoc.Tag.ToString();
            if (txtMail.Text.Length == 0)
                campo = txtMail.Tag.ToString();
            if (txtTelefono.Text.Length == 0)
                campo = txtTelefono.Tag.ToString();
            if (txtDireccion.Text.Length == 0)
                campo = txtDireccion.Tag.ToString();
            if (txtNumero.Text.Length == 0)
                campo = txtNumero.Tag.ToString();
            if (txtPiso.Text.Length == 0)
                campo = txtPiso.Tag.ToString();
            if (lstRol.Items.Count == 0)
                campo = lstRol.Tag.ToString();
            if (lstHoteles.Items.Count == 0)
                campo = lstHoteles.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
