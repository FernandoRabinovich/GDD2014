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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void AltaCliente_Load(object sender, EventArgs e)
        {
            // Cargar el combro de tipo dni
        }
                   
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //al cerrar esta pantalla, vuelvo a la pantalla principal
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNumeroCalle.Text = string.Empty;
            txtDpto.Text = string.Empty;
            txtLocalidad.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            fechaNacimiento.Value = DateTime.Now;
            cmbTipoDoc.SelectedIndex = 1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string mail = txtMail.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            int numero = Int32.Parse(txtNumeroCalle.Text);
            string departamento = txtDpto.Text;
            string localidad = txtLocalidad.Text;
            string nacionalidad = txtNacionalidad.Text;
            DateTime fNacicmiento = fechaNacimiento.Value;
            int tipoDni = Int32.Parse(cmbTipoDoc.SelectedValue.ToString());
        }                                  
    }
}
