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
    public partial class frmGenerarReserva : Form
    {
        int idCliente = 0;
        Cliente cliente = new Cliente();

        List<HabitacionesPorReserva> habitaciones = new List<HabitacionesPorReserva>();
        List<Int32> habitacionesReservadas = new List<Int32>();

        public frmGenerarReserva()
        {
            InitializeComponent();
            grdHabitaciones.ContextMenuStrip = menuGrid;
            grdClientes.ContextMenuStrip = menuCliente;
        }

        private void GenerarModificarReserva_Load(object sender, EventArgs e)
        {
            btnReservar.Visible = false;
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

        private void botonGuardar_Click(object sender, EventArgs e)
        {                        
            /* Si hay disponibilidad y di de alta al cliente, hacer la reserva e informar el código de la misma. */
            if (habitaciones.Count > 0)
            {
                if (idCliente != 0)
                {
                    if (MessageBox.Show("¿Confirma los datos para realizar la reserva?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                        SqlCommand cmd = null;

                        cn.Open();
                        SqlTransaction sqlTran = cn.BeginTransaction();
                        cmd = cn.CreateCommand();
                        cmd.Transaction = sqlTran;

                        try
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            /* NO DEBERIA PODER CREAR UN CLIENTE SI LUEGO NO GENERO LA RESERVA CORRECTAMENTE. Por esto le puedo pedir los datos para 
                             * dar el alta y hacerlo al momento de reservar*/
                            if (idCliente == 0) // Pregunto si el cliente es nuevo o uno existente
                            {
                                cmd.CommandText = "GRAFO_LOCO.IngresarCliente";

                                this.CargarParametrosCliente(ref cmd);

                                idCliente = (Int32)cmd.ExecuteScalar();
                            }

                            /* Tengo que hacer un insert en Reserva */
                            cmd.Parameters.Clear();
                            cmd.CommandText = "GRAFO_LOCO.GenerarReserva";

                            this.CargarParametrosReserva(ref cmd, idCliente);

                            Int32 idReserva = (Int32)cmd.ExecuteScalar();

                            /* Y uno por cada habitacion en HabitacionesPorReserva */
                            cmd.Parameters.Clear();
                            cmd.CommandText = "GRAFO_LOCO.IngresarHabitacionesPorReserva";

                            SqlParameter reserva = new SqlParameter("@idReserva", idReserva);
                            reserva.SqlDbType = SqlDbType.Int;
                            cmd.Parameters.Add(reserva);

                            foreach (HabitacionesPorReserva h in habitaciones)
                            {
                                SqlParameter habitacion = new SqlParameter("@idHabitacion", h.IdHabitacion);
                                habitacion.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(habitacion);

                                cmd.ExecuteNonQuery();

                                cmd.Parameters.Remove(habitacion);
                            }

                            sqlTran.Commit();

                            MessageBox.Show("La operación se realizó correctamente. El código de reserva es: " + idReserva.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            try
                            {
                                sqlTran.Rollback();
                            }
                            catch (Exception ex2)
                            {
                                MessageBox.Show(ex2.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        finally
                        {
                            cn.Close();
                            if (cmd != null)
                                cmd.Dispose();
                        }
                    }
                    else
                        MessageBox.Show("La operación ha sido cancelada.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Debe ingresar un cliente para efectuar la reserva.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna habitación.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            
            if(idHabitacion != 0)
            {
                habitaciones.Add(new HabitacionesPorReserva(((Hotel)cmbHotel.SelectedItem).Descripcion, ((TipoHabitacion)cmbTipoHabitacion.SelectedItem).Descripcion, ((Regimen)cmbRegimenHotel.SelectedItem).Descripcion, idHabitacion, costo));
                grdHabitaciones.DataSource = habitaciones;
                grdHabitaciones.Refresh();
                lblCostoTotal.Text = (decimal.Parse(lblCostoTotal.Text) + costo).ToString();
            }
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
                cmbHotel.Enabled = frmPrincipal.idUsuario == 3 ? true:false;
                cmbRegimenHotel.Enabled = true;
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
                        btnAltaCliente.Visible = true;
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

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            /* Si hay disponibilidad doy de alta el cliente (si es necesario). */
            frmAltaCliente frmCliente = new frmAltaCliente();
            frmCliente.StartPosition = FormStartPosition.CenterScreen;
            frmCliente.FormClosing += new FormClosingEventHandler(AltaClienteClosing);
            frmCliente.ShowDialog();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerClientes";

                SqlParameter nombre = new SqlParameter("@nombre", txtNombre.Text);
                nombre.SqlDbType = SqlDbType.VarChar;
                nombre.Size = 255;
                cmd.Parameters.Add(nombre);
                SqlParameter apellido = new SqlParameter("@apellido", txtApellido.Text);
                apellido.SqlDbType = SqlDbType.VarChar;
                apellido.Size = 255;
                cmd.Parameters.Add(apellido);
                SqlParameter tipoDocumento = new SqlParameter("@idTipoDocumento", ((TipoDoc)cmbTipoDoc.SelectedItem).Id);
                tipoDocumento.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(tipoDocumento);
                SqlParameter nroDocumento = new SqlParameter("@nroDocumento", Int32.Parse(txtNumeroDoc.Text));
                nroDocumento.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(nroDocumento);
                SqlParameter mail = new SqlParameter("@mail", txtMail.Text);
                mail.SqlDbType = SqlDbType.VarChar;
                mail.Size = 255;
                cmd.Parameters.Add(mail);

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                grdClientes.DataSource = table;

                grdClientes.Columns["id"].Visible = false;
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

        private void mSeleccionar_Click(object sender, EventArgs e)
        {
            idCliente = Int32.Parse(grdClientes.Rows[0].Cells["id"].Value.ToString());
            btnReservar.Visible = true;
            btnAltaCliente.Visible = false;
        }

        private void AltaClienteClosing(object sender, FormClosingEventArgs e)
        {
            if (frmAltaCliente.cliente.Id != 0)
            {
                this.cliente = frmAltaCliente.cliente;
                btnAltaCliente.Enabled = false;
                btnReservar.Enabled = true;
            }
        }

        private void CargarParametrosCliente(ref SqlCommand cmd)
        {
            SqlParameter nombre = new SqlParameter("@nombre", cliente.Nonbre);
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 30;
            cmd.Parameters.Add(nombre);
            SqlParameter apellido = new SqlParameter("@apellido", cliente.Apellido);
            apellido.SqlDbType = SqlDbType.VarChar;
            apellido.Size = 30;
            cmd.Parameters.Add(apellido);
            SqlParameter tipoDoc = new SqlParameter("@idTipoDocumento", cliente.TipoDoc);
            tipoDoc.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(tipoDoc);
            SqlParameter nroDoc = new SqlParameter("@nroDocumento", cliente.NumeroDoc);
            nroDoc.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(nroDoc);
            SqlParameter mail = new SqlParameter("@mail", cliente.Mail);
            mail.SqlDbType = SqlDbType.VarChar;
            mail.Size = 30;
            cmd.Parameters.Add(mail);
            SqlParameter telefono = new SqlParameter("@telefono", cliente.Telefono);
            telefono.SqlDbType = SqlDbType.VarChar;
            telefono.Size = 15;
            cmd.Parameters.Add(telefono);
            SqlParameter direccion = new SqlParameter("@direccion", cliente.Direccion);
            direccion.SqlDbType = SqlDbType.VarChar;
            direccion.Size = 40;
            cmd.Parameters.Add(direccion);
            SqlParameter fechaNac = new SqlParameter("@fechaNacimiento", cliente.FechaNacimiento);
            fechaNac.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(fechaNac);
            SqlParameter numero = new SqlParameter("@nroCalle", cliente.Numero);
            numero.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(numero);
            SqlParameter piso = new SqlParameter("@piso", cliente.Piso);
            piso.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(piso);
            SqlParameter nacionalidad = new SqlParameter("@nacionalidad", cliente.Nacionalidad);
            nacionalidad.SqlDbType = SqlDbType.VarChar;
            nacionalidad.Size = 255;
            cmd.Parameters.Add(nacionalidad);
            SqlParameter localidad = new SqlParameter("@localidad", cliente.Localidad);
            localidad.SqlDbType = SqlDbType.VarChar;
            localidad.Size = 100;
            cmd.Parameters.Add(localidad);
            SqlParameter dpto = new SqlParameter("@departamento", cliente.Departamento);
            dpto.SqlDbType = SqlDbType.VarChar;
            dpto.Size = 1;
            cmd.Parameters.Add(dpto);
        }

        private void CargarParametrosReserva(ref SqlCommand cmd, int idCliente)
        {
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
            SqlParameter cliente = new SqlParameter("@idCliente", idCliente);
            cliente.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(cliente);
            SqlParameter regimen = new SqlParameter("@idRegimen", ((Regimen)cmbRegimenHotel.SelectedItem).Id);
            regimen.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(regimen);
            SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
            usuario.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(usuario);
        }
    }
}
