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
    public partial class frmAltaHabitacion : Form
    {
        public frmAltaHabitacion()
        {
            InitializeComponent();
        }

        private void VistaAlta_Load(object sender, EventArgs e)
        {
           // Tengo que cargar el combo con los tipos de habitaccion
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoHabitacion";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmbTipoHabitacion.DataSource = table;
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
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposRequeridos())
            {
                // Tengo que cargar el combo con los tipos de habitaccion
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;
                SqlDataReader reader = null;

                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.IngresarHabitacion";

                    SqlParameter numero = new SqlParameter("@nroHabitacion", Int32.Parse(txtNumero.Text));
                    numero.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(numero);
                    SqlParameter hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                    hotel.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(hotel);
                    SqlParameter piso = new SqlParameter("@piso", Int32.Parse(txtPiso.Text));
                    piso.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(piso);
                    SqlParameter frente = new SqlParameter("@frente", chkFrente.Checked ? "S" : "N");
                    frente.SqlDbType = SqlDbType.VarChar;
                    frente.Size = 1;
                    cmd.Parameters.Add(frente);
                    SqlParameter tipoHabitacion = new SqlParameter("@idTipoHabitacion", ((TipoHabitacion)cmbTipoHabitacion.SelectedItem).Id);
                    tipoHabitacion.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(tipoHabitacion);
                    SqlParameter estado = new SqlParameter("@estado", chkEstado.Checked);
                    estado.SqlDbType = SqlDbType.Bit;
                    cmd.Parameters.Add(estado);
                    SqlParameter descripcion = new SqlParameter("@descripcion", txtComodidades.Text);
                    descripcion.SqlDbType = SqlDbType.VarChar;
                    descripcion.Size = 255;
                    cmd.Parameters.Add(descripcion);

                    cmd.ExecuteNonQuery();
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
            }
        }

        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;

            if (txtNumero.Text.Length == 0)
                campo = txtNumero.Tag.ToString();
            if (txtPiso.Text.Length == 0)
                campo = txtPiso.Tag.ToString();
            if (txtComodidades.Text.Length == 0)
                campo = txtComodidades.Tag.ToString();
            if (cmbTipoHabitacion.SelectedItem == null)
                campo = cmbTipoHabitacion.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }     
    }
}
