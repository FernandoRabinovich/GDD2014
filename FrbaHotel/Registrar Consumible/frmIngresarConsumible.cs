﻿using System;
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
    public partial class frmIngresarConsumible : Form
    {
        public frmIngresarConsumible()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            List<Consumible> consumibles = new List<Consumible>();
            foreach(Consumible c in lstConsumibles.Items)
                consumibles.Add(c);

            /* Tengo que validar el numero de habitacion por hotel y con eso obtener el id de habitacion */
            /* No debe poder registrar consumible de una habitación que no se encuentra en una estadía */
            SqlParameter hotel;
            SqlParameter ConsumiblesIngresados;
            SqlParameter numeroHabitacion;
            SqlParameter fecha;
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.RegistrarConsumible";

                hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);

                numeroHabitacion = new SqlParameter("@numeroHabitacion", Int32.Parse(txtHabitacion.Text));
                numeroHabitacion.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(numeroHabitacion);

                DataTable dtConsumibles = new DataTable();
                dtConsumibles.Columns.Add("idConsumible");
                foreach (Consumible c in consumibles)
                {
                    dtConsumibles.Rows.Add(c.Id);
                }

                ConsumiblesIngresados = new SqlParameter("@consumibles", dtConsumibles);
                ConsumiblesIngresados.SqlDbType = SqlDbType.Structured;
                cmd.Parameters.Add(ConsumiblesIngresados);

                fecha = new SqlParameter("@fecha", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                fecha.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fecha);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Los datos se ingresaron correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstConsumibles.Items.Add(((Consumible)cmbConsumible.SelectedItem));
        }

        private void mEliminar_Click(object sender, EventArgs e)
        {
            lstConsumibles.Items.RemoveAt(lstConsumibles.SelectedIndex);
        }

        private void frmIngresarConsumible_Load(object sender, EventArgs e)
        {
            /* Tengo que cargar los consumibles en el combo */
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerConsumibles";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbConsumible.Items.Add(new Consumible(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString(), decimal.Parse(reader["precio"].ToString())));
                }
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

