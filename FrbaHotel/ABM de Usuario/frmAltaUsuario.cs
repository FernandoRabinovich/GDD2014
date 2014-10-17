using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class frmAltaUsuario : Form
    {
        System.Data.SqlClient.SqlConnection conexion;

        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRol.Text = "";
            txtNombreApellido.Text = "";
            cmbTipoDoc.Text = "";
            txtNroDocumento.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtBusquedaFechaNac.Text = "";
            cmbHotel.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new System.Data.SqlClient.SqlConnection();//falta agregar la ruta de conexion
            //conexion.....    aca iria la ruta de conexion
            try
            {
                conexion.Open();//me conecto a la base desde que empieza la aplicacion o se selecionado el Alta de un Cliente
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo en la Conexion, intente nuevamente");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            conexion.Close();//cierro la conexion a la base de datos
            this.Close(); //al cerrar esta pantalla, vuelvo a la pantalla principal

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region variables
            string userName;
            string password;
            string rol;
            string mail;
            string telefono;
            string direccion;
            string nombreApellido;
            string tipoDoc;
            string nroDoc;
            DateTime fechaNac;
            string hotel;
            #endregion

            userName = txtUsername.Text;
            password = txtPassword.Text;
            rol = cmbRol.Text;
            nombreApellido = txtNombreApellido.Text;//Nombre
            mail = txtMail.Text;
            telefono = txtTelefono.Text;
            direccion = txtDireccion.Text;
            tipoDoc = cmbTipoDoc.Text;
            nroDoc = txtNroDocumento.Text;
            fechaNac = Convert.ToDateTime(txtBusquedaFechaNac.Text);
            hotel = cmbHotel.Text;

            //VALIDAR Y GUARDAR EN LA BASE
        }
    }
}
