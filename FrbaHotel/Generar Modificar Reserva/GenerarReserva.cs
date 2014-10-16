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
    public partial class GenerarModificarReserva : Form
    {
        public GenerarModificarReserva()
        {
            InitializeComponent();
        }

        private void GenerarModificarReserva_Load(object sender, EventArgs e)
        {
            // Cargar el tipo de Habitacion
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            #region     VARIABLES

            DateTime fDesde;
            DateTime fHasta;
            int tipoHabitacion;
            int regimenDeEstadia;
            int hotel;

            #endregion

            DateTime fecha = DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString());
            fDesde = fechaDesde.Value;
            fHasta = fechaHasta.Value;
            tipoHabitacion = Int32.Parse(cmbTipoHabitacion.SelectedValue.ToString());
            regimenDeEstadia = Int32.Parse(cmbRegimenHotel.SelectedValue.ToString());
            hotel = Int32.Parse(cmbHotel.SelectedValue.ToString());
        }
    }
}
