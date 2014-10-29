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

namespace FrbaHotel
{
    public partial class frmAltaCliente : Form
    {
        public static Cliente cliente;
        public frmAltaCliente()
        {
            InitializeComponent();
        }
       
        private void AltaCliente_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoDocumento";
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                cmbTipoDoc.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
                if (cmd != null)
                    cmd.Dispose();
            }
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
            // Devuelvo el objeto creado con los datos ingresados para el nuevo cliente.
            cliente = new Cliente(txtApellido.Text, txtDireccion.Text, fechaNacimiento.Value, txtMail.Text, txtNombre.Text, Int32.Parse(txtNumeroCalle.Text), Int32.Parse(txtNroDocumento.Text), Int32.Parse(txtPiso.Text), ((TipoDoc)cmbTipoDoc.SelectedItem).Descripcion, 
                txtNacionalidad.Text, txtLocalidad.Text, txtDpto.Text);

            this.Close();
        }                                  
    }
}
