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
    public partial class frmClientes : Form
    {
        public static int idCliente;

        public frmClientes()
        {
            InitializeComponent();

            grdClientes.ContextMenuStrip = mGrid;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerClientes";

                SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 255;
                cmd.Parameters.Add(nombre);
                SqlParameter apellido = new SqlParameter("@apellido", txtApellido.Text);
                apellido.SqlDbType = SqlDbType.VarChar;
                apellido.Size = 255;
                cmd.Parameters.Add(apellido);
                SqlParameter tipoDocumento = new SqlParameter("@idTipoDocumento", ((TipoDoc)cmbTipoDoc.SelectedItem).Id);
                tipoDocumento.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(tipoDocumento);
                SqlParameter nroDocumento = new SqlParameter("@nroDocumento", Int32.Parse(txtNumeroDoc.Text));
                nroDocumento.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(nroDocumento);
                SqlParameter mail = new SqlParameter("@mail", txtMail.Text);
                mail.SqlDbType = SqlDbType.VarChar;
                mail.Size = 255;
                cmd.Parameters.Add(mail);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                               
                grdClientes.DataSource = table;
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

        private void frmClientes_Load(object sender, EventArgs e)
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

                this.ConfigurarGrilla();
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

        private void ConfigurarGrilla()
        {
            grdClientes.Columns["id"].Visible = false;
        }

        private void mEditar_Click(object sender, EventArgs e)
        {
            frmModifCliente frmModif = new frmModifCliente(Int32.Parse(grdClientes.Rows[0].Cells["id"].Value.ToString()));
            frmModif.StartPosition = FormStartPosition.CenterScreen;
            frmModif.ShowDialog();
        }
    }
}
