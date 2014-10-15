using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

               private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           string user = "guest";
            if (comboBox1.Text == "Cliente")
                {
                SeleccionHotel form1 = new SeleccionHotel(user);
                form1.Show();
                }
            else
                {
                login form = new login();
                form.Show();
                
                }
            
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PantallaInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
