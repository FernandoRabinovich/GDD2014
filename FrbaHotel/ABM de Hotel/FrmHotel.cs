using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class FrmHotel : Form
    {
        System.Data.SqlClient.SqlConnection conexion;

        public FrmHotel()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            cantEstrellas.Value = 0;
            cmbTipoRegimen.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            cmbPais.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtFechaCreacion.Text = "";
        }

        private void FrmHotel_Load(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region variables
            string nombre;
            string estrellas;
            string tipoDeRegimen;
            string ciudad;
            string mail;
            string telefono;
            string calle;
            string pais;
            string fechaCreacion;
            #endregion

            nombre= txtNombre.Text;//Nombre
            estrellas = cantEstrellas.Value.ToString();
            tipoDeRegimen = cmbTipoRegimen.Text;
            ciudad = txtCiudad.Text;
            mail = txtMail.Text;// Mail
            telefono = txtTelefono.Text;//telefono
            calle = txtDireccion.Text; //Calle, direccion
            pais = cmbPais.Text;
            fechaCreacion = txtFechaCreacion.Text;

            //VALIDAR Y GUARDAR EN LA BASE
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            conexion.Close();//cierro la conexion a la base de datos
            this.Close(); //al cerrar esta pantalla, vuelvo a la pantalla principal

        }
    }
}
