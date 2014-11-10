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
    public partial class frmModifCliente : Form
    {
        Cliente cliente = new Cliente();

        public frmModifCliente()
        {
            InitializeComponent();
        }

        public frmModifCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void frmModifCliente_Load(object sender, EventArgs e)
        {
            // Cargar el combo y los datos del cliente
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoDocumento";
                reader = cmd.ExecuteReader();

                while(reader.Read())
                    cmbTipoDoc.Items.Add(new TipoDoc(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
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

            this.CargarCliente();
        }

        private void CargarCliente()
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtNroDocumento.Text = cliente.NumeroDoc.ToString();
            cmbTipoDoc.SelectedItem = cliente.TipoDoc;
            txtMail.Text = cliente.Mail;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            txtNumeroCalle.Text = cliente.Numero.ToString();
            txtPiso.Text = cliente.Piso.ToString();
            txtDpto.Text = cliente.Departamento;
            txtLocalidad.Text = cliente.Localidad;
            txtNacionalidad.Text = cliente.Nacionalidad;
            fechaNacimiento.Value = cliente.FechaNacimiento;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposRequeridos())
            {
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                try
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.ActualizarCliente";

                    SqlParameter idCliente = new SqlParameter("@idCliente", this.cliente.Id);
                    idCliente.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(idCliente);
                    SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                    nombre.SqlDbType = SqlDbType.VarChar;
                    nombre.Size = 30;
                    cmd.Parameters.Add(nombre);
                    SqlParameter apellido = new SqlParameter("@apellido", txtApellido.Text);
                    apellido.SqlDbType = SqlDbType.VarChar;
                    apellido.Size = 30;
                    cmd.Parameters.Add(apellido);
                    SqlParameter tipoDoc = new SqlParameter("@idTipoDocumento", ((TipoDoc)cmbTipoDoc.SelectedItem).Id);
                    tipoDoc.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(tipoDoc);
                    SqlParameter nroDoc = new SqlParameter("@nroDocumento", Int32.Parse(txtNroDocumento.Text));
                    nroDoc.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(nroDoc);
                    SqlParameter mail = new SqlParameter("@mail", txtMail.Text);
                    mail.SqlDbType = SqlDbType.VarChar;
                    mail.Size = 30;
                    cmd.Parameters.Add(mail);
                    SqlParameter telefono = new SqlParameter("@telefono", txtTelefono.Text);
                    telefono.SqlDbType = SqlDbType.VarChar;
                    telefono.Size = 15;
                    cmd.Parameters.Add(telefono);
                    SqlParameter direccion = new SqlParameter("@direccion", txtDireccion.Text);
                    direccion.SqlDbType = SqlDbType.VarChar;
                    direccion.Size = 40;
                    cmd.Parameters.Add(direccion);
                    SqlParameter fechaNac = new SqlParameter("@fechaNacimiento", fechaNacimiento.Value);
                    fechaNac.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fechaNac);
                    SqlParameter numero = new SqlParameter("@nroCalle", Int32.Parse(txtNumeroCalle.Text));
                    numero.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(numero);
                    SqlParameter piso = new SqlParameter("@piso", Int32.Parse(txtPiso.Text));
                    piso.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(piso);
                    SqlParameter nacionalidad = new SqlParameter("@nacionalidad", txtNacionalidad.Text);
                    nacionalidad.SqlDbType = SqlDbType.VarChar;
                    nacionalidad.Size = 255;
                    cmd.Parameters.Add(nacionalidad);
                    SqlParameter localidad = new SqlParameter("@localidad", txtLocalidad.Text);
                    localidad.SqlDbType = SqlDbType.VarChar;
                    localidad.Size = 100;
                    cmd.Parameters.Add(localidad);
                    SqlParameter dpto = new SqlParameter("@departamento", txtDpto.Text);
                    dpto.SqlDbType = SqlDbType.VarChar;
                    dpto.Size = 1;
                    cmd.Parameters.Add(dpto);

                    cmd.ExecuteNonQuery();
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;
            if (txtNombre.Text.Length == 0)
                campo = txtNombre.Tag.ToString();
            if (txtApellido.Text.Length == 0)
                campo = txtApellido.Tag.ToString();
            if (txtNroDocumento.Text.Length == 0)
                campo = txtNroDocumento.Tag.ToString();
            if (cmbTipoDoc.SelectedItem == null)
                campo = cmbTipoDoc.Tag.ToString();
            if (txtMail.Text.Length == 0)
                campo = txtMail.Tag.ToString();
            if (txtTelefono.Text.Length == 0)
                campo = txtTelefono.Tag.ToString();
            if (txtDireccion.Text.Length == 0)
                campo = txtDireccion.Tag.ToString();
            if (txtNumeroCalle.Text.Length == 0)
                campo = txtNumeroCalle.Tag.ToString();
            if (txtPiso.Text.Length == 0)
                campo = txtPiso.Tag.ToString();
            if (txtDpto.Text.Length == 0)
                campo = txtDpto.Tag.ToString();
            if (txtLocalidad.Text.Length == 0)
                campo = txtLocalidad.Tag.ToString();
            if (txtNacionalidad.Text.Length == 0)
                campo = txtNacionalidad.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
