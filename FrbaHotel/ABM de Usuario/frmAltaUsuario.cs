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
            /* Tengo que cargar la lista de roles y la lista de hoteles (a los que pertenece el administrador, solo puede crear
               usuarios de hoteles a los que pertenece.*/

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRoles";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    lstRol.Items.Add(new Rol(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));


                cmd.CommandText = "GRAFO_LOCO.ObtenerHotelesPorUsuario";
                SqlParameter usuario = new SqlParameter("@user", frmPrincipal.idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    lstRol.Items.Add(new Hotel(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));

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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Tengo que cargar la lista de rol y de hoteles (solo puede modificar los hoteles a los que pertenece el administrador).

            #region Generar password
            SHA256 mySHA256 = SHA256Managed.Create();            
            byte[] byteArray = Encoding.UTF8.GetBytes(txtPassword.Text);
            MemoryStream stream = new MemoryStream(byteArray);            
            string pass = Convert.ToBase64String(mySHA256.ComputeHash(stream));
            #endregion

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            cn.Open();
            SqlTransaction sqlTran = cn.BeginTransaction();
            cmd = cn.CreateCommand();
            cmd.Transaction = sqlTran;

            try
            {
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

                Int32 idUsuario = (Int32)cmd.ExecuteScalar();

                /* Inserto los roles que tendrá el usuario*/
                cmd.Parameters.Clear();
                SqlParameter usuario = new SqlParameter("@idUsuario", idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);

                foreach (Rol r in lstRol.CheckedItems)
                {
                    SqlParameter rol = new SqlParameter("@idRol", r.Id);
                    rol.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(rol);

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("@idRol");
                }

                /* Inserto los hoteles a los que pertenecerá el usuario*/
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
}
