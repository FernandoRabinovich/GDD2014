namespace FrbaHotel
{
    partial class baja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comodidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.TextBox();
            this.piso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ubicacion = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.comodidades);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tipo);
            this.groupBox1.Controls.Add(this.piso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ubicacion);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 187);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comodidades
            // 
            this.comodidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comodidades.Enabled = false;
            this.comodidades.Location = new System.Drawing.Point(87, 149);
            this.comodidades.Name = "comodidades";
            this.comodidades.Size = new System.Drawing.Size(213, 20);
            this.comodidades.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            // 
            // tipo
            // 
            this.tipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tipo.Enabled = false;
            this.tipo.Location = new System.Drawing.Point(87, 119);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(213, 20);
            this.tipo.TabIndex = 21;
            // 
            // piso
            // 
            this.piso.Location = new System.Drawing.Point(87, 63);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(213, 20);
            this.piso.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Habitacion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ubicacion";
            // 
            // numero
            // 
            this.numero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numero.Enabled = false;
            this.numero.Location = new System.Drawing.Point(140, 34);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(160, 20);
            this.numero.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Comodidaes";
            // 
            // ubicacion
            // 
            this.ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ubicacion.Enabled = false;
            this.ubicacion.Location = new System.Drawing.Point(87, 89);
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.Size = new System.Drawing.Size(213, 20);
            this.ubicacion.TabIndex = 14;
            // 
            // limpiar
            // 
            this.limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.limpiar.Location = new System.Drawing.Point(18, 218);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 30);
            this.limpiar.TabIndex = 26;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // guardar
            // 
            this.guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guardar.Location = new System.Drawing.Point(227, 218);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(100, 30);
            this.guardar.TabIndex = 25;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.guardar);
            this.Name = "baja";
            this.Text = "baja";
            this.Load += new System.EventHandler(this.baja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ubicacion;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox comodidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tipo;
        private System.Windows.Forms.TextBox piso;
    }
}