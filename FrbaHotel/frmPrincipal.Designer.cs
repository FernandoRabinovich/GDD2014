namespace FrbaHotel
{
    partial class frmPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mABM = new System.Windows.Forms.ToolStripMenuItem();
            this.mCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mHabitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mAltaHabitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mModifHabitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mRol = new System.Windows.Forms.ToolStripMenuItem();
            this.mAltaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.mBajaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.mUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mAltaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mBajaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mRegimen = new System.Windows.Forms.ToolStripMenuItem();
            this.mAltaRegimen = new System.Windows.Forms.ToolStripMenuItem();
            this.mHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mAltaHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mBajaHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mGenerarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mCancelarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mModifReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mEstadia = new System.Windows.Forms.ToolStripMenuItem();
            this.mRegistrarEstadia = new System.Windows.Forms.ToolStripMenuItem();
            this.mRegistrarConsumible = new System.Windows.Forms.ToolStripMenuItem();
            this.mFacturar = new System.Windows.Forms.ToolStripMenuItem();
            this.mReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mEstadistico = new System.Windows.Forms.ToolStripMenuItem();
            this.mClientesErroneos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mABM,
            this.mReserva,
            this.mEstadia,
            this.mReportes});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mABM
            // 
            this.mABM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCliente,
            this.mHabitacion,
            this.mRol,
            this.mUsuario,
            this.mRegimen,
            this.mHotel});
            this.mABM.Name = "mABM";
            this.mABM.Size = new System.Drawing.Size(45, 20);
            this.mABM.Text = "&ABM";
            this.mABM.Visible = false;
            // 
            // mCliente
            // 
            this.mCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAltaCliente,
            this.mBajaCliente});
            this.mCliente.Name = "mCliente";
            this.mCliente.Size = new System.Drawing.Size(152, 22);
            this.mCliente.Tag = "3";
            this.mCliente.Text = "Cliente";
            this.mCliente.Visible = false;
            // 
            // mAltaCliente
            // 
            this.mAltaCliente.Name = "mAltaCliente";
            this.mAltaCliente.Size = new System.Drawing.Size(171, 22);
            this.mAltaCliente.Text = "Alta";
            // 
            // mBajaCliente
            // 
            this.mBajaCliente.Name = "mBajaCliente";
            this.mBajaCliente.Size = new System.Drawing.Size(171, 22);
            this.mBajaCliente.Text = "Baja/Modificación";
            // 
            // mHabitacion
            // 
            this.mHabitacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAltaHabitacion,
            this.mModifHabitacion});
            this.mHabitacion.Name = "mHabitacion";
            this.mHabitacion.Size = new System.Drawing.Size(152, 22);
            this.mHabitacion.Tag = "5";
            this.mHabitacion.Text = "Habitación";
            this.mHabitacion.Visible = false;
            // 
            // mAltaHabitacion
            // 
            this.mAltaHabitacion.Name = "mAltaHabitacion";
            this.mAltaHabitacion.Size = new System.Drawing.Size(171, 22);
            this.mAltaHabitacion.Text = "Alta";
            // 
            // mModifHabitacion
            // 
            this.mModifHabitacion.Name = "mModifHabitacion";
            this.mModifHabitacion.Size = new System.Drawing.Size(171, 22);
            this.mModifHabitacion.Text = "Baja/Modificación";
            // 
            // mRol
            // 
            this.mRol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAltaRol,
            this.mBajaRol});
            this.mRol.Name = "mRol";
            this.mRol.Size = new System.Drawing.Size(152, 22);
            this.mRol.Tag = "1";
            this.mRol.Text = "Rol";
            this.mRol.Visible = false;
            // 
            // mAltaRol
            // 
            this.mAltaRol.Name = "mAltaRol";
            this.mAltaRol.Size = new System.Drawing.Size(171, 22);
            this.mAltaRol.Text = "Alta";
            this.mAltaRol.Click += new System.EventHandler(this.mAltaRol_Click);
            // 
            // mBajaRol
            // 
            this.mBajaRol.Name = "mBajaRol";
            this.mBajaRol.Size = new System.Drawing.Size(171, 22);
            this.mBajaRol.Text = "Baja/Modificación";
            this.mBajaRol.Click += new System.EventHandler(this.mBajaRol_Click);
            // 
            // mUsuario
            // 
            this.mUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAltaUsuario,
            this.mBajaUsuario});
            this.mUsuario.Name = "mUsuario";
            this.mUsuario.Size = new System.Drawing.Size(152, 22);
            this.mUsuario.Tag = "2";
            this.mUsuario.Text = "Usuario";
            this.mUsuario.Visible = false;
            // 
            // mAltaUsuario
            // 
            this.mAltaUsuario.Name = "mAltaUsuario";
            this.mAltaUsuario.Size = new System.Drawing.Size(171, 22);
            this.mAltaUsuario.Text = "Alta";
            this.mAltaUsuario.Click += new System.EventHandler(this.mAltaUsuario_Click);
            // 
            // mBajaUsuario
            // 
            this.mBajaUsuario.Name = "mBajaUsuario";
            this.mBajaUsuario.Size = new System.Drawing.Size(171, 22);
            this.mBajaUsuario.Text = "Baja/Modificación";
            this.mBajaUsuario.Click += new System.EventHandler(this.mBajaUsuario_Click);
            // 
            // mRegimen
            // 
            this.mRegimen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAltaRegimen});
            this.mRegimen.Name = "mRegimen";
            this.mRegimen.Size = new System.Drawing.Size(152, 22);
            this.mRegimen.Tag = "6";
            this.mRegimen.Text = "Regimen";
            this.mRegimen.Visible = false;
            // 
            // mAltaRegimen
            // 
            this.mAltaRegimen.Name = "mAltaRegimen";
            this.mAltaRegimen.Size = new System.Drawing.Size(95, 22);
            this.mAltaRegimen.Text = "Alta";
            // 
            // mHotel
            // 
            this.mHotel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAltaHotel,
            this.mBajaHotel});
            this.mHotel.Name = "mHotel";
            this.mHotel.Size = new System.Drawing.Size(152, 22);
            this.mHotel.Tag = "4";
            this.mHotel.Text = "Hotel";
            this.mHotel.Visible = false;
            // 
            // mAltaHotel
            // 
            this.mAltaHotel.Name = "mAltaHotel";
            this.mAltaHotel.Size = new System.Drawing.Size(171, 22);
            this.mAltaHotel.Text = "Alta";
            this.mAltaHotel.Visible = false;
            // 
            // mBajaHotel
            // 
            this.mBajaHotel.Name = "mBajaHotel";
            this.mBajaHotel.Size = new System.Drawing.Size(171, 22);
            this.mBajaHotel.Text = "Baja/Modificación";
            this.mBajaHotel.Visible = false;
            // 
            // mReserva
            // 
            this.mReserva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mGenerarReserva,
            this.mCancelarReserva,
            this.mModifReserva});
            this.mReserva.Name = "mReserva";
            this.mReserva.Size = new System.Drawing.Size(59, 20);
            this.mReserva.Text = "&Reserva";
            this.mReserva.Visible = false;
            // 
            // mGenerarReserva
            // 
            this.mGenerarReserva.Name = "mGenerarReserva";
            this.mGenerarReserva.Size = new System.Drawing.Size(125, 22);
            this.mGenerarReserva.Tag = "7";
            this.mGenerarReserva.Text = "Generar";
            this.mGenerarReserva.Visible = false;
            // 
            // mCancelarReserva
            // 
            this.mCancelarReserva.Name = "mCancelarReserva";
            this.mCancelarReserva.Size = new System.Drawing.Size(125, 22);
            this.mCancelarReserva.Tag = "8";
            this.mCancelarReserva.Text = "Cancelar";
            this.mCancelarReserva.Visible = false;
            // 
            // mModifReserva
            // 
            this.mModifReserva.Name = "mModifReserva";
            this.mModifReserva.Size = new System.Drawing.Size(125, 22);
            this.mModifReserva.Tag = "7";
            this.mModifReserva.Text = "Modificar";
            this.mModifReserva.Visible = false;
            // 
            // mEstadia
            // 
            this.mEstadia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRegistrarEstadia,
            this.mRegistrarConsumible,
            this.mFacturar});
            this.mEstadia.Name = "mEstadia";
            this.mEstadia.Size = new System.Drawing.Size(56, 20);
            this.mEstadia.Text = "&Estadía";
            this.mEstadia.Visible = false;
            // 
            // mRegistrarEstadia
            // 
            this.mRegistrarEstadia.Name = "mRegistrarEstadia";
            this.mRegistrarEstadia.Size = new System.Drawing.Size(138, 22);
            this.mRegistrarEstadia.Tag = "9";
            this.mRegistrarEstadia.Text = "Registrar";
            this.mRegistrarEstadia.Visible = false;
            // 
            // mRegistrarConsumible
            // 
            this.mRegistrarConsumible.Name = "mRegistrarConsumible";
            this.mRegistrarConsumible.Size = new System.Drawing.Size(138, 22);
            this.mRegistrarConsumible.Tag = "10";
            this.mRegistrarConsumible.Text = "Consumible";
            this.mRegistrarConsumible.Visible = false;
            // 
            // mFacturar
            // 
            this.mFacturar.Name = "mFacturar";
            this.mFacturar.Size = new System.Drawing.Size(138, 22);
            this.mFacturar.Tag = "11";
            this.mFacturar.Text = "Facturar";
            this.mFacturar.Visible = false;
            // 
            // mReportes
            // 
            this.mReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEstadistico,
            this.mClientesErroneos});
            this.mReportes.Name = "mReportes";
            this.mReportes.Size = new System.Drawing.Size(65, 20);
            this.mReportes.Text = "Reporte&s";
            this.mReportes.Visible = false;
            // 
            // mEstadistico
            // 
            this.mEstadistico.Name = "mEstadistico";
            this.mEstadistico.Size = new System.Drawing.Size(178, 22);
            this.mEstadistico.Tag = "12";
            this.mEstadistico.Text = "Estadístico";
            this.mEstadistico.Visible = false;
            this.mEstadistico.Click += new System.EventHandler(this.mEstadistico_Click);
            // 
            // mClientesErroneos
            // 
            this.mClientesErroneos.Name = "mClientesErroneos";
            this.mClientesErroneos.Size = new System.Drawing.Size(178, 22);
            this.mClientesErroneos.Tag = "13";
            this.mClientesErroneos.Text = "Clientes con errores";
            this.mClientesErroneos.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBA - Hoteles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mABM;
        private System.Windows.Forms.ToolStripMenuItem mReserva;
        private System.Windows.Forms.ToolStripMenuItem mEstadia;
        private System.Windows.Forms.ToolStripMenuItem mRegistrarEstadia;
        private System.Windows.Forms.ToolStripMenuItem mRegistrarConsumible;
        private System.Windows.Forms.ToolStripMenuItem mFacturar;
        private System.Windows.Forms.ToolStripMenuItem mReportes;
        private System.Windows.Forms.ToolStripMenuItem mCliente;
        private System.Windows.Forms.ToolStripMenuItem mAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem mBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem mHabitacion;
        private System.Windows.Forms.ToolStripMenuItem mAltaHabitacion;
        private System.Windows.Forms.ToolStripMenuItem mModifHabitacion;
        private System.Windows.Forms.ToolStripMenuItem mRol;
        private System.Windows.Forms.ToolStripMenuItem mAltaRol;
        private System.Windows.Forms.ToolStripMenuItem mBajaRol;
        private System.Windows.Forms.ToolStripMenuItem mUsuario;
        private System.Windows.Forms.ToolStripMenuItem mAltaUsuario;
        private System.Windows.Forms.ToolStripMenuItem mBajaUsuario;
        private System.Windows.Forms.ToolStripMenuItem mRegimen;
        private System.Windows.Forms.ToolStripMenuItem mAltaRegimen;
        private System.Windows.Forms.ToolStripMenuItem mGenerarReserva;
        private System.Windows.Forms.ToolStripMenuItem mCancelarReserva;
        private System.Windows.Forms.ToolStripMenuItem mEstadistico;
        private System.Windows.Forms.ToolStripMenuItem mClientesErroneos;
        private System.Windows.Forms.ToolStripMenuItem mModifReserva;
        private System.Windows.Forms.ToolStripMenuItem mHotel;
        private System.Windows.Forms.ToolStripMenuItem mAltaHotel;
        private System.Windows.Forms.ToolStripMenuItem mBajaHotel;
    }
}



