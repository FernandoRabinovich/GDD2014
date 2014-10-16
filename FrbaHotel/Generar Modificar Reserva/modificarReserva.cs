using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class modificarReserva : Form
    {
        public modificarReserva()
        {
            InitializeComponent();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString());
            DateTime fDesde = fechaDesde.Value;
            DateTime fHasta = fechaHasta.Value;
            int tipoHabitacion = Int32.Parse(cmbTipoHabitacion.SelectedValue.ToString());
            int regimenDeEstadia = Int32.Parse(cmbRegimenHotel.SelectedValue.ToString());
            int hotel = Int32.Parse(cmbHotel.SelectedValue.ToString());
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void habitacion_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Aca tengo que buscar la reserva y cargar los datos
        }
    }
}
