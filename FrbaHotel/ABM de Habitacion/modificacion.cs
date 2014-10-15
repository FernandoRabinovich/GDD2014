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
    public partial class modificacion : Form
    {
        public modificacion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
