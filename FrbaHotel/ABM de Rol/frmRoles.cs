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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRoles";

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    lstRoles.Items.Add(new Rol(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString(), Boolean.Parse(reader["estado"].ToString())));
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModifRol frmModifRol = new frmModifRol((Rol)lstRoles.SelectedItem);
            frmModifRol.ShowDialog();
        }
    }
}
