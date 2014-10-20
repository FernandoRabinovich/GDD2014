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
    public partial class frmModifUsuario : Form
    {
        Usuario usuario;

        public frmModifUsuario()
        {
            InitializeComponent();
        }

        public frmModifUsuario(Usuario user)
        {
            InitializeComponent();

            this.usuario = user;
        }

        private void frmModifUsuario_Load(object sender, EventArgs e)
        {
            //Acá tengo que cargar los datos del usuario para poder modificarlo.
            txtApellido.Text = this.usuario.Apellido;
            txtDireccion.Text = this.usuario.Direccion;
            chkEstado.Checked = this.usuario.Estado.Equals("Activo") ? true:false;
            fechaNacimiento.Value = this.usuario.FechaNacimiento;
            txtMail.Text = this.usuario.Mail; ;
            txtNombre.Text = this.usuario.Nonbre;
            txtNumero.Text = this.usuario.Numero.ToString();
            txtNroDocumento.Text = this.usuario.NumeroDoc.ToString();
            txtPiso.Text = this.usuario.Piso.ToString();
            txtTelefono.Text = this.usuario.Telefono;
            cmbTipoDoc.SelectedValue = this.usuario.TipoDoc;
            txtUsername.Text = this.usuario.UserName;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Actualizar los datos del usuario
        }
    }
}
