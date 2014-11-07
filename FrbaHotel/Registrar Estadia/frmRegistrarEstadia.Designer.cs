namespace FrbaHotel
{
    partial class frmRegistrarEstadia
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
            this.txtReserva = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Reserva:";
            // 
            // txtReserva
            // 
            this.txtReserva.Location = new System.Drawing.Point(125, 23);
            this.txtReserva.Mask = "9999999";
            this.txtReserva.Name = "txtReserva";
            this.txtReserva.Size = new System.Drawing.Size(100, 20);
            this.txtReserva.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarReserva);
            this.groupBox1.Controls.Add(this.txtReserva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reserva";
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(240, 21);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarReserva.TabIndex = 3;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // frmRegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 87);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistrarEstadia";
            this.Text = "Registrar Estadía";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtReserva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarReserva;
    }
}