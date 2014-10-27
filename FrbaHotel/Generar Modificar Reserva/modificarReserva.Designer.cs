namespace FrbaHotel
{
    partial class frmModificarReserva
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
            this.components = new System.ComponentModel.Container();
            this.habitacion = new System.Windows.Forms.GroupBox();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdHabitaciones = new System.Windows.Forms.DataGridView();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.lblHotel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.menuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHabitaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // habitacion
            // 
            this.habitacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.habitacion.Controls.Add(this.lblCostoTotal);
            this.habitacion.Controls.Add(this.label9);
            this.habitacion.Controls.Add(this.btnAgregar);
            this.habitacion.Controls.Add(this.grdHabitaciones);
            this.habitacion.Controls.Add(this.cmbHotel);
            this.habitacion.Controls.Add(this.lblHotel);
            this.habitacion.Controls.Add(this.groupBox1);
            this.habitacion.Controls.Add(this.cmbRegimenHotel);
            this.habitacion.Controls.Add(this.cmbTipoHabitacion);
            this.habitacion.Controls.Add(this.fechaHasta);
            this.habitacion.Controls.Add(this.fechaDesde);
            this.habitacion.Controls.Add(this.label7);
            this.habitacion.Controls.Add(this.label1);
            this.habitacion.Controls.Add(this.label2);
            this.habitacion.Controls.Add(this.label3);
            this.habitacion.Location = new System.Drawing.Point(12, 12);
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(338, 406);
            this.habitacion.TabIndex = 34;
            this.habitacion.TabStop = false;
            this.habitacion.Text = "Reserva";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(94, 269);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(106, 19);
            this.lblCostoTotal.TabIndex = 39;
            this.lblCostoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Costo Total:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(216, 262);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 26);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.Text = "Agregar Habitación";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grdHabitaciones
            // 
            this.grdHabitaciones.AllowUserToAddRows = false;
            this.grdHabitaciones.AllowUserToDeleteRows = false;
            this.grdHabitaciones.AllowUserToResizeRows = false;
            this.grdHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHabitaciones.ContextMenuStrip = this.menuGrid;
            this.grdHabitaciones.Location = new System.Drawing.Point(9, 291);
            this.grdHabitaciones.MultiSelect = false;
            this.grdHabitaciones.Name = "grdHabitaciones";
            this.grdHabitaciones.ReadOnly = true;
            this.grdHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHabitaciones.Size = new System.Drawing.Size(320, 109);
            this.grdHabitaciones.TabIndex = 36;
            // 
            // cmbHotel
            // 
            this.cmbHotel.DisplayMember = "descripcion";
            this.cmbHotel.Enabled = false;
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(87, 154);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(207, 21);
            this.cmbHotel.TabIndex = 35;
            this.cmbHotel.ValueMember = "id";
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Enabled = false;
            this.lblHotel.Location = new System.Drawing.Point(24, 157);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 34;
            this.lblHotel.Text = "Hotel:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 57);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(182, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 25);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(76, 22);
            this.txtNumero.Mask = "999999";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Número:";
            // 
            // cmbRegimenHotel
            // 
            this.cmbRegimenHotel.DisplayMember = "descripcion";
            this.cmbRegimenHotel.Enabled = false;
            this.cmbRegimenHotel.FormattingEnabled = true;
            this.cmbRegimenHotel.Location = new System.Drawing.Point(117, 220);
            this.cmbRegimenHotel.Name = "cmbRegimenHotel";
            this.cmbRegimenHotel.Size = new System.Drawing.Size(177, 21);
            this.cmbRegimenHotel.TabIndex = 27;
            this.cmbRegimenHotel.ValueMember = "id";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DisplayMember = "descripcion";
            this.cmbTipoHabitacion.Enabled = false;
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(117, 186);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(177, 21);
            this.cmbTipoHabitacion.TabIndex = 26;
            this.cmbTipoHabitacion.ValueMember = "id";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Enabled = false;
            this.fechaHasta.Location = new System.Drawing.Point(94, 122);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 25;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Enabled = false;
            this.fechaDesde.Location = new System.Drawing.Point(94, 90);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(14, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Habitacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(14, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regimen:";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonLimpiar.Location = new System.Drawing.Point(12, 424);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(100, 30);
            this.botonLimpiar.TabIndex = 33;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonGuardar.Enabled = false;
            this.botonGuardar.Location = new System.Drawing.Point(250, 424);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(100, 30);
            this.botonGuardar.TabIndex = 32;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // menuGrid
            // 
            this.menuGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEliminar});
            this.menuGrid.Name = "menuGrid";
            this.menuGrid.Size = new System.Drawing.Size(118, 26);
            // 
            // mEliminar
            // 
            this.mEliminar.Name = "mEliminar";
            this.mEliminar.Size = new System.Drawing.Size(152, 22);
            this.mEliminar.Text = "Eliminar";
            this.mEliminar.Click += new System.EventHandler(this.mEliminar_Click);
            // 
            // frmModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 466);
            this.Controls.Add(this.habitacion);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonGuardar);
            this.Name = "frmModificarReserva";
            this.Text = "Modificar Reserva";
            this.Load += new System.EventHandler(this.frmModificarReserva_Load);
            this.habitacion.ResumeLayout(false);
            this.habitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHabitaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox habitacion;
        private System.Windows.Forms.ComboBox cmbRegimenHotel;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grdHabitaciones;
        private System.Windows.Forms.ContextMenuStrip menuGrid;
        private System.Windows.Forms.ToolStripMenuItem mEliminar;


    }
}