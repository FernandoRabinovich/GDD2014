namespace FrbaHotel
{
    partial class frmAltaHabitacion
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
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.habitacion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.chkFrente = new System.Windows.Forms.CheckBox();
            this.txtPiso = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtComodidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.habitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.Location = new System.Drawing.Point(222, 256);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(100, 30);
            this.botonGuardar.TabIndex = 0;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonLimpiar.Location = new System.Drawing.Point(12, 256);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(100, 30);
            this.botonLimpiar.TabIndex = 1;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // habitacion
            // 
            this.habitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.habitacion.Controls.Add(this.label6);
            this.habitacion.Controls.Add(this.chkEstado);
            this.habitacion.Controls.Add(this.cmbTipoHabitacion);
            this.habitacion.Controls.Add(this.chkFrente);
            this.habitacion.Controls.Add(this.txtPiso);
            this.habitacion.Controls.Add(this.txtNumero);
            this.habitacion.Controls.Add(this.txtComodidades);
            this.habitacion.Controls.Add(this.label4);
            this.habitacion.Controls.Add(this.label1);
            this.habitacion.Controls.Add(this.label2);
            this.habitacion.Controls.Add(this.label3);
            this.habitacion.Controls.Add(this.label5);
            this.habitacion.Location = new System.Drawing.Point(9, 12);
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(312, 238);
            this.habitacion.TabIndex = 28;
            this.habitacion.TabStop = false;
            this.habitacion.Text = "Habitacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estado:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(88, 139);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 25;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DisplayMember = "descripcion";
            this.cmbTipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(87, 107);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(183, 21);
            this.cmbTipoHabitacion.TabIndex = 24;
            this.cmbTipoHabitacion.Tag = "Tipo";
            this.cmbTipoHabitacion.ValueMember = "id";
            // 
            // chkFrente
            // 
            this.chkFrente.AutoSize = true;
            this.chkFrente.Location = new System.Drawing.Point(88, 85);
            this.chkFrente.Name = "chkFrente";
            this.chkFrente.Size = new System.Drawing.Size(15, 14);
            this.chkFrente.TabIndex = 23;
            this.chkFrente.UseVisualStyleBackColor = true;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(87, 51);
            this.txtPiso.Mask = "999";
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 22;
            this.txtPiso.Tag = "Piso";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(87, 23);
            this.txtNumero.Mask = "99999";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 21;
            this.txtNumero.Tag = "Número";
            // 
            // txtComodidades
            // 
            this.txtComodidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComodidades.Location = new System.Drawing.Point(87, 167);
            this.txtComodidades.Multiline = true;
            this.txtComodidades.Name = "txtComodidades";
            this.txtComodidades.Size = new System.Drawing.Size(213, 55);
            this.txtComodidades.TabIndex = 4;
            this.txtComodidades.Tag = "Comodidades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Frente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comodidaes:";
            // 
            // frmAltaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 298);
            this.Controls.Add(this.habitacion);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmAltaHabitacion";
            this.Text = "Alta Habitacion";
            this.Load += new System.EventHandler(this.VistaAlta_Load);
            this.habitacion.ResumeLayout(false);
            this.habitacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.GroupBox habitacion;
        private System.Windows.Forms.TextBox txtComodidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtPiso;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.CheckBox chkFrente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkEstado;
    }
}