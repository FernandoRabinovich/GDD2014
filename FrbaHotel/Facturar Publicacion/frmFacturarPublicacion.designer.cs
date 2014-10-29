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
            this.NroDeFactura = new System.Windows.Forms.TextBox();
            this.NroFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NroDeEstadia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NroPasaporte = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreHotel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MedioPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NombreTarjeta = new System.Windows.Forms.TextBox();
            this.NumeroTarjeta = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NroDeFactura
            // 
            this.NroDeFactura.Enabled = false;
            this.NroDeFactura.Location = new System.Drawing.Point(107, 37);
            this.NroDeFactura.Name = "NroDeFactura";
            this.NroDeFactura.Size = new System.Drawing.Size(129, 20);
            this.NroDeFactura.TabIndex = 0;
            this.NroDeFactura.TextChanged += new System.EventHandler(this.NroDeFactura_TextChanged);
            // 
            // NroFactura
            // 
            this.NroFactura.AutoSize = true;
            this.NroFactura.Location = new System.Drawing.Point(12, 44);
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.Size = new System.Drawing.Size(81, 13);
            this.NroFactura.TabIndex = 1;
            this.NroFactura.Text = "Nro. de Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            // 
            // FechaFactura
            // 
            this.FechaFactura.Enabled = false;
            this.FechaFactura.Location = new System.Drawing.Point(445, 37);
            this.FechaFactura.Name = "FechaFactura";
            this.FechaFactura.Size = new System.Drawing.Size(99, 20);
            this.FechaFactura.TabIndex = 3;
            this.FechaFactura.TextChanged += new System.EventHandler(this.FechaFactura_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro. de Estadia";
            // 
            // NroDeEstadia
            // 
            this.NroDeEstadia.Enabled = false;
            this.NroDeEstadia.Location = new System.Drawing.Point(107, 73);
            this.NroDeEstadia.Name = "NroDeEstadia";
            this.NroDeEstadia.Size = new System.Drawing.Size(129, 20);
            this.NroDeEstadia.TabIndex = 5;
            this.NroDeEstadia.TextChanged += new System.EventHandler(this.NroDeEstadia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro Pasaporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre Cliente";
            // 
            // NroPasaporte
            // 
            this.NroPasaporte.Enabled = false;
            this.NroPasaporte.Location = new System.Drawing.Point(445, 73);
            this.NroPasaporte.Name = "NroPasaporte";
            this.NroPasaporte.Size = new System.Drawing.Size(162, 20);
            this.NroPasaporte.TabIndex = 8;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Enabled = false;
            this.NombreCliente.Location = new System.Drawing.Point(445, 111);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(162, 20);
            this.NombreCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre Hotel";
            // 
            // NombreHotel
            // 
            this.NombreHotel.Enabled = false;
            this.NombreHotel.Location = new System.Drawing.Point(107, 111);
            this.NombreHotel.Name = "NombreHotel";
            this.NombreHotel.Size = new System.Drawing.Size(198, 20);
            this.NombreHotel.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(496, 330);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total a Pagar";
            // 
            // MedioPago
            // 
            this.MedioPago.FormattingEnabled = true;
            this.MedioPago.Location = new System.Drawing.Point(115, 329);
            this.MedioPago.Name = "MedioPago";
            this.MedioPago.Size = new System.Drawing.Size(121, 21);
            this.MedioPago.TabIndex = 15;
            this.MedioPago.Leave += new System.EventHandler(this.MedioDePago_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Medio de Pago";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre Tarjeta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número Tarjeta";
            // 
            // NombreTarjeta
            // 
            this.NombreTarjeta.Enabled = false;
            this.NombreTarjeta.Location = new System.Drawing.Point(115, 363);
            this.NombreTarjeta.Name = "NombreTarjeta";
            this.NombreTarjeta.Size = new System.Drawing.Size(121, 20);
            this.NombreTarjeta.TabIndex = 19;
            // 
            // NumeroTarjeta
            // 
            this.NumeroTarjeta.Enabled = false;
            this.NumeroTarjeta.Location = new System.Drawing.Point(115, 399);
            this.NumeroTarjeta.Name = "NumeroTarjeta";
            this.NumeroTarjeta.Size = new System.Drawing.Size(121, 20);
            this.NumeroTarjeta.TabIndex = 20;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(511, 459);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(96, 23);
            this.Guardar.TabIndex = 21;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(31, 459);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 22;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // frmFacturarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 494);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.NumeroTarjeta);
            this.Controls.Add(this.NombreTarjeta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MedioPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NombreHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NombreCliente);
            this.Controls.Add(this.NroPasaporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NroDeEstadia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NroFactura);
            this.Controls.Add(this.NroDeFactura);
            this.Name = "frmFacturarPublicacion";
            this.Text = "Facturar Publicación";
            this.Load += new System.EventHandler(this.frmFacturarPublicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NroDeFactura;
        private System.Windows.Forms.Label NroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NroDeEstadia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NroPasaporte;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreHotel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MedioPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NombreTarjeta;
        private System.Windows.Forms.TextBox NumeroTarjeta;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Limpiar;
    }
}