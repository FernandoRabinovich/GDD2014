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
    public partial class frmCheckIn : Form
    {
        List<Cliente> clientesEstadia = new List<Cliente>();
        List<HabitacionesPorReserva> habitaciones = new List<HabitacionesPorReserva>();
        Reserva reserva;

        public frmCheckIn()
        {
            InitializeComponent();
        }

        public frmCheckIn(Reserva reserva, List<HabitacionesPorReserva> habitaciones)
        {
            InitializeComponent();
            this.reserva = reserva;
            lblReserva.Text = reserva.Codigo.ToString();
            this.habitaciones = habitaciones;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(lblIngresosRestantes.Text) == 0)
            {
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                cn.Open();
                SqlTransaction sqlTran = cn.BeginTransaction();
                cmd = cn.CreateCommand();
                cmd.Transaction = sqlTran;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    cmd.CommandText = "GRAFO_LOCO.IngresarEstadia";

                    SqlParameter reserva = new SqlParameter("@codigoReserva", this.reserva.Codigo);
                    reserva.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(reserva);
                    SqlParameter fDesde = new SqlParameter("@fechaDesde", this.reserva.FechaDesde);
                    fDesde.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fDesde);
                    SqlParameter fCreacion = new SqlParameter("@fechaCreacion", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                    fCreacion.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fCreacion);
                    SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
                    usuario.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(usuario);

                    int idEstadia = (Int32)cmd.ExecuteScalar();

                    /*DE FORMA TRANSACCIONAL DEBERIA INGRESAR A TODOS LOS CLIENTES CARGARDOS EN LA GRILLA CORRESPONDIENTE A LA ESTADIA, SOLO AQUELLOS QUE
                    NO EXISTAN. ADEMAS LOS RELACIONO CON LA ESTADIA DIRECTAMENTE*/
                    int idCliente = 0;
                    foreach(Cliente c in clientesEstadia)
                    {
                        if (c.Id != 0) // Ver que pasa acá cuando es nuevo
                        {
                            cmd.CommandText = "GRAFO_LOCO.IngresarCliente";
                            this.CargarParametrosCliente(ref cmd, c);
                            idCliente = (Int32)cmd.ExecuteScalar();
                        }
                        else idCliente = c.Id;

                        cmd.Parameters.Clear();
                        cmd.CommandText = "GRAFO_LOCO.IngresarClientePorEstadia";
                        SqlParameter cliente = new SqlParameter("@idCliente", idCliente);
                        cliente.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(cliente);
                        SqlParameter estadia = new SqlParameter("@idEstadia", idEstadia);
                        estadia.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(estadia);
                        cmd.ExecuteNonQuery();
                    }
                    
                    sqlTran.Commit();
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
                MessageBox.Show("Falta ingresar clientes.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
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

        private void AltaClienteClosing(object sender, FormClosingEventArgs e)
        {
            if (frmAltaCliente.cliente.Id != 0)
            {
                clientesEstadia.Add(frmAltaCliente.cliente);
                btnRegistrar.Enabled = true;
                grdClientesEstadia.DataSource = clientesEstadia;
            }
        }

        private void mAgregar_Click(object sender, EventArgs e)
        {
            if (grdClientes.SelectedRows[0].Cells["Estado"].Value.ToString().Equals("1"))
            {
                clientesEstadia.Add(new Cliente(Int32.Parse(grdClientes.SelectedRows[0].Cells["id"].Value.ToString()), grdClientes.SelectedRows[0].Cells["Apellido"].Value.ToString(),
                    grdClientes.SelectedRows[0].Cells["Direccion"].Value.ToString(), grdClientes.SelectedRows[0].Cells["Estado"].Value.ToString(),
                    DateTime.Parse(grdClientes.SelectedRows[0].Cells["FechaNacimiento"].Value.ToString()), grdClientes.SelectedRows[0].Cells["Mail"].Value.ToString(),
                    grdClientes.SelectedRows[0].Cells["Nombre"].Value.ToString(), Int32.Parse(grdClientes.SelectedRows[0].Cells["NumeroCalle"].Value.ToString()),
                    Int32.Parse(grdClientes.SelectedRows[0].Cells["NroDocumento"].Value.ToString()), Int32.Parse(grdClientes.SelectedRows[0].Cells["Piso"].Value.ToString()),
                    new TipoDoc(Int32.Parse(grdClientes.SelectedRows[0].Cells["IdTipoDocumento"].Value.ToString()), grdClientes.SelectedRows[0].Cells["TipoDocumento"].Value.ToString()), 
                    grdClientes.SelectedRows[0].Cells["Nacionalidad"].Value.ToString(), grdClientes.SelectedRows[0].Cells["Localidad"].Value.ToString(), 
                    grdClientes.SelectedRows[0].Cells["Departamento"].Value.ToString(), grdClientes.SelectedRows[0].Cells["Telefono"].Value.ToString()));
                grdClientesEstadia.DataSource = clientesEstadia;
            }
            else
                MessageBox.Show("El cliente seleccionado se encuentra inactivo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CargarParametrosCliente(ref SqlCommand cmd, Cliente c)
        {
            cmd.Parameters.Clear();
            SqlParameter nombre = new SqlParameter("@nombre", c.Nonbre);
            nombre.SqlDbType = SqlDbType.VarChar;
            nombre.Size = 30;
            cmd.Parameters.Add(nombre);
            SqlParameter apellido = new SqlParameter("@apellido", c.Apellido);
            apellido.SqlDbType = SqlDbType.VarChar;
            apellido.Size = 30;
            cmd.Parameters.Add(apellido);
            SqlParameter tipoDoc = new SqlParameter("@idTipoDocumento", c.TipoDoc.Id);
            tipoDoc.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(tipoDoc);
            SqlParameter nroDoc = new SqlParameter("@nroDocumento", c.NumeroDoc);
            nroDoc.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(nroDoc);
            SqlParameter mail = new SqlParameter("@mail", c.Mail);
            mail.SqlDbType = SqlDbType.VarChar;
            mail.Size = 30;
            cmd.Parameters.Add(mail);
            SqlParameter telefono = new SqlParameter("@telefono", c.Telefono);
            telefono.SqlDbType = SqlDbType.VarChar;
            telefono.Size = 15;
            cmd.Parameters.Add(telefono);
            SqlParameter direccion = new SqlParameter("@direccion", c.Direccion);
            direccion.SqlDbType = SqlDbType.VarChar;
            direccion.Size = 40;
            cmd.Parameters.Add(direccion);
            SqlParameter fechaNac = new SqlParameter("@fechaNacimiento", c.FechaNacimiento);
            fechaNac.SqlDbType = SqlDbType.DateTime;
            cmd.Parameters.Add(fechaNac);
            SqlParameter numero = new SqlParameter("@nroCalle", c.Numero);
            numero.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(numero);
            SqlParameter piso = new SqlParameter("@piso", c.Piso);
            piso.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(piso);
            SqlParameter nacionalidad = new SqlParameter("@nacionalidad", c.Nacionalidad);
            nacionalidad.SqlDbType = SqlDbType.VarChar;
            nacionalidad.Size = 255;
            cmd.Parameters.Add(nacionalidad);
            SqlParameter localidad = new SqlParameter("@localidad", c.Localidad);
            localidad.SqlDbType = SqlDbType.VarChar;
            localidad.Size = 100;
            cmd.Parameters.Add(localidad);
            SqlParameter dpto = new SqlParameter("@departamento", c.Departamento);
            dpto.SqlDbType = SqlDbType.VarChar;
            dpto.Size = 1;
            cmd.Parameters.Add(dpto);
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
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
                cmd.CommandText = "GRAFO_LOCO.ObtenerTipoDocumento";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                    cmbTipoDoc.Items.Add(new TipoDoc(Int32.Parse(reader["id"].ToString()), reader["descripcion"].ToString()));
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
