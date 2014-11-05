namespace FrbaHotel
{
    partial class frmIngresarConsumible
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHabitacion = new System.Windows.Forms.MaskedTextBox();
            this.cmbConsumible = new System.Windows.Forms.ComboBox();
            this.lstConsumibles = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mMenuConsumible = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenuConsumible.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumible:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(215, 262);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número de Habitacion:";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(131, 16);
            this.txtHabitacion.Mask = "999";
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(47, 20);
            this.txtHabitacion.TabIndex = 8;
            // 
            // cmbConsumible
            // 
            this.cmbConsumible.DisplayMember = "descripcion";
            this.cmbConsumible.FormattingEnabled = true;
            this.cmbConsumible.Location = new System.Drawing.Point(79, 56);
            this.cmbConsumible.Name = "cmbConsumible";
            this.cmbConsumible.Size = new System.Drawing.Size(148, 21);
            this.cmbConsumible.TabIndex = 9;
            this.cmbConsumible.ValueMember = "id";
            // 
            // lstConsumibles
            // 
            this.lstConsumibles.DisplayMember = "descripcion";
            this.lstConsumibles.FormattingEnabled = true;
            this.lstConsumibles.Location = new System.Drawing.Point(12, 96);
            this.lstConsumibles.MultiColumn = true;
            this.lstConsumibles.Name = "lstConsumibles";
            this.lstConsumibles.Size = new System.Drawing.Size(278, 160);
            this.lstConsumibles.TabIndex = 10;
            this.lstConsumibles.ValueMember = "id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(233, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(57, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // mMenuConsumible
            // 
            this.mMenuConsumible.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEliminar});
            this.mMenuConsumible.Name = "mMenuConsumible";
            this.mMenuConsumible.Size = new System.Drawing.Size(118, 26);
            // 
            // mEliminar
            // 
            this.mEliminar.Name = "mEliminar";
            this.mEliminar.Size = new System.Drawing.Size(152, 22);
            this.mEliminar.Text = "Eliminar";
            this.mEliminar.Click += new System.EventHandler(this.mEliminar_Click);
            // 
            // frmIngresarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 294);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstConsumibles);
            this.Controls.Add(this.cmbConsumible);
            this.Controls.Add(this.txtHabitacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIngresarConsumible";
            this.Text = "Ingresar Consumible";
            this.Load += new System.EventHandler(this.frmIngresarConsumible_Load);
            this.mMenuConsumible.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtHabitacion;
        private System.Windows.Forms.ComboBox cmbConsumible;
        private System.Windows.Forms.ListBox lstConsumibles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ContextMenuStrip mMenuConsumible;
        private System.Windows.Forms.ToolStripMenuItem mEliminar;

    }
}