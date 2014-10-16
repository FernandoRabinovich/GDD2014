namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class GenerarModificarReserva
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
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cmbRegimenHotel = new System.Windows.Forms.ComboBox();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.habitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // habitacion
            // 
            this.habitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.habitacion.Controls.Add(this.cmbHotel);
            this.habitacion.Controls.Add(this.lblHotel);
            this.habitacion.Controls.Add(this.cmbRegimenHotel);
            this.habitacion.Controls.Add(this.cmbTipoHabitacion);
            this.habitacion.Controls.Add(this.fechaHasta);
            this.habitacion.Controls.Add(this.fechaDesde);
            this.habitacion.Controls.Add(this.label7);
            this.habitacion.Controls.Add(this.label1);
            this.habitacion.Controls.Add(this.label2);
            this.habitacion.Controls.Add(this.label3);
            this.habitacion.Location = new System.Drawing.Point(13, 25);
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(312, 184);
            this.habitacion.TabIndex = 31;
            this.habitacion.TabStop = false;
            this.habitacion.Text = "Reserva";
            // 
            // cmbHotel
            // 
            this.cmbHotel.DisplayMember = "descripcion";
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(124, 118);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(177, 21);
            this.cmbHotel.TabIndex = 29;
            this.cmbHotel.ValueMember = "id";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(21, 121);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 28;
            this.lblHotel.Text = "Hotel:";
            // 
            // cmbRegimenHotel
            // 
            this.cmbRegimenHotel.DisplayMember = "descripcion";
            this.cmbRegimenHotel.FormattingEnabled = true;
            this.cmbRegimenHotel.Location = new System.Drawing.Point(124, 146);
            this.cmbRegimenHotel.Name = "cmbRegimenHotel";
            this.cmbRegimenHotel.Size = new System.Drawing.Size(177, 21);
            this.cmbRegimenHotel.TabIndex = 27;
            this.cmbRegimenHotel.ValueMember = "id";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DisplayMember = "descripcion";
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(124, 87);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(177, 21);
            this.cmbTipoHabitacion.TabIndex = 26;
            this.cmbTipoHabitacion.ValueMember = "id";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(101, 56);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 25;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(101, 26);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Habitacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regimen:";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonLimpiar.Location = new System.Drawing.Point(13, 221);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(100, 30);
            this.botonLimpiar.TabIndex = 30;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.Location = new System.Drawing.Point(225, 221);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(100, 30);
            this.botonGuardar.TabIndex = 29;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // GenerarModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 275);
            this.Controls.Add(this.habitacion);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.MaximizeBox = false;
            this.Name = "GenerarModificarReserva";
            this.Text = "Generar Reserva";
            this.Load += new System.EventHandler(this.GenerarModificarReserva_Load);
            this.habitacion.ResumeLayout(false);
            this.habitacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox habitacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cmbRegimenHotel;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.ComboBox cmbHotel;
    }
}