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
    public partial class SeleccionHotel : Form
    {
        private string usuario;
        public SeleccionHotel(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                DataSet ds = new DataSet();
                SqlConnection cn = new SqlConnection("Data Source=GDDVM\\SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd; Password = gd2014");
            //falta agregar la ruta de conexion
            //conexion.....    aca iria la ruta de conexion
            try
            {
                
                cn.Open();//me conecto a la base desde que se quiere 'logear'
                SqlCommand sql = new SqlCommand ("exec sp_accesousuarios @username", cn);
                sql.Parameters.AddWithValue("@username",usuario);
                sql.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataTable dt = new DataTable("AccesoUsuario");
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "NOMBRE";
                comboBox1.ValueMember = "IDUSUARIO";
                textBox1.Text = usuario;
                if (usuario == "guest")
                    {
                        textBox1.Visible = false;
                        label2.Visible = false;
                     }

                


                
                 
        }
    catch (Exception )
            {
               

            //validar con la base
        }
            finally{
                cn.Close();
                }
 }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    }

        private void button2_Click(object sender, EventArgs e)
        {

            if (usuario == "guest")
            {
                PantallaInicio form1 = new PantallaInicio();
                this.Close();
                form1.Show();
                            }
            else 
                {
            login form = new login();
            this.Close();
            form.Show();
                }
        }
}
               
        

      
             
  
}
