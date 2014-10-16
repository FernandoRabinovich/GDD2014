using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Rol
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
            cmbFuncionalidades.Text = "";
            chkEstado.Checked = false;
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
            string nombre;
            string funcionalidades;
            bool estado;
            #endregion

            nombre = txtNombre.Text;//Nombre
            funcionalidades = cmbFuncionalidades.Text;
            estado = chkEstado.Checked;

            //VALIDAR Y GUARDAR EN LA BASE
        }
    }
}
