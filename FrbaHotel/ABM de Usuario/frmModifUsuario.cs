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
        Usuario usuario;

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
            //Acá tengo que cargar los datos del usuario para poder modificarlo.
            txtApellido.Text = this.usuario.Apellido;
            txtDireccion.Text = this.usuario.Direccion;
            chkEstado.Checked = this.usuario.Estado.Equals("Activo") ? true:false;
            fechaNacimiento.Value = this.usuario.FechaNacimiento;
            txtMail.Text = this.usuario.Mail; ;
            txtNombre.Text = this.usuario.Nonbre;
            txtNumero.Text = this.usuario.Numero.ToString();
            txtNroDocumento.Text = this.usuario.NumeroDoc.ToString();
            txtPiso.Text = this.usuario.Piso.ToString();
            txtTelefono.Text = this.usuario.Telefono;
            cmbTipoDoc.SelectedValue = this.usuario.TipoDoc;
            txtUsername.Text = this.usuario.UserName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Actualizar los datos del usuario
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.IngresarUsuario";

                SqlParameter userName = new SqlParameter("@userName", txtUsername.Text);
                userName.SqlDbType = SqlDbType.VarChar;
                userName.Size = 20;
                cmd.Parameters.Add(userName);
                SqlParameter rol = new SqlParameter("@rol", ((Rol)cmbRol.SelectedItem).Id);
                rol.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(rol);
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
                SqlParameter hotel = new SqlParameter("@hotel", frmPrincipal.idHotel);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);
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
