namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class cartelRegimen
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
            this.aceptar = new System.Windows.Forms.Button();
            this.regimen = new System.Windows.Forms.ComboBox();
            this.TipoDeRegimen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar.Location = new System.Drawing.Point(304, 68);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // regimen
            // 
            this.regimen.FormattingEnabled = true;
            this.regimen.Items.AddRange(new object[] {
            "Seleccione uno"});
            this.regimen.Location = new System.Drawing.Point(106, 21);
            this.regimen.Name = "regimen";
            this.regimen.Size = new System.Drawing.Size(273, 21);
            this.regimen.TabIndex = 1;
            // 
            // TipoDeRegimen
            // 
            this.TipoDeRegimen.AutoSize = true;
            this.TipoDeRegimen.Location = new System.Drawing.Point(12, 21);
            this.TipoDeRegimen.Name = "TipoDeRegimen";
            this.TipoDeRegimen.Size = new System.Drawing.Size(88, 13);
            this.TipoDeRegimen.TabIndex = 2;
            this.TipoDeRegimen.Text = "Tipo de Regimen";
            // 
            // cartelRegimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 103);
            this.Controls.Add(this.TipoDeRegimen);
            this.Controls.Add(this.regimen);
            this.Controls.Add(this.aceptar);
            this.Name = "cartelRegimen";
            this.Text = "Regimen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.ComboBox regimen;
        private System.Windows.Forms.Label TipoDeRegimen;
    }
}