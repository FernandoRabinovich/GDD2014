using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class frmBajaHotel : Form
    {
        int idHotel;

        public frmBajaHotel()
        {
            InitializeComponent();
        }

        public frmBajaHotel(int idHotel)
        {
            InitializeComponent();
            this.idHotel = idHotel;
        }
    }
}
