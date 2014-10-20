using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace FrbaHotel
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRol.Text = "";
            txtNombre.Text = "";
            cmbTipoDoc.Text = "";
            txtNroDocumento.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            fechaNacimiento.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tengo que cargar el combo de rol y el txtHotel (solo puede crear usuarios del hotel donde este logueado).
            /* Elijo un combo para Rol porque, el enunciado dice que por ahora solo puede tener un Rol asignado (de todas formas
             * la BDD soporta múltiples roles para un usuario, al igual que el login.
             */

            txtHotel.Text = frmPrincipal.hotel;

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRoles";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmbRol.DataSource = table;

                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoDoc";
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                cmbTipoDoc.DataSource = table;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Tengo que cargar el combo de rol y el txtHotel (solo puede crear usuarios del hotel donde este logueado).
            /* Elijo un combo para Rol porque, el enunciado dice que por ahora solo puede tener un Rol asignado (de todas formas
             * la BDD soporta múltiples roles para un usuario, al igual que el login.
             */

            #region Generar password
            SHA256 mySHA256 = SHA256Managed.Create();            
            byte[] byteArray = Encoding.UTF8.GetBytes(txtPassword.Text);
            MemoryStream stream = new MemoryStream(byteArray);            
            string pass = Convert.ToBase64String(mySHA256.ComputeHash(stream));
            #endregion

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
                SqlParameter password = new SqlParameter("@password", pass);
                password.SqlDbType = SqlDbType.VarChar;
                password.Size = 65;
                cmd.Parameters.Add(password);
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
