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
    public partial class frmModificarReserva : Form
    {
        List<HabitacionesPorReserva> habitaciones = new List<HabitacionesPorReserva>();

        public frmModificarReserva()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;
             
            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ModificarReserva";

                SqlParameter fDesde = new SqlParameter("@fechaDesde", fechaDesde.Value);
                fDesde.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fDesde);
                SqlParameter fHasta = new SqlParameter("@fechaHasta", fechaHasta.Value);
                fHasta.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fHasta);
                SqlParameter hotel = new SqlParameter("@idHotel", ((Hotel)cmbHotel.SelectedItem).Id);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);
                SqlParameter fechaCreacion = new SqlParameter("@fechaCreacion", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                fechaCreacion.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(fechaCreacion);
                SqlParameter regimen = new SqlParameter("@idRegimen", ((Regimen)cmbRegimenHotel.SelectedItem).Id);
                regimen.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(regimen);
                SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
                usuario.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(usuario);

                cmd.ExecuteNonQuery();
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

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Aca tengo que buscar la reserva y cargar los datos
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.BuscarReservaPorCodigo";

                SqlParameter codigo = new SqlParameter("@codigoReserva", Int32.Parse(txtNumero.Text));
                codigo.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(codigo);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = cmd;

                adapter.Fill(dataSet);
                

                if (dataSet.Tables.Count > 0)
                {
                    fechaDesde.Value = DateTime.Parse(dataSet.Tables[0].Rows[0]["FechaDesde"].ToString());
                    fechaHasta.Value = DateTime.Parse(dataSet.Tables[0].Rows[0]["FechaHasta"].ToString());
                    cmbHotel.SelectedValue = Int32.Parse(dataSet.Tables[0].Rows[0]["IdHotel"].ToString());
                    cmbRegimenHotel.SelectedValue = Int32.Parse(dataSet.Tables[0].Rows[0]["IdTipoRegimen"].ToString());
                    grdHabitaciones.DataSource = dataSet.Tables[1];

                    foreach(DataRow r in dataSet.Tables[1].Rows)
                    {
                        lblCostoTotal.Text = (decimal.Parse(lblCostoTotal.Text) + decimal.Parse(r["costo"].ToString())).ToString();
                        habitaciones.Add(new HabitacionesPorReserva(((Hotel)cmbHotel.SelectedItem).Descripcion,  r["tipoHabitacion"].ToString(), ((Regimen)cmbRegimenHotel.SelectedItem).Descripcion, Int32.Parse(r["idHabitacion"].ToString()), decimal.Parse(r["costo"].ToString())));
                    }
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

        private void frmModificarReserva_Load(object sender, EventArgs e)
        {
            botonGuardar.Visible = false;
            lblCostoTotal.Text = "0";
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            #region Cargar Hoteles

            if (frmPrincipal.idUsuario == 3)
            {
                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.ObtenerHoteles";

                    SqlParameter usuario = new SqlParameter("@user", frmPrincipal.idUsuario);
                    usuario.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(usuario);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);

                    cmbHotel.DataSource = table;
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
            else
            {
                cmbHotel.Items.Add(new Hotel(frmPrincipal.idHotel, frmPrincipal.hotel));
                cmbHotel.Enabled = false;
            }

            #endregion Cargar Hoteles

            #region Cancelar NO SHOW

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ActualizarReservasNoShow";

                cmd.ExecuteNonQuery();
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

            #endregion Cancelar NO SHOW
        }

        private void mEliminar_Click(object sender, EventArgs e)
        {
            decimal costo = Decimal.Parse(grdHabitaciones.Rows[0].Cells["costo"].Value.ToString());
            /* Tengo que permitir eliminar una habitación de la "posible" reserva */
            habitaciones.Remove(new HabitacionesPorReserva(grdHabitaciones.Rows[0].Cells["Hotel"].Value.ToString(),
                grdHabitaciones.Rows[0].Cells["TipoHabitacion"].Value.ToString(), grdHabitaciones.Rows[0].Cells["Regimen"].Value.ToString(),
                Int32.Parse(grdHabitaciones.Rows[0].Cells["idHabitacion"].Value.ToString()), Decimal.Parse(grdHabitaciones.Rows[0].Cells["costo"].Value.ToString())));
            grdHabitaciones.DataSource = habitaciones;
            grdHabitaciones.Refresh();

            lblCostoTotal.Text = (decimal.Parse(lblCostoTotal.Text) + costo).ToString();

            if (habitaciones.Count == 0)
            {
                cmbHotel.Enabled = frmPrincipal.idUsuario == 3 ? true : false;
                cmbRegimenHotel.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /* Tengo que permitir cargar varias habitaciones */
            /* Creo que tengo que setear a mano el nombre de las columnas */
            /* El tipo de habitacion puede cambiar pero el regimen y el hotel no. */
            /* Ahora verifico la disponibilidad de la habitacion que esta queriendo reservar. Si hay, entonces devuelvo un idHabitacion sino,
              informo que no hay disponibilidad. */
            cmbHotel.Enabled = false;
            cmbRegimenHotel.Enabled = false;
            decimal costo;

            int idHabitacion = this.VerificarDisponibilidad(out costo);

            if (idHabitacion != 0)
            {
                habitaciones.Add(new HabitacionesPorReserva(((Hotel)cmbHotel.SelectedItem).Descripcion, ((TipoHabitacion)cmbTipoHabitacion.SelectedItem).Descripcion, ((Regimen)cmbRegimenHotel.SelectedItem).Descripcion, idHabitacion, costo));
                grdHabitaciones.DataSource = habitaciones;
                grdHabitaciones.Refresh();
                lblCostoTotal.Text = (decimal.Parse(lblCostoTotal.Text) + costo).ToString();
            }
        }

        private int VerificarDisponibilidad(out decimal costo)
        {
            int idHabitacion = 0;
            costo = 0;
            /* Validar las fechas ingresadas. Deben ser superiores o iguales a la fecha del sistema */
            DateTime fechaSistema = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString());
            if ((fechaHasta.Value >= fechaSistema) && (fechaHasta.Value >= fechaSistema) && (fechaHasta.Value > fechaDesde.Value))
            {
                /* Verificar disponibilidad. */
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;
                SqlDataReader reader = null;

                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.ObtenerDisponibilidadHabitacion";

                    SqlParameter hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                    hotel.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(hotel);

                    SqlParameter desde = new SqlParameter("@fechaDesde", fechaDesde.Value);
                    desde.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(desde);

                    SqlParameter hasta = new SqlParameter("@fechaHasta", fechaHasta.Value);
                    hasta.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(hasta);

                    SqlParameter tipoHabitacion = new SqlParameter("@idTipoHabitacion", ((TipoHabitacion)cmbTipoHabitacion.SelectedItem).Id);
                    tipoHabitacion.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(tipoHabitacion);

                    // Si no funciona con un list es un DataTable
                    SqlParameter tipoHabitacionesReserva = new SqlParameter("@habitacionesReserva", habitaciones);
                    tipoHabitacionesReserva.SqlDbType = SqlDbType.Structured;
                    cmd.Parameters.Add(tipoHabitacionesReserva);

                    reader = cmd.ExecuteReader();

                    reader.Read();
                    idHabitacion = Int32.Parse(reader["id"].ToString());
                    costo = Decimal.Parse(reader["costo"].ToString());

                    /* Si hay disponibilidad inhabilito la modificacion de la reserva */
                    if (idHabitacion != 0)
                    {
                        fechaDesde.Enabled = false;
                        fechaHasta.Enabled = false;
                        cmbHotel.Enabled = false;
                        cmbTipoHabitacion.Enabled = false;
                        cmbRegimenHotel.Enabled = false;
                        btnAgregar.Enabled = false;
                    }
                    else
                        MessageBox.Show("No hay disponibilidad para la reserva requerida.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            else
                MessageBox.Show("Las fechas ingresadas son incorrectas.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return idHabitacion;
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar el tipo de Habitacion y Regimen (segun Hotel).
            // Cargar los hoteles (según usuario).
            SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
            SqlCommand cmd = null;

            try
            {
                cn.Open();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GRAFO_LOCO.ObtenerRegimenPorHotel";

                SqlParameter hotel = new SqlParameter("@idHotel", frmPrincipal.idHotel);
                hotel.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(hotel);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                cmbRegimenHotel.DataSource = table;

                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoHabitacionPorHotel";
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                cmbTipoHabitacion.DataSource = table;
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
