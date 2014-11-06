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
        {
            Ciudad ciudad = new Ciudad(Int32.Parse(grdHoteles.SelectedRows[0].Cells["IdCiudad"].Value.ToString()), grdHoteles.SelectedRows[0].Cells["Ciudad"].Value.ToString());
            List<Regimen> regimenes = new List<Regimen>();

            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRegimenPorHotel";
                SqlParameter IdHotel = new SqlParameter("@idHotel", Int32.Parse(grdHoteles.SelectedRows[0].Cells["id"].Value.ToString()));
                IdHotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(IdHotel);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);

                foreach (DataRow r in table.Rows)
                {
                    regimenes.Add(new Regimen(Int32.Parse(r["id"].ToString()), r["descripcion"].ToString(), decimal.Parse(r["precio"].ToString())));
                }
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

            Hotel hotel = new Hotel(Int32.Parse(grdHoteles.SelectedRows[0].Cells["id"].Value.ToString()), grdHoteles.SelectedRows[0].Cells["descripcion"].Value.ToString(),
                grdHoteles.SelectedRows[0].Cells["Mail"].Value.ToString(), Int32.Parse(grdHoteles.SelectedRows[0].Cells["Estrellas"].Value.ToString()),
                grdHoteles.SelectedRows[0].Cells["Telefono"].Value.ToString(), grdHoteles.SelectedRows[0].Cells["Direccion"].Value.ToString(),
                Int32.Parse(grdHoteles.SelectedRows[0].Cells["Numero"].Value.ToString()), ciudad, grdHoteles.SelectedRows[0].Cells["Pais"].Value.ToString(), regimenes);
            frmModificarHotel frmModifHotel = new frmModificarHotel(hotel);
            frmModifHotel.StartPosition = FormStartPosition.CenterScreen;
            frmModifHotel.ShowDialog();
            
        }

        private void frmHoteles_Load(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerCiudades";
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

                SqlParameter usuario = new SqlParameter("@user", frmPrincipal.idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);
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

                grdHoteles.DataSource = table;
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
