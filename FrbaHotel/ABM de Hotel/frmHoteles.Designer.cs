namespace FrbaHotel
{
    partial class frmHoteles
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstrellas = new System.Windows.Forms.MaskedTextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdHoteles = new System.Windows.Forms.DataGridView();
            this.menuHoteles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoteles)).BeginInit();
            this.menuHoteles.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstrellas);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtPais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCiudad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtEstrellas
            // 
            this.txtEstrellas.Location = new System.Drawing.Point(72, 51);
            this.txtEstrellas.Mask = "9";
            this.txtEstrellas.Name = "txtEstrellas";
            this.txtEstrellas.Size = new System.Drawing.Size(80, 20);
            this.txtEstrellas.TabIndex = 9;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(551, 34);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(83, 33);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(334, 53);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(188, 20);
            this.txtPais.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "País:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DisplayMember = "descripcion";
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(334, 26);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(188, 21);
            this.cmbCiudad.TabIndex = 5;
            this.cmbCiudad.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estrellas:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // grdHoteles
            // 
            this.grdHoteles.AllowUserToAddRows = false;
            this.grdHoteles.AllowUserToDeleteRows = false;
            this.grdHoteles.AllowUserToResizeRows = false;
            this.grdHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHoteles.ContextMenuStrip = this.menuHoteles;
            this.grdHoteles.Location = new System.Drawing.Point(12, 105);
            this.grdHoteles.MultiSelect = false;
            this.grdHoteles.Name = "grdHoteles";
            this.grdHoteles.ReadOnly = true;
            this.grdHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHoteles.Size = new System.Drawing.Size(647, 270);
            this.grdHoteles.TabIndex = 1;
            // 
            // menuHoteles
            // 
            this.menuHoteles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditar,
            this.mBaja});
            this.menuHoteles.Name = "menuHoteles";
            this.menuHoteles.Size = new System.Drawing.Size(153, 70);
            // 
            // mEditar
            // 
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(152, 22);
            this.mEditar.Text = "Editar";
            this.mEditar.Click += new System.EventHandler(this.mEditar_Click);
            // 
            // mBaja
            // 
            this.mBaja.Name = "mBaja";
            this.mBaja.Size = new System.Drawing.Size(152, 22);
            this.mBaja.Text = "Baja";
            this.mBaja.Click += new System.EventHandler(this.mBaja_Click);
            // 
            // frmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 388);
            this.Controls.Add(this.grdHoteles);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHoteles";
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.frmHoteles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoteles)).EndInit();
            this.menuHoteles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdHoteles;
        private System.Windows.Forms.ContextMenuStrip menuHoteles;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.MaskedTextBox txtEstrellas;
        private System.Windows.Forms.ToolStripMenuItem mBaja;
    }
}