namespace FrbaHotel.Registrar_Consumible
{
    partial class ListadoDeConsumibles
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
            this.gwListaConsumibles = new System.Windows.Forms.DataGridView();
            this.Facturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gwListaConsumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // gwListaConsumibles
            // 
            this.gwListaConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwListaConsumibles.Location = new System.Drawing.Point(12, 12);
            this.gwListaConsumibles.Name = "gwListaConsumibles";
            this.gwListaConsumibles.Size = new System.Drawing.Size(590, 347);
            this.gwListaConsumibles.TabIndex = 0;
            // 
            // Facturar
            // 
            this.Facturar.Location = new System.Drawing.Point(505, 393);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(97, 23);
            this.Facturar.TabIndex = 1;
            this.Facturar.Text = "Cobrar";
            this.Facturar.UseVisualStyleBackColor = true;
            this.Facturar.Click += new System.EventHandler(this.Facturar_Click);
            // 
            // ListadoDeConsumibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 428);
            this.Controls.Add(this.Facturar);
            this.Controls.Add(this.gwListaConsumibles);
            this.Name = "ListadoDeConsumibles";
            this.Text = "ListadoDeConsumibles";
            this.Load += new System.EventHandler(this.ListadoDeConsumibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gwListaConsumibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gwListaConsumibles;
        private System.Windows.Forms.Button Facturar;

    }
}