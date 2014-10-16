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
            string contraseña = textBox2.Text;
            SqlConnection cn = new SqlConnection("Data Source=GDDVM\\SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd; Password = gd2014");
            //falta agregar la ruta de conexion
            //conexion.....    aca iria la ruta de conexion
            try
            {
      
                cn.Open();//me conecto a la base desde que se quiere 'logear'
            }
            catch (Exception )
            {
                MessageBox.Show("Fallo en la Conexion, intente nuevamente");
            //validar con la base

        }

        
    }
 }
}