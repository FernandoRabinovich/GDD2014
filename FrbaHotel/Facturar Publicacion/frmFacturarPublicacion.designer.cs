namespace FrbaHotel
{
    partial class frmFacturarPublicacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdLineasFactura = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreTarjeta = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblFechaFacturacion = new System.Windows.Forms.Label();
            this.lblEstadia = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.grpTarjeta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdLineasFactura)).BeginInit();
            this.grpTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro. de Estadia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hotel:";
            // 
            // grdLineasFactura
            // 
            this.grdLineasFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLineasFactura.Enabled = false;
            this.grdLineasFactura.Location = new System.Drawing.Point(12, 79);
            this.grdLineasFactura.Name = "grdLineasFactura";
            this.grdLineasFactura.Size = new System.Drawing.Size(595, 150);
            this.grdLineasFactura.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total a Pagar:";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DisplayMember = "descripcion";
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(100, 245);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(121, 21);
            this.cmbMedioPago.TabIndex = 15;
            this.cmbMedioPago.ValueMember = "id";
            this.cmbMedioPago.SelectedIndexChanged += new System.EventHandler(this.cmbMedioPago_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Medio de Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre Tarjeta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número Tarjeta:";
            // 
            // txtNombreTarjeta
            // 
            this.txtNombreTarjeta.Enabled = false;
            this.txtNombreTarjeta.Location = new System.Drawing.Point(87, 23);
            this.txtNombreTarjeta.Name = "txtNombreTarjeta";
            this.txtNombreTarjeta.Size = new System.Drawing.Size(162, 20);
            this.txtNombreTarjeta.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(511, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 43);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Facturar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // lblFechaFacturacion
            // 
            this.lblFechaFacturacion.BackColor = System.Drawing.Color.White;
            this.lblFechaFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFechaFacturacion.Location = new System.Drawing.Point(369, 10);
            this.lblFechaFacturacion.Name = "lblFechaFacturacion";
            this.lblFechaFacturacion.Size = new System.Drawing.Size(162, 20);
            this.lblFechaFacturacion.TabIndex = 23;
            this.lblFechaFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstadia
            // 
            this.lblEstadia.BackColor = System.Drawing.Color.White;
            this.lblEstadia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstadia.Location = new System.Drawing.Point(100, 12);
            this.lblEstadia.Name = "lblEstadia";
            this.lblEstadia.Size = new System.Drawing.Size(79, 20);
            this.lblEstadia.TabIndex = 24;
            this.lblEstadia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHotel
            // 
            this.lblHotel.BackColor = System.Drawing.Color.White;
            this.lblHotel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHotel.Location = new System.Drawing.Point(99, 38);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(162, 20);
            this.lblHotel.TabIndex = 25;
            this.lblHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCliente.Location = new System.Drawing.Point(369, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(162, 20);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(499, 244);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(108, 20);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(87, 63);
            this.txtNumeroTarjeta.Mask = "9999999999999999";
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(162, 20);
            this.txtNumeroTarjeta.TabIndex = 28;
            // 
            // grpTarjeta
            // 
            this.grpTarjeta.Controls.Add(this.txtNombreTarjeta);
            this.grpTarjeta.Controls.Add(this.txtNumeroTarjeta);
            this.grpTarjeta.Controls.Add(this.label8);
            this.grpTarjeta.Controls.Add(this.label9);
            this.grpTarjeta.Location = new System.Drawing.Point(12, 272);
            this.grpTarjeta.Name = "grpTarjeta";
            this.grpTarjeta.Size = new System.Drawing.Size(257, 93);
            this.grpTarjeta.TabIndex = 29;
            this.grpTarjeta.TabStop = false;
            this.grpTarjeta.Text = "Tarjeta";
            // 
            // frmFacturarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 375);
            this.Controls.Add(this.grpTarjeta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.lblEstadia);
            this.Controls.Add(this.lblFechaFacturacion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMedioPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdLineasFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFacturarPublicacion";
            this.Text = "Facturar Publicación";
            this.Load += new System.EventHandler(this.frmFacturarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLineasFactura)).EndInit();
            this.grpTarjeta.ResumeLayout(false);
            this.grpTarjeta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdLineasFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreTarjeta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaFacturacion;
        private System.Windows.Forms.Label lblEstadia;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.MaskedTextBox txtNumeroTarjeta;
        private System.Windows.Forms.GroupBox grpTarjeta;
    }
}