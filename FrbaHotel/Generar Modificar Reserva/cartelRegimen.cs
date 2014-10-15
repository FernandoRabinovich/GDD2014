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
    public partial class cartelRegimen : Form
    {
        public cartelRegimen()
        {
            InitializeComponent();
        }

        internal string DameRegimen()
        {
            return regimen.Text;
        }
    }
}
