﻿using System;
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
    public partial class frmCancelarReserva : Form
    {
        int codigo;

        public frmCancelarReserva()
        {
            InitializeComponent();
        }

        public frmCancelarReserva(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCamposRequeridos())
            {
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"].ToString());
                SqlCommand cmd = null;

                try
                {
                    cn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "GRAFO_LOCO.CancelarReserva";

                    SqlParameter codigo = new SqlParameter("@codigo", Int32.Parse(txtCodigoReserva.Text));
                    codigo.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(codigo);
                    SqlParameter motivo = new SqlParameter("@motivo", txtMotivo.Text);
                    motivo.SqlDbType = SqlDbType.VarChar;
                    motivo.Size = 255;
                    cmd.Parameters.Add(motivo);
                    SqlParameter usuario = new SqlParameter("@idUsuario", frmPrincipal.idUsuario);
                    usuario.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(usuario);
                    SqlParameter fecha = new SqlParameter("@fecha", DateTime.Parse(System.Configuration.ConfigurationSettings.AppSettings["fechaSistema"].ToString()));
                    fecha.SqlDbType = SqlDbType.DateTime;
                    cmd.Parameters.Add(fecha);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("La operación se realizó correctamente.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
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

        private bool ValidarCamposRequeridos()
        {
            string campo = string.Empty;

            if (txtCodigoReserva.Text.Length == 0)
                campo = txtCodigoReserva.Tag.ToString();
            if (txtMotivo.Text.Length == 0)
                campo = txtMotivo.Tag.ToString();

            if (campo.Length > 0)
            {
                MessageBox.Show("El campo " + campo + " es requerido.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CancelarReserva_Load(object sender, EventArgs e)
        {
            txtCodigoReserva.Text = this.codigo.ToString();
        }
    }
}
