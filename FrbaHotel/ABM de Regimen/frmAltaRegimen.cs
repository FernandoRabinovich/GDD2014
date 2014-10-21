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
    public partial class frmAltaRegimen : Form
    {
        public frmAltaRegimen()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.IngresarRegimen";

                SqlParameter descripcion = new SqlParameter("@descripcion", txtDescripcion.Text);
                descripcion.SqlDbType = SqlDbType.VarChar;
                descripcion.Size = 255;
                cmd.Parameters.Add(descripcion);
                SqlParameter precio = new SqlParameter("@precio", decimal.Parse(txtPrecio.Text));
                precio.SqlDbType = SqlDbType.Decimal;
                precio.Precision = 2;
                cmd.Parameters.Add(precio);
           
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
}
