namespace FrbaHotel
{
    partial class frmCancelarReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.habitacion = new System.Windows.Forms.GroupBox();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.habitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // habitacion
            // 
            this.habitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.habitacion.Controls.Add(this.txtCodigoReserva);
            this.habitacion.Controls.Add(this.botonGuardar);
            this.habitacion.Controls.Add(this.botonLimpiar);
            this.habitacion.Controls.Add(this.lblNumero);
            this.habitacion.Controls.Add(this.txtMotivo);
            this.habitacion.Controls.Add(this.lblMotivo);
            this.habitacion.Location = new System.Drawing.Point(7, 16);
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(312, 196);
            this.habitacion.TabIndex = 37;
            this.habitacion.TabStop = false;
            this.habitacion.Text = "Reserva";
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Enabled = false;
            this.txtCodigoReserva.Location = new System.Drawing.Point(74, 23);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(116, 20);
            this.txtCodigoReserva.TabIndex = 37;
            this.txtCodigoReserva.Tag = "Número";
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.Location = new System.Drawing.Point(206, 160);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(100, 30);
            this.botonGuardar.TabIndex = 35;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonLimpiar.Location = new System.Drawing.Point(6, 160);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(100, 30);
            this.botonLimpiar.TabIndex = 36;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 26);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 21;
            this.lblNumero.Text = "Número:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(74, 54);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(221, 90);
            this.txtMotivo.TabIndex = 1;
            this.txtMotivo.Tag = "Motivo";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(21, 57);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 3;
            this.lblMotivo.Text = "Motivo:";
            // 
            // frmCancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 221);
            this.Controls.Add(this.habitacion);
            this.MaximizeBox = false;
            this.Name = "frmCancelarReserva";
            this.Text = "Cancerlar Reserva";
            this.Load += new System.EventHandler(this.CancelarReserva_Load);
            this.habitacion.ResumeLayout(false);
            this.habitacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox habitacion;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.TextBox txtCodigoReserva;
    }
}