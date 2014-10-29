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
    public partial class frmRegistrarEstadia : Form
    {
        int idHotel;
        int idRegimen;
        DateTime fechaDesde;
        DateTime fechaHasta;
        List<HabitacionesPorReserva> habitaciones = new List<HabitacionesPorReserva>();
        bool checkIn; 

        public frmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
            int cantidadClientes = 0;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.BuscarReservaPorCodigo";

                SqlParameter codigo = new SqlParameter("@codigoReserva", Int32.Parse(txtReserva.Text));
                codigo.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(codigo);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = cmd;

                adapter.Fill(dataSet);

                if (dataSet.Tables.Count > 0)
                {
                    fechaDesde = DateTime.Parse(dataSet.Tables[0].Rows[0]["FechaDesde"].ToString());
                    fechaHasta = DateTime.Parse(dataSet.Tables[0].Rows[0]["FechaHasta"].ToString());
                    idHotel = Int32.Parse(dataSet.Tables[0].Rows[0]["IdHotel"].ToString());
                    idRegimen = Int32.Parse(dataSet.Tables[0].Rows[0]["IdTipoRegimen"].ToString());
                    checkIn = Int32.Parse(dataSet.Tables[0].Rows[0]["checkIn"].ToString()) == 1 ? true:false;

                    Reserva reserva = new Reserva(Int32.Parse(txtReserva.Text), idHotel, idRegimen,fechaDesde, fechaHasta);

                    foreach (DataRow r in dataSet.Tables[1].Rows)
                    {
                        if(Int32.Parse(r["idTipoHabitacion"].ToString()) == 1001)
                            cantidadClientes += 1;
                        else if(Int32.Parse(r["idTipoHabitacion"].ToString()) == 1002)
                                cantidadClientes += 2;
                        else if(Int32.Parse(r["idTipoHabitacion"].ToString()) == 1003)
                                cantidadClientes += 3;
                        else if(Int32.Parse(r["idTipoHabitacion"].ToString()) == 1004)
                                cantidadClientes += 4;
                        else if(Int32.Parse(r["idTipoHabitacion"].ToString()) == 1005)
                                cantidadClientes += 5;

                        habitaciones.Add(new HabitacionesPorReserva(idHotel, Int32.Parse(r["idTipoHabitacion"].ToString()), idRegimen, Int32.Parse(r["id"].ToString()), decimal.Parse(r["costo"].ToString())));
                    }

                    if (checkIn)
                    {
                        frmCheckIn frmCheckIn = new frmCheckIn(reserva, habitaciones);
                        frmCheckIn.StartPosition = FormStartPosition.CenterScreen;
                        frmCheckIn.Show();
                    }
                    else
                    {
                        IngresarConsumible frmConsumible = new IngresarConsumible(reserva, habitaciones);
                        frmConsumible.StartPosition = FormStartPosition.CenterScreen;
                        frmConsumible.Show();
                    }

                    this.Close();
                }
                else
                    MessageBox.Show("No se encontró la reserva solicitada o la misma ha sido cancelada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
