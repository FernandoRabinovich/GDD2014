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
    public partial class frmHoteles : Form
    {
        public frmHoteles()
        {
            InitializeComponent();
        }

        private void mEditar_Click(object sender, EventArgs e)
        {   /*
            Hotel holte = new Hotel(Int32.Parse(grdHoteles.SelectedRows[0].Cells["id"].Value.ToString()));
            frmModificarHotel frmModifHotel = new frmModificarHotel();
            frmModifHotel.StartPosition = FormStartPosition.CenterScreen;
            frmModifHotel.ShowDialog();
            */
        }

        private void frmHoteles_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataAdapter adapter = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerCiudades";
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
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
                if (cmd != null)
                    cmd.Dispose();
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataAdapter adapter = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerHotelesPorUsuarioConFiltro";

                SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 50;
                cmd.Parameters.Add(nombre);
                SqlParameter estrellas = new SqlParameter("@estrellas", SqlDbType.Decimal);
                if (string.IsNullOrEmpty(txtEstrellas.Text))
                    estrellas.Value = null;
                else
                    estrellas.Value = decimal.Parse(txtEstrellas.Text);
                cmd.Parameters.Add(estrellas);
                SqlParameter ciudad = new SqlParameter("@ciudad", SqlDbType.Int);
                if (cmbCiudad.SelectedItem == null)
                    ciudad.Value = null;
                else
                    ciudad.Value = ((Ciudad)cmbCiudad.SelectedItem).Id;
                cmd.Parameters.Add(ciudad);
                SqlParameter pais = new SqlParameter("@pais", txtPais.Text);
                pais.SqlDbType = SqlDbType.VarChar;
                pais.Size = 50;
                cmd.Parameters.Add(pais);

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
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
                if (cmd != null)
                    cmd.Dispose();
            }
        }

        private void mBaja_Click(object sender, EventArgs e)
        {
            frmBajaHotel frmBajaHotel = new frmBajaHotel(Int32.Parse(grdHoteles.SelectedRows[0].Cells["id"].Value.ToString()));
            frmBajaHotel.StartPosition = FormStartPosition.CenterScreen;
            frmBajaHotel.ShowDialog();
        }
    }
}
