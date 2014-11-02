using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class IngresarConsumible : Form
    {
        public IngresarConsumible()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            idHabitacion.Clear();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            SqlParameter idConsumibleIngresado;
            SqlParameter idHabitacionIngresada;
            SqlParameter fecha;
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.RegistrarConsumible";

                idHabitacionIngresada = new SqlParameter("@idHabitacion", idHabitacion.Text); 
                idHabitacionIngresada.SqlDbType = SqlDbType.Int;
                idHabitacionIngresada.Size = 255;
                cmd.Parameters.Add(idHabitacionIngresada);

                idConsumibleIngresado = new SqlParameter("@idConsumible", idConsumible.Text); 
                idConsumibleIngresado.SqlDbType = SqlDbType.Int;
                idConsumibleIngresado.Size = 255;
                cmd.Parameters.Add(idConsumibleIngresado);
                fecha = new SqlParameter("@fecha", System.DateTime.Today);
                fecha.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fecha);


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

