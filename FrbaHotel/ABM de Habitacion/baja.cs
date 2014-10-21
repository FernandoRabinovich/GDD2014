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
    public partial class baja : Form
    {
        public baja()
        {
            InitializeComponent();
        }

        private void baja_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=GDDVM\\SQLSERVER2008;Initial Catalog=GD2C2014;User ID=gd; Password = gd2014");
            try
            {
                cn.Open();//me conecto a la base desde que se quiere 'logear'
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo en la Conexion, intente nuevamente");
            }
        }
        private void guardar_Click(object sender, EventArgs e)
        {
            string pisoHabitacion = piso.Text;
            string  numeroDeHabitacion = numero.Text;
            string ubicación = ubicacion.Text;
            string comodidadesHabitacion = comodidades.Text;
            string tipoDeHabitacion = tipo.Text;

            //hacer la baja logica
        }
        #region no sirve
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void limpiar_Click(object sender, EventArgs e)
        {
            Console.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
     
    }
}
