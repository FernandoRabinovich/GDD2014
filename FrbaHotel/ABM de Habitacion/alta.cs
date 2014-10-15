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
    public partial class VistaAlta : Form
    {
        #region variables
        string pisoHabitacion;
        string numeroDeHabitacion;
        string ubicacion;
        string comodidadesHabitacion;
        string tipoDeHabitacion;
        string idHabitacion;
        
    #endregion

        public VistaAlta()
        {
            InitializeComponent();
        }

        private void VistaAlta_Load(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection("Data Source=GDDVM\\SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd; Password = gd2014");
            
            try
            {
                cn.Open();//me conecto a la base desde que se quiere 'logear'
                MessageBox.Show("Conexión OK");

            }
            catch (Exception)
            {
                MessageBox.Show("Fallo en la Conexion, intente nuevamente");
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            #region validacion
            pisoHabitacion = piso.Text;
            numeroDeHabitacion = habitacionNumero.Text;//deberia validarse con la base de datos, para que no haya  dos iguales, por ahora esta validado como campo obligatorio
            ubicacion = ubicación.Text;
            comodidadesHabitacion = comodidades.Text;
            tipoDeHabitacion = habitacionTipo.Text;
            idHabitacion = textBox1.Text;
            try
            {
                validar(pisoHabitacion, numeroDeHabitacion, ubicacion, comodidadesHabitacion, tipoDeHabitacion,idHabitacion);
            }
            catch (Exception excepcion)
            {

                MessageBox.Show( excepcion.Message, "Error en el alta de habitación");
            }
            #endregion

            //grabar los datos en la base de datos


        }

        private void validar(string pisoHabitacion, string numeroDeHabitacion, string ubicacion, string comodidadesHabitacion, string tipoDeHabitacion, string idHabitacion)
        {
                if(pisoHabitacion == null) throw new Exception("Piso de la habitación no ingresado");
                if (numeroDeHabitacion == null) throw new Exception("Numero de la habitación no ingresado");
                if (ubicacion == null) throw new Exception("Ubicacion de la habitación no ingresado");
                if (comodidadesHabitacion == null) throw new Exception("Comodidades no especificadas");
                if (tipoDeHabitacion == null) throw new Exception("Ingrese tipo de habitación");
                if (idHabitacion == null) throw new Exception("Ingrese id de Habitacion");
            
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void habitacion_Enter(object sender, EventArgs e)
        {

        }

        private void habitacionNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            
             string idhab = textBox1.Text;
            SqlConnection cn = new SqlConnection("Data Source=GDDVM\\SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd; Password = gd2014");
            SqlCommand sql = new SqlCommand();
            SqlDataReader rs;
            sql.Connection = cn;
            sql.CommandText = "SELECT * FROM GRAFO_LOCO.Habitacion where idHabitacion = 2"; //Como se pasa el parametro idhab que ya "setie" antes?.
           
            cn.Open();
            rs = sql.ExecuteReader();
            //Debería en este caso completar los campos con la información que devuelve la consulta (siempre y cuando devuelva algo -> Mientras no sea fin de archivo 1 fila 1 columna)
            
            


            


        }

        
    }
}
