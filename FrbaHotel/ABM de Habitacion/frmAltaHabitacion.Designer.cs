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
            this.VistaExterior = new System.Windows.Forms.ComboBox();
            this.Comodidades = new System.Windows.Forms.RichTextBox();
            this.TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VistaAlExterior = new System.Windows.Forms.Label();
            this.habitacionNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.habitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.Location = new System.Drawing.Point(425, 333);
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
            this.botonLimpiar.Location = new System.Drawing.Point(12, 333);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(100, 30);
            this.botonLimpiar.TabIndex = 1;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // habitacion
            // 
            this.habitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.habitacion.Controls.Add(this.VistaExterior);
            this.habitacion.Controls.Add(this.Comodidades);
            this.habitacion.Controls.Add(this.TipoHabitacion);
            this.habitacion.Controls.Add(this.label4);
            this.habitacion.Controls.Add(this.piso);
            this.habitacion.Controls.Add(this.label1);
            this.habitacion.Controls.Add(this.label2);
            this.habitacion.Controls.Add(this.VistaAlExterior);
            this.habitacion.Controls.Add(this.habitacionNumero);
            this.habitacion.Controls.Add(this.label5);
            this.habitacion.Location = new System.Drawing.Point(33, 11);
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(421, 294);
            this.habitacion.TabIndex = 28;
            this.habitacion.TabStop = false;
            this.habitacion.Text = "Habitacion";
            // 
            // VistaExterior
            // 
            this.VistaExterior.FormattingEnabled = true;
            this.VistaExterior.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.VistaExterior.Location = new System.Drawing.Point(120, 99);
            this.VistaExterior.Name = "VistaExterior";
            this.VistaExterior.Size = new System.Drawing.Size(78, 21);
            this.VistaExterior.TabIndex = 23;
            // 
            // Comodidades
            // 
            this.Comodidades.Location = new System.Drawing.Point(120, 167);
            this.Comodidades.Name = "Comodidades";
            this.Comodidades.Size = new System.Drawing.Size(268, 69);
            this.Comodidades.TabIndex = 22;
            this.Comodidades.Text = "";
            // 
            // TipoHabitacion
            // 
            this.TipoHabitacion.FormattingEnabled = true;
            this.TipoHabitacion.Location = new System.Drawing.Point(120, 130);
            this.TipoHabitacion.Name = "TipoHabitacion";
            this.TipoHabitacion.Size = new System.Drawing.Size(136, 21);
            this.TipoHabitacion.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(120, 54);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(136, 20);
            this.piso.TabIndex = 1;
            this.piso.Leave += new System.EventHandler(this.Piso_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nro Habitación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piso";
            // 
            // VistaAlExterior
            // 
            this.VistaAlExterior.AutoSize = true;
            this.VistaAlExterior.Location = new System.Drawing.Point(21, 99);
            this.VistaAlExterior.Name = "VistaAlExterior";
            this.VistaAlExterior.Size = new System.Drawing.Size(79, 13);
            this.VistaAlExterior.TabIndex = 4;
            this.VistaAlExterior.Text = "Vista al Exterior";
            // 
            // habitacionNumero
            // 
            this.habitacionNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.habitacionNumero.Location = new System.Drawing.Point(120, 21);
            this.habitacionNumero.Name = "habitacionNumero";
            this.habitacionNumero.Size = new System.Drawing.Size(136, 20);
            this.habitacionNumero.TabIndex = 0;
            this.habitacionNumero.TextChanged += new System.EventHandler(this.habitacionNumero_TextChanged);
            this.habitacionNumero.Leave += new System.EventHandler(this.frmAltaHabitacion_leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comodidades";
            // 
            // frmAltaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 375);
            this.Controls.Add(this.habitacion);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Name = "frmAltaHabitacion";
            this.Text = "VistaAlta";
            this.Load += new System.EventHandler(this.frmAltaHabitacion_Load);
            this.habitacion.ResumeLayout(false);
            this.habitacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.GroupBox habitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VistaAlExterior;
        private System.Windows.Forms.TextBox habitacionNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoHabitacion;
        private System.Windows.Forms.RichTextBox Comodidades;
        private System.Windows.Forms.ComboBox VistaExterior;
    }
}