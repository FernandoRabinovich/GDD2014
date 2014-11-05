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
    public partial class FrmHotel : Form
    {
        public FrmHotel()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            cantEstrellas.Value = 0;
            txtDireccion.Text = ""; 
            txtTelefono.Text = "";
            txtMail.Text = "";
        }

        private void FrmHotel_Load(object sender, EventArgs e)
        {
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
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    chkRegimenes.Items.Add(new Regimen(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString(), decimal.Parse(reader["precio"].ToString())));

                cmd.CommandText = "GRAFO_LOCO.ObtenerCiudades";
                reader.Close();
                reader = cmd.ExecuteReader();

                while(reader.Read())
                    cmbCiudad.Items.Add(new Ciudad(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposRequeridos())
            {
                /* De forma tarnsaccional tengo que guardar el nuevo hotel y asignárselo al usuario logueado. */
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                cn.Open();
                SqlTransaction sqlTran = cn.BeginTransaction();
                cmd = cn.CreateCommand();
                cmd.Transaction = sqlTran;

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.IngresarHotel";

                    SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                    nombre.SqlDbType = SqlDbType.VarChar;
                    nombre.Size = 50;
                    cmd.Parameters.Add(nombre);
                    SqlParameter mail = new SqlParameter("@mail", txtMail.Text);
                    mail.SqlDbType = SqlDbType.VarChar;
                    mail.Size = 50;
                    cmd.Parameters.Add(mail);
                    SqlParameter estrellas = new SqlParameter("@estrellas", cantEstrellas.Value);
                    estrellas.SqlDbType = SqlDbType.Decimal;
                    cmd.Parameters.Add(estrellas);
                    SqlParameter telefono = new SqlParameter("@telefono", txtTelefono.Text);
                    telefono.SqlDbType = SqlDbType.VarChar;
                    telefono.Size = 15;
                    cmd.Parameters.Add(telefono);
                    SqlParameter direccion = new SqlParameter("@direccion", txtDireccion.Text);
                    direccion.SqlDbType = SqlDbType.VarChar;
                    direccion.Size = 255;
                    cmd.Parameters.Add(direccion);
                    SqlParameter ciudad = new SqlParameter("@ciudad", ((Ciudad)cmbCiudad.SelectedItem).Id);
                    ciudad.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(ciudad);
                    SqlParameter pais = new SqlParameter("@pais", txtPais.Text);
                    pais.SqlDbType = SqlDbType.VarChar;
                    pais.Size = 50;
                    cmd.Parameters.Add(pais);
                    SqlParameter numeroCalle = new SqlParameter("@numeroCalle", Int32.Parse(txtNumeroCalle.Text));
                    numeroCalle.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(numeroCalle);
                    SqlParameter fechaCreacion = new SqlParameter("@fechaCreacion", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                    fechaCreacion.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fechaCreacion);

                    int idHotel = (Int32)cmd.ExecuteScalar();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "GRAFO_LOCO.IngresarRegimenPorHotel";
                    SqlParameter hotel = new SqlParameter("@idHotel", idHotel);
                    hotel.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(hotel);
                    foreach (Regimen r in chkRegimenes.CheckedItems)
                    {
                        SqlParameter regimen = new SqlParameter("@idRegimen", r.Id);
                        regimen.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(regimen);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("@regimen");
                    }

                    cmd.Parameters.Clear();
                    cmd.CommandText = "GRAFO_LOCO.IngresarHotelesPorUsuario";
                    SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
                    usuario.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(usuario);
                    cmd.Parameters.Add(hotel);

                    cmd.ExecuteNonQuery();

                    sqlTran.Commit();

                    MessageBox.Show("La operación se realizó correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    try
                    {
                        sqlTran.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    cn.Close();
                    if (cmd != null)
                        cmd.Dispose();
                }
            }
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
            if (chkRegimenes.Items.Count == 0)
                campo = chkRegimenes.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
