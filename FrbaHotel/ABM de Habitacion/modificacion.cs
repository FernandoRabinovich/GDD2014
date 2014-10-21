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
    public partial class frmModifHabitacion : Form
    {
        int idHabitacion = 0;

        public frmModifHabitacion()
        {
            InitializeComponent();
        }

        public frmModifHabitacion(Habitacion habitacion)
        {
            InitializeComponent();

            txtNumero.Text = habitacion.Numero.ToString();
            txtPiso.Text = habitacion.Piso.ToString();
            txtComodidades.Text = habitacion.Descripcion;
            chkEstado.Checked = habitacion.Estado.Equals("Activo") ? true:false;
            chkFrente.Checked = habitacion.Frente.Equals("S") ? true:false;
            this.idHabitacion = habitacion.Id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ActualizarHabitacionPorHotel";

                SqlParameter numero = new SqlParameter("@nroHabitacion", Int32.Parse(txtNumero.Text));
                numero.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(numero);
                SqlParameter habitacion = new SqlParameter("@idHabitacion", this.idHabitacion);
                habitacion.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(habitacion);
                SqlParameter piso = new SqlParameter("@piso", Int32.Parse(txtPiso.Text));
                piso.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(piso);
                SqlParameter frente = new SqlParameter("@frente", chkFrente.Checked ? "S" : "N");
                frente.SqlDbType = SqlDbType.VarChar;
                frente.Size = 1;
                cmd.Parameters.Add(frente);
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
}
