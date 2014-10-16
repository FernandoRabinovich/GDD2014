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
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {                                  
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            SHA256 mySHA256 = SHA256Managed.Create();            
            byte[] byteArray = Encoding.UTF8.GetBytes(txtPass.Text);
            MemoryStream stream = new MemoryStream(byteArray);
            //string password = System.Text.Encoding.UTF8.GetString(mySHA256.ComputeHash(stream));
            string password = Convert.ToBase64String(mySHA256.ComputeHash(stream));
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            int idUsuario = 0;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ValidarUsuario";
                /* Me conviene hacer una funcion que me retorne lo que sucedió:
                 * idUsuario - OK
                 * -1 - Usuario incorrecto
                 * -2 - Password Incorrecta -> En este caso, aumento en 1 la cantidad de login incorrecto.
                 * -3 - Usuario bloqueado
                 */
                SqlParameter usuario = new SqlParameter("@user", txtUsuario.Text);
                usuario.SqlDbType = SqlDbType.VarChar;
                usuario.Size = 20;
                cmd.Parameters.Add(usuario);

                SqlParameter pass = new SqlParameter("@pass", password);
                pass.SqlDbType = SqlDbType.VarChar;
                pass.Size = 65;
                cmd.Parameters.Add(pass);

                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                switch (reader["estado"].ToString())
                {
                    case "-1": MessageBox.Show("Usuario incorrecto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case "-2": MessageBox.Show("Password incorrecta.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                    case "-3": MessageBox.Show("Usuario bloqueado. Comuníquese con el administrador.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop); break;
                    default: idUsuario = Int32.Parse(reader["estado"].ToString()); break;
                }

                // Si todo estuvo OK debo verificar si ese usuario pertenece a mas de un hotel para que lo seleccione y si
                // posee mas de un rol para que tambien lo seleccione.
                if (idUsuario > 0)
                {
                    frmSeleccionHotel frmSelectHotel = new frmSeleccionHotel(idUsuario);
                    frmSelectHotel.ShowDialog();
                    this.Close();
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