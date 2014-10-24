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
    public partial class frmModifCliente : Form
    {
        int idCliente;

        public frmModifCliente()
        {
            InitializeComponent();
        }

        public frmModifCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private void frmModifCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
