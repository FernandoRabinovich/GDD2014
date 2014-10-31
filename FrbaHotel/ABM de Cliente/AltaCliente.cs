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
            if (this.ValidarCamposRequeridos())
            {
                // Devuelvo el objeto creado con los datos ingresados para el nuevo cliente o, si el que lo llamo es el formulario principal, hago el ingreso.
                cliente = new Cliente(txtApellido.Text, txtDireccion.Text, fechaNacimiento.Value, txtMail.Text, txtNombre.Text, Int32.Parse(txtNumeroCalle.Text),
                                Int32.Parse(txtNroDocumento.Text), Int32.Parse(txtPiso.Text), ((TipoDoc)cmbTipoDoc.SelectedItem).Descripcion, txtNacionalidad.Text,
                                txtLocalidad.Text, txtDpto.Text);

                if (this.MdiParent.Name.Equals("frmPrincipal"))
                {
                    // Tengo que cargar el combo con los tipos de habitaccion
                    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                    SqlCommand cmd = null;

                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "GRAFO_LOCO.IngresarCliente";

                        this.CargarParametrosCliente(ref cmd, cliente);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Los datos se ingresaron correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                this.Close();
            }
        }

        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;
            if (txtNombre.Text.Length == 0)
                campo = txtNombre.Tag.ToString();
            if(txtApellido.Text.Length == 0)
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

        private void CargarParametrosCliente(ref SqlCommand cmd, Cliente cliente)
        {
            SqlParameter nombre = new SqlParameter("@nombre", cliente.Nonbre);
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 30;
            cmd.Parameters.Add(nombre);
            SqlParameter apellido = new SqlParameter("@apellido", cliente.Apellido);
            apellido.SqlDbType = SqlDbType.VarChar;
            apellido.Size = 30;
            cmd.Parameters.Add(apellido);
            SqlParameter tipoDoc = new SqlParameter("@idTipoDocumento", cliente.TipoDoc);
            tipoDoc.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(tipoDoc);
            SqlParameter nroDoc = new SqlParameter("@nroDocumento", cliente.NumeroDoc);
            nroDoc.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(nroDoc);
            SqlParameter mail = new SqlParameter("@mail", cliente.Mail);
            mail.SqlDbType = SqlDbType.VarChar;
            mail.Size = 30;
            cmd.Parameters.Add(mail);
            SqlParameter telefono = new SqlParameter("@telefono", cliente.Telefono);
            telefono.SqlDbType = SqlDbType.VarChar;
            telefono.Size = 15;
            cmd.Parameters.Add(telefono);
            SqlParameter direccion = new SqlParameter("@direccion", cliente.Direccion);
            direccion.SqlDbType = SqlDbType.VarChar;
            direccion.Size = 40;
            cmd.Parameters.Add(direccion);
            SqlParameter fechaNac = new SqlParameter("@fechaNacimiento", cliente.FechaNacimiento);
            fechaNac.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(fechaNac);
            SqlParameter numero = new SqlParameter("@nroCalle", cliente.Numero);
            numero.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(numero);
            SqlParameter piso = new SqlParameter("@piso", cliente.Piso);
            piso.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(piso);
            SqlParameter nacionalidad = new SqlParameter("@nacionalidad", cliente.Nacionalidad);
            nacionalidad.SqlDbType = SqlDbType.VarChar;
            nacionalidad.Size = 255;
            cmd.Parameters.Add(nacionalidad);
            SqlParameter localidad = new SqlParameter("@localidad", cliente.Localidad);
            localidad.SqlDbType = SqlDbType.VarChar;
            localidad.Size = 100;
            cmd.Parameters.Add(localidad);
            SqlParameter dpto = new SqlParameter("@departamento", cliente.Departamento);
            dpto.SqlDbType = SqlDbType.VarChar;
            dpto.Size = 1;
            cmd.Parameters.Add(dpto);
        }
    }
}
