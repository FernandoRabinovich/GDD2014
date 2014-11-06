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
    public partial class FrmClientesDuplicados : Form
    {
        public FrmClientesDuplicados()
        {
            InitializeComponent();
        }

        public void LimpiarFiltros()
        {
            rdbtnDocumento.Checked = true;
            cmbTipoDoc.Text = "";
            txtNroDocumento.Text = "";
            rdbtnDocumento_CheckedChanged(new object(), null);

            rdbtnMail.Checked = false;
            txtMail.Text = "";
        }

        private void FrmClientesDuplicados_Load(object sender, EventArgs e)
        {
            LimpiarFiltros();

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
                /*SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);*/
                while (reader.Read())
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

            CargarGrilla();
        }

        private void CargarGrilla()
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ClientesConInfoDuplicada";

                SqlParameter documentoDuplicado = new SqlParameter("@DocumentoDuplicado", rdbtnDocumento.Checked ? true : false);
                documentoDuplicado.SqlDbType = SqlDbType.Bit;
                cmd.Parameters.Add(documentoDuplicado);

                SqlParameter IdTipoDocumento = new SqlParameter("@IdTipoDocumento", cmbTipoDoc.SelectedValue == null ? -1:((TipoDoc)cmbTipoDoc.SelectedItem).Id);
                IdTipoDocumento.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(IdTipoDocumento);

                SqlParameter NroDocumento = new SqlParameter("@NroDocumento", txtNroDocumento.Text != "" ? Convert.ToInt32(txtNroDocumento.Text) : -1);
                NroDocumento.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(NroDocumento);

                SqlParameter Mail = new SqlParameter("@Mail", txtMail.Text != "" ? txtMail.Text : "");
                Mail.SqlDbType = SqlDbType.Text;
                cmd.Parameters.Add(Mail);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataTable table = new DataTable();
                adapter.Fill(table);

                grdResultado.DataSource = table;

                //Oculto columnas
                grdResultado.Columns["idCliente"].Visible = false;
                grdResultado.Columns["idTipoDocumento"].Visible = false;
                grdResultado.Columns["Localidad"].Visible = false;
                grdResultado.Columns["Direccion"].Visible = false;
                grdResultado.Columns["NumeroCalle"].Visible = false;
                grdResultado.Columns["Departamento"].Visible = false;
                grdResultado.Columns["Piso"].Visible = false;
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

        private void rdbtnDocumento_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoDoc.Enabled = rdbtnDocumento.Checked;
            txtNroDocumento.Enabled = rdbtnDocumento.Checked;
        }

        private void rdbtnMail_CheckedChanged(object sender, EventArgs e)
        {
            txtMail.Enabled = rdbtnMail.Checked;

            if (rdbtnMail.Checked)
            {
                CargarGrilla();
                grdResultado.Sort(grdResultado.Columns["Mail"], ListSortDirection.Ascending);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        private void txtNroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                btnBuscar_Click(sender, null);
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
                btnBuscar_Click(sender, null);
        }

        private void grdResultado_DoubleClick(object sender, EventArgs e)
        {
            if (grdResultado.SelectedRows.Count != 0)
            {
                // Devuelvo el objeto creado con los datos ingresados para el nuevo cliente.
                frmModifCliente frmModifCliente = new frmModifCliente(new Cliente(Int32.Parse(grdResultado.SelectedRows[0].Cells["IdCliente"].Value.ToString()), grdResultado.SelectedRows[0].Cells["Apellido"].Value.ToString(),
                    grdResultado.SelectedRows[0].Cells["Direccion"].Value.ToString(), grdResultado.SelectedRows[0].Cells["Estado"].Value.ToString(),
                    DateTime.Parse(grdResultado.SelectedRows[0].Cells["FechaNacimiento"].Value.ToString()), grdResultado.SelectedRows[0].Cells["Mail"].Value.ToString(),
                    grdResultado.SelectedRows[0].Cells["Nombre"].Value.ToString(), Int32.Parse(grdResultado.SelectedRows[0].Cells["NumeroCalle"].Value.ToString()),
                    Int32.Parse(grdResultado.SelectedRows[0].Cells["NroDocumento"].Value.ToString()), Int32.Parse(grdResultado.SelectedRows[0].Cells["Piso"].Value.ToString()),
                    new TipoDoc(Int32.Parse(grdResultado.SelectedRows[0].Cells["IdTipoDocumento"].Value.ToString()), grdResultado.SelectedRows[0].Cells["TipoDocumento"].Value.ToString()), 
                    grdResultado.SelectedRows[0].Cells["Nacionalidad"].Value.ToString(), grdResultado.SelectedRows[0].Cells["Localidad"].Value.ToString(), 
                    grdResultado.SelectedRows[0].Cells["Departamento"].Value.ToString(), grdResultado.SelectedRows[0].Cells["Telefono"].Value.ToString()));
                frmModifCliente.StartPosition = FormStartPosition.CenterScreen;
                frmModifCliente.ShowDialog();
            }
        }
    }
}
