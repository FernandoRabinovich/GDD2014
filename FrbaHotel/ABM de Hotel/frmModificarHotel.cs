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
    public partial class frmModificarHotel : Form
    {
        Hotel hotel;
        
        public frmModificarHotel()
        {
            InitializeComponent();
        }

        public frmModificarHotel(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposRequeridos())
            { 
            
            }
        }

        private void frmModificarHotel_Load(object sender, EventArgs e)
        {
            #region CARGAR COMBOS

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRegimen";

                reader =  cmd.ExecuteReader();

                while (reader.Read())
                {
                    chkRegimenes.Items.Add(new Regimen(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString(), decimal.Parse(reader["precio"].ToString())));
                }

                cmd.CommandText = "GRAFO_LOCO.ObtenerCiudades";
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                cmbCiudad.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                reader.Close();
                if (cmd != null)
                    cmd.Dispose();
            }

            #endregion CARGAR COMBOS

            #region CARGAR DATOS

            txtNombre.Text = hotel.Descripcion;
            txtMail.Text = hotel.Mail;
            cantEstrellas.Value = hotel.Estrellas;
            txtTelefono.Text = hotel.Telefono;
            txtDireccion.Text = hotel.Direccion;
            txtNumeroCalle.Text = hotel.NumeroCalle.ToString();
            txtPais.Text = hotel.Pais;
            cmbCiudad.SelectedItem = hotel.Ciudad;


            #endregion CARGAR DATOS
        }


        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;

            if (txtNombre.Text.Length == 0)
                campo = txtNombre.Tag.ToString();
            if (txtMail.Text.Length == 0)
                campo = txtMail.Tag.ToString();
            if (txtTelefono.Text.Length == 0)
                campo = txtTelefono.Tag.ToString();
            if (txtDireccion.Text.Length == 0)
                campo = txtDireccion.Tag.ToString();
            if (txtPais.Text.Length == 0)
                campo = txtPais.Tag.ToString();
            if (cmbCiudad.SelectedItem == null)
                campo = cmbCiudad.Tag.ToString();
            if (chkRegimenes.CheckedItems.Count == 0)
                campo = chkRegimenes.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
