namespace FrbaHotel
{
    partial class frmCheckIn
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdClientesEstadia = new System.Windows.Forms.DataGridView();
            this.lblIngresosRestantes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.menuClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReserva = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientesEstadia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdClientesEstadia);
            this.groupBox2.Controls.Add(this.lblIngresosRestantes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.grdClientes);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnAltaCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 367);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ciente";
            // 
            // grdClientesEstadia
            // 
            this.grdClientesEstadia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientesEstadia.Location = new System.Drawing.Point(20, 236);
            this.grdClientesEstadia.Name = "grdClientesEstadia";
            this.grdClientesEstadia.Size = new System.Drawing.Size(560, 89);
            this.grdClientesEstadia.TabIndex = 37;
            // 
            // lblIngresosRestantes
            // 
            this.lblIngresosRestantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngresosRestantes.Location = new System.Drawing.Point(142, 328);
            this.lblIngresosRestantes.Name = "lblIngresosRestantes";
            this.lblIngresosRestantes.Size = new System.Drawing.Size(50, 21);
            this.lblIngresosRestantes.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ingresos restantes:";
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(20, 119);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(560, 111);
            this.grdClientes.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNumeroDoc);
            this.groupBox3.Controls.Add(this.cmbTipoDoc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnFiltro);
            this.groupBox3.Location = new System.Drawing.Point(20, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(317, 39);
            this.txtNumeroDoc.Mask = "9999999999";
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(129, 20);
            this.txtNumeroDoc.TabIndex = 11;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(317, 16);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(129, 21);
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
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(480, 329);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(100, 37);
            this.btnAltaCliente.TabIndex = 34;
            this.btnAltaCliente.Text = "Cliente Nuevo";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(500, 407);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(92, 42);
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "Registrar Estadia";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAgregar});
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(117, 26);
            // 
            // mAgregar
            // 
            this.mAgregar.Name = "mAgregar";
            this.mAgregar.Size = new System.Drawing.Size(116, 22);
            this.mAgregar.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Código de Reserva:";
            // 
            // lblReserva
            // 
            this.lblReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserva.Location = new System.Drawing.Point(138, 406);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(75, 18);
            this.lblReserva.TabIndex = 40;
            // 
            // frmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCheckIn";
            this.Text = "Check-In";
            this.Load += new System.EventHandler(this.frmCheckIn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientesEstadia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdClientesEstadia;
        private System.Windows.Forms.Label lblIngresosRestantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ContextMenuStrip menuClientes;
        private System.Windows.Forms.ToolStripMenuItem mAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReserva;

    }
}