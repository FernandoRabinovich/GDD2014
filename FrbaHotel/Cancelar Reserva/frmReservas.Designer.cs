namespace FrbaHotel
{
    partial class frmReservas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdReservas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReservas
            // 
            this.grdReservas.AllowUserToAddRows = false;
            this.grdReservas.AllowUserToDeleteRows = false;
            this.grdReservas.AllowUserToOrderColumns = true;
            this.grdReservas.AllowUserToResizeRows = false;
            this.grdReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReservas.Location = new System.Drawing.Point(12, 83);
            this.grdReservas.MultiSelect = false;
            this.grdReservas.Name = "grdReservas";
            this.grdReservas.ReadOnly = true;
            this.grdReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReservas.Size = new System.Drawing.Size(538, 249);
            this.grdReservas.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 38);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar Reserva";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNroDocumento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(141, 44);
            this.txtNroDocumento.Mask = "9999999999";
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNroDocumento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nro. Documento Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 17);
            this.txtCodigo.Mask = "9999999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Reserva:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(450, 44);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 27);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grdReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReservas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.MaskedTextBox txtNroDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}