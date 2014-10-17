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
    public partial class frmListadoEstadistico : Form
    {
        public frmListadoEstadistico()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime desde, hasta;

            if (this.ValidarAnio())
            {
                if (this.CalcularRangoFechas(cmTrimestre.SelectedIndex, Int32.Parse(txtAño.Text), out desde, out hasta))
                {                    
                    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                    SqlCommand cmd = null;

                    try
                    {
                        cn.Open();
                        cmd = new SqlCommand();
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = this.DeterminarStored(cmbListado.SelectedIndex);

                        SqlParameter fechaDesde = new SqlParameter("@fechaDesde", desde);
                        fechaDesde.SqlDbType = SqlDbType.DateTime;
                        cmd.Parameters.Add(fechaDesde);
                        SqlParameter fechaHasta = new SqlParameter("@fechaHasta", hasta);
                        fechaHasta.SqlDbType = SqlDbType.DateTime;
                        cmd.Parameters.Add(fechaHasta);
                        
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        grdResultado.DataSource = table;
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

        private bool ValidarAnio()
        {
            int anio = Int32.Parse(txtAño.Text);
            bool resultado = true;
            if ((anio < 1900) || (anio > DateTime.Today.Year))
            {
                MessageBox.Show("En año ingresado es inválido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = false;
            }

            return resultado;
        }

        private string DeterminarStored(int listado)
        {
            /*
             * 0: Hoteles con mayor cantidad de reservas canceladas.
             * 1: Hoteles con mayor cantidad de consumibles facturados.
             * 2: Hoteles con mayor cantidad de días fuera de servicio.
             * 3: Habitaciones con mayor cantidad de días y veces que fueron ocupadas.
             * 4: Cliente con mayor cantidad de puntos.
             */
            string stored = string.Empty;
            switch (listado)
            {
                case 0: stored = "GRAFO_LOCO.HoletesMayorCantidadReservasCanceladas"; break;
                case 1: stored = "GRAFO_LOCO.HotelesMayorCantidadConsumiblesFacturados"; break;
                case 2: stored = "GRAFO_LOCO.HotelesMayorCantidadDiasFueraServicio"; break;
                case 3: stored = "GRAFO_LOCO.HabitacionesMayorCantidadDiasVecesOcupadas"; break;
                case 4: stored = "GRAFO_LOCO.ClientesMayorCantidadPuntos"; break;
                default: MessageBox.Show("Debe selccionar un listado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }

            return stored;
        }

        private bool CalcularRangoFechas(int trimestre, int anio, out DateTime desde, out DateTime hasta)
        { 
            /*
             * 0: Enero - Marzo
             * 1: Abril - Junio
             * 2: Julio - Septiembre
             * 3: Octubre - Diciembre
             */
            bool resultado = true;
            desde = DateTime.MinValue;
            hasta = DateTime.MinValue;
            switch (trimestre)
            {
                case 0: desde = DateTime.Parse(anio.ToString() + "/" + "01/01");
                        hasta = DateTime.Parse(anio.ToString() + "/" + "03/31 23:59:59");
                        break;
                case 1:
                        desde = DateTime.Parse(anio.ToString() + "/" + "04/01");
                        hasta = DateTime.Parse(anio.ToString() + "/" + "06/30 23:59:59");
                        break;
                case 2:
                        desde = DateTime.Parse(anio.ToString() + "/" + "07/01");
                        hasta = DateTime.Parse(anio.ToString() + "/" + "09/30 23:59:59");
                        break;
                case 3:
                        desde = DateTime.Parse(anio.ToString() + "/" + "10/01");
                        hasta = DateTime.Parse(anio.ToString() + "/" + "12/31 23:59:59");
                        break;
                default: MessageBox.Show("Debe seleccionar un trimestre.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        resultado = false;
                        break;
            }

            return resultado;
        }
    }
}
