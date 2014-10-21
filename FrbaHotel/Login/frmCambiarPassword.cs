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
    public partial class frmCambiarPassword : Form
    {
        public frmCambiarPassword()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPassNueva.Text.Equals(txtPassRepetir.Text))
            { 
                // Valido que la contraseña anterior sea la del user logueado, de ser así
                // actualizo la pass.

                #region Generar password
                SHA256 mySHA256 = SHA256Managed.Create();
                byte[] byteArrayAnterior = Encoding.UTF8.GetBytes(txtPassAnterior.Text);
                MemoryStream stream = new MemoryStream(byteArrayAnterior);
                string passwordAnterior = Convert.ToBase64String(mySHA256.ComputeHash(stream));

                byte[] byteArrayNuevo = Encoding.UTF8.GetBytes(txtPassNueva.Text);
                stream = new MemoryStream(byteArrayNuevo);
                string passwordNuevo = Convert.ToBase64String(mySHA256.ComputeHash(stream));
                #endregion

                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.ActualizarPass";
      
                    SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
                    usuario.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(usuario);

                    SqlParameter passAnterior = new SqlParameter("@passAnterior", passwordAnterior);
                    passAnterior.SqlDbType = SqlDbType.VarChar;
                    passAnterior.Size = 65;
                    cmd.Parameters.Add(passAnterior);

                    SqlParameter passNueva = new SqlParameter("@passNueva", passwordNuevo);
                    passNueva.SqlDbType = SqlDbType.VarChar;
                    passNueva.Size = 65;
                    cmd.Parameters.Add(passNueva);

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
            else
                MessageBox.Show("Debe repetir la contraseña correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
