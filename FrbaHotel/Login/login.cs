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
            string usuario = textBox1.Text;
            string clave   = textBox2.Text;
            string clavepassword ;
            string estado;

                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection("Data Source=GDDVM\\SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd; Password = gd2014");
            //falta agregar la ruta de conexion
            //conexion.....    aca iria la ruta de conexion
            try
            {
                cn.Open();//me conecto a la base desde que se quiere 'logear'
                SqlCommand sql = new SqlCommand ("select username,password,estado from Grafo_loco.usuario where Username = @username", cn);
                sql.Parameters.AddWithValue("@username", usuario);
                SqlDataAdapter da = new SqlDataAdapter(sql);
                da.Fill(ds);
                estado = ds.Tables[0].Rows[0][2].ToString();
                clavepassword = ds.Tables[0].Rows[0][1].ToString();
                 
                    if (estado == "True") {
                        if (clave == clavepassword) {
                            SqlCommand sql2 = new SqlCommand("UPDATE Grafo_loco.usuario SET CANTLOGININCORRECTOS = 0 where Username = @username", cn);
                            sql2.Parameters.AddWithValue("@username", usuario);
                            sql2.ExecuteNonQuery();
                            SeleccionHotel vista = new SeleccionHotel(usuario);
                            vista.Show();
                            this.Close();
                                }
                            else 
                            {
                                SqlCommand sql1 = new SqlCommand("UPDATE Grafo_loco.usuario SET CANTLOGININCORRECTOS = CANTLOGININCORRECTOS + 1 where Username = @username", cn);
                                sql1.Parameters.AddWithValue("@username", usuario);
                                sql1.ExecuteNonQuery();
                                
                                MessageBox.Show("Clave incorrecta");
                                textBox2.Text = "";
                                textBox1.Focus();
                             }
                    }
                                                      
                        else
                        {
                            MessageBox.Show ("Usuario inhabilitado");
                            cn.Close();
                            this.Close();
                            
                            }
                       
                   
            }             
                              
            
            catch (Exception )
            {
              { 
                  MessageBox.Show("Usuario inexistente");
                       textBox2.Text = "";
                       textBox1.Text = "";
                       textBox1.Focus();
                  }

            //validar con la base
        }
            finally{
                cn.Close();
                }
 }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
               
         }

        }

        
 

        
   