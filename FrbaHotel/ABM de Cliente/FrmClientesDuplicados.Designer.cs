namespace FrbaHotel
{
    partial class FrmClientesDuplicados
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
            this.grpbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.rdbtnMail = new System.Windows.Forms.RadioButton();
            this.rdbtnDocumento = new System.Windows.Forms.RadioButton();
            this.grdResultado = new System.Windows.Forms.DataGridView();
            this.grpbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxFiltros
            // 
            this.grpbxFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.grpbxFiltros.Controls.Add(this.btnBuscar);
            this.grpbxFiltros.Controls.Add(this.txtNroDocumento);
            this.grpbxFiltros.Controls.Add(this.label6);
            this.grpbxFiltros.Controls.Add(this.cmbTipoDoc);
            this.grpbxFiltros.Controls.Add(this.txtMail);
            this.grpbxFiltros.Controls.Add(this.rdbtnMail);
            this.grpbxFiltros.Controls.Add(this.rdbtnDocumento);
            this.grpbxFiltros.Location = new System.Drawing.Point(12, 12);
            this.grpbxFiltros.Name = "grpbxFiltros";
            this.grpbxFiltros.Size = new System.Drawing.Size(866, 78);
            this.grpbxFiltros.TabIndex = 0;
            this.grpbxFiltros.TabStop = false;
            this.grpbxFiltros.Text = "Filtros";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(703, 42);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltros.TabIndex = 5;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(784, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Enabled = false;
            this.txtNroDocumento.Location = new System.Drawing.Point(258, 18);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(93, 20);
            this.txtNroDocumento.TabIndex = 2;
            this.txtNroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocumento_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tipo y N° doc.:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipoDoc.DisplayMember = "descripcion";
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(191, 18);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(66, 21);
            this.cmbTipoDoc.TabIndex = 1;
            this.cmbTipoDoc.ValueMember = "idTipoDocumento";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(110, 44);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(241, 20);
            this.txtMail.TabIndex = 4;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // rdbtnMail
            // 
            this.rdbtnMail.AutoSize = true;
            this.rdbtnMail.Location = new System.Drawing.Point(6, 45);
            this.rdbtnMail.Name = "rdbtnMail";
            this.rdbtnMail.Size = new System.Drawing.Size(44, 17);
            this.rdbtnMail.TabIndex = 3;
            this.rdbtnMail.Text = "Mail";
            this.rdbtnMail.UseVisualStyleBackColor = true;
            this.rdbtnMail.CheckedChanged += new System.EventHandler(this.rdbtnMail_CheckedChanged);
            // 
            // rdbtnDocumento
            // 
            this.rdbtnDocumento.AutoSize = true;
            this.rdbtnDocumento.Checked = true;
            this.rdbtnDocumento.Location = new System.Drawing.Point(6, 19);
            this.rdbtnDocumento.Name = "rdbtnDocumento";
            this.rdbtnDocumento.Size = new System.Drawing.Size(80, 17);
            this.rdbtnDocumento.TabIndex = 0;
            this.rdbtnDocumento.TabStop = true;
            this.rdbtnDocumento.Text = "Documento";
            this.rdbtnDocumento.UseVisualStyleBackColor = true;
            this.rdbtnDocumento.CheckedChanged += new System.EventHandler(this.rdbtnDocumento_CheckedChanged);
            // 
            // grdResultado
            // 
            this.grdResultado.AllowUserToAddRows = false;
            this.grdResultado.AllowUserToDeleteRows = false;
            this.grdResultado.AllowUserToResizeRows = false;
            this.grdResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultado.Location = new System.Drawing.Point(12, 96);
            this.grdResultado.MultiSelect = false;
            this.grdResultado.Name = "grdResultado";
            this.grdResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultado.Size = new System.Drawing.Size(866, 457);
            this.grdResultado.TabIndex = 7;
            this.grdResultado.DoubleClick += new System.EventHandler(this.grdResultado_DoubleClick);
            // 
            // FrmClientesDuplicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 565);
            this.Controls.Add(this.grdResultado);
            this.Controls.Add(this.grpbxFiltros);
            this.MaximizeBox = false;
            this.Name = "FrmClientesDuplicados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes duplicados";
            this.Load += new System.EventHandler(this.FrmClientesDuplicados_Load);
            this.grpbxFiltros.ResumeLayout(false);
            this.grpbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxFiltros;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.RadioButton rdbtnMail;
        private System.Windows.Forms.RadioButton rdbtnDocumento;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.DataGridView grdResultado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}