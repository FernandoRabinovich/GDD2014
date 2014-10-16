using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class AltaCliente : Form
    {
        System.Data.SqlClient.SqlConnection conexion;
        public AltaCliente()
        {
            InitializeComponent();
        }
       
          private void AltaCliente_Load(object sender, EventArgs e)
        {
            conexion = new System.Data.SqlClient.SqlConnection();//falta agregar la ruta de conexion
            //conexion.....    aca iria la ruta de conexion
            try
            {
                conexion.Open();//me conecto a la base desde que empieza la aplicacion o se selecionado el Alta de un Cliente
            }
            catch (Exception )
            {
                MessageBox.Show("Fallo en la Conexion, intente nuevamente");
            }
          }
      
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            #region variables
            string nombreUsuario;
            string contraseña;
            string tipoDeDocumento;
            string numeroDeDocumento;
            string mail;
            string telefono;
            string calle;
            string localidad;
            string pais;
            string nacionalidad;
            string fechaDeNacimiento;
            #endregion
          
             nombreUsuario = textBox1.Text;//Nombre
             contraseña = textBox2.Text;//Constraseña
             tipoDeDocumento = textBox11.Text;//Tipo de Documento
             numeroDeDocumento = textBox3.Text;//Numero de Documento
             mail = textBox4.Text;// Mail
             telefono = textBox5.Text;//telefono
             calle = textBox6.Text; //Calle, direccion
             localidad = textBox7.Text;
             pais = textBox8.Text;
             nacionalidad = textBox9.Text;
             fechaDeNacimiento = textBox10.Text;
            
            
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            conexion.Close();//cierro la conexion a la base de datos
            this.Close(); //al cerrar esta pantalla, vuelvo a la pantalla principal
        }
        
        
        
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

   
    }
}
