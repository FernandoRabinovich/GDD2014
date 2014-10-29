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
    public partial class IngresarConsumible : Form
    {
        Reserva reserva = new Reserva();
        List<HabitacionesPorReserva> habitaciones = new List<HabitacionesPorReserva>();

        public IngresarConsumible()
        {
            InitializeComponent();
        }

        public IngresarConsumible(Reserva reserva, List<HabitacionesPorReserva> habitaciones)
        {
            InitializeComponent();
            this.reserva = reserva;
            this.habitaciones = habitaciones;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlParameter consumible;
             SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.IngresarConsumible";

                consumible = new SqlParameter("@consumible", DescripcionDelConsumible.Text); //consumible pero con el servicio
                consumible.SqlDbType = SqlDbType.VarChar;
                consumible.Size = 255;
                cmd.Parameters.Add(consumible);


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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cmbTipoDeConsumible.Text = "";
            DescripcionDelConsumible.Clear();
        }


    }
}

