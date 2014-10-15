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

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            #region     VARIABLES

            DateTime fechaDesde1;
            DateTime fechaHasta1;
            string tipoHabitacion;
            string regimenDeEstadia;

            #endregion
            var form1 = new cartelRegimen();
            if (regimen.Text == null)
            {
                form1.Show();
                regimenDeEstadia = form1.DameRegimen();//me llevo el regimen elegido del cartel, si no selecciono uno al generar la reserva
            }
            else {
                regimenDeEstadia = this.regimen;
            
            }
           DateTime fecha = System.DateTime();
            fechaDesde1 = (DateTime)fechaDesde;
            fechaHasta1 = (DataTime) fechaHasta;

        }
    }
}
