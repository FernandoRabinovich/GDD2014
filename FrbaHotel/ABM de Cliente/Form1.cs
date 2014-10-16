﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class Form1 : Form
    {
        System.Data.SqlClient.SqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbTipoDoc.Text = "";
            txtNroDocumento.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";
            cmbPais.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            txtBusquedaFechaNac.Text = "";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region variables
            string nombreCliente;
            string apellido;
            string tipoDeDocumento;
            string numeroDeDocumento;
            string mail;
            string telefono;
            string calle;
            string localidad;
            string pais;
            string fechaDeNacimiento;
            #endregion

            nombreCliente = txtNombre.Text;//Nombre
            apellido = txtApellido.Text;
            tipoDeDocumento = cmbTipoDoc.Text;//Tipo de Documento
            numeroDeDocumento = txtNroDocumento.Text;//Numero de Documento
            mail = txtMail.Text;// Mail
            telefono = txtTelefono.Text;//telefono
            calle = txtDireccion.Text; //Calle, direccion
            localidad = txtLocalidad.Text;
            pais = cmbPais.Text;
            fechaDeNacimiento = txtBusquedaFechaNac.Text;

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
