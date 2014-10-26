namespace FrbaHotel
{
    partial class frmGenerarReserva
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdHabitaciones = new System.Windows.Forms.DataGridView();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.cmbRegimenHotel = new System.Windows.Forms.ComboBox();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroDoc = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.menuCliente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mSeleccionar = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.habitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHabitaciones)).BeginInit();
            this.menuGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuCliente.SuspendLayout();
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
            this.habitacion.Controls.Add(this.btnReservar);
            this.habitacion.Controls.Add(this.lblHotel);
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
            this.habitacion.Size = new System.Drawing.Size(335, 362);
            this.habitacion.TabIndex = 31;
            this.habitacion.TabStop = false;
            this.habitacion.Text = "Reserva";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(213, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 26);
            this.btnAgregar.TabIndex = 33;
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
            this.grdHabitaciones.Location = new System.Drawing.Point(6, 204);
            this.grdHabitaciones.MultiSelect = false;
            this.grdHabitaciones.Name = "grdHabitaciones";
            this.grdHabitaciones.ReadOnly = true;
            this.grdHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHabitaciones.Size = new System.Drawing.Size(320, 109);
            this.grdHabitaciones.TabIndex = 32;
            // 
            // cmbHotel
            // 
            this.cmbHotel.DisplayMember = "descripcion";
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(124, 85);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(177, 21);
            this.cmbHotel.TabIndex = 29;
            this.cmbHotel.ValueMember = "id";
            this.cmbHotel.SelectedIndexChanged += new System.EventHandler(this.cmbHotel_SelectedIndexChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.Location = new System.Drawing.Point(226, 319);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 37);
            this.btnReservar.TabIndex = 29;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(21, 88);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 28;
            this.lblHotel.Text = "Hotel:";
            // 
            // cmbRegimenHotel
            // 
            this.cmbRegimenHotel.DisplayMember = "descripcion";
            this.cmbRegimenHotel.FormattingEnabled = true;
            this.cmbRegimenHotel.Location = new System.Drawing.Point(124, 141);
            this.cmbRegimenHotel.Name = "cmbRegimenHotel";
            this.cmbRegimenHotel.Size = new System.Drawing.Size(177, 21);
            this.cmbRegimenHotel.TabIndex = 27;
            this.cmbRegimenHotel.ValueMember = "id";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.DisplayMember = "descripcion";
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(124, 112);
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
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Habitacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Regimen:";
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
            this.mEliminar.Size = new System.Drawing.Size(117, 22);
            this.mEliminar.Text = "Eliminar";
            this.mEliminar.Click += new System.EventHandler(this.mEliminar_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(480, 318);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(100, 37);
            this.btnAltaCliente.TabIndex = 34;
            this.btnAltaCliente.Text = "Cliente Nuevo";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdClientes);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAltaCliente);
            this.groupBox1.Location = new System.Drawing.Point(353, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 362);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciente";
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(20, 120);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(560, 193);
            this.grdClientes.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumeroDoc);
            this.groupBox2.Controls.Add(this.cmbTipoDoc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnFiltro);
            this.groupBox2.Location = new System.Drawing.Point(20, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 94);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(317, 39);
            this.txtNumeroDoc.Mask = "9999999999";
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDoc.TabIndex = 11;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(317, 16);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoDoc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo y Nro. Doc.:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(69, 68);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(150, 20);
            this.txtMail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(69, 43);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(479, 65);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 0;
            this.btnFiltro.Text = "Aplicar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSeleccionar});
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(135, 26);
            // 
            // mSeleccionar
            // 
            this.mSeleccionar.Name = "mSeleccionar";
            this.mSeleccionar.Size = new System.Drawing.Size(134, 22);
            this.mSeleccionar.Text = "Seleccionar";
            this.mSeleccionar.Click += new System.EventHandler(this.mSeleccionar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Costo Total:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(91, 182);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(106, 19);
            this.lblCostoTotal.TabIndex = 35;
            this.lblCostoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.habitacion);
            this.MaximizeBox = false;
            this.Name = "frmGenerarReserva";
            this.Text = "Generar Reserva";
            this.Load += new System.EventHandler(this.GenerarModificarReserva_Load);
            this.habitacion.ResumeLayout(false);
            this.habitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHabitaciones)).EndInit();
            this.menuGrid.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox habitacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.ComboBox cmbRegimenHotel;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.DataGridView grdHabitaciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ContextMenuStrip menuGrid;
        private System.Windows.Forms.ToolStripMenuItem mEliminar;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtNumeroDoc;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ContextMenuStrip menuCliente;
        private System.Windows.Forms.ToolStripMenuItem mSeleccionar;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label label9;
    }
}