namespace FrbaHotel
{
    partial class login
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.lblSinUsuario = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(73, 12);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(73, 38);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(132, 20);
            this.txtPass.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(4, 15);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(4, 41);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "Contraseña";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(3, 96);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 4;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(130, 96);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // lblSinUsuario
            // 
            this.lblSinUsuario.AutoSize = true;
            this.lblSinUsuario.Location = new System.Drawing.Point(146, 61);
            this.lblSinUsuario.Name = "lblSinUsuario";
            this.lblSinUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblSinUsuario.TabIndex = 6;
            this.lblSinUsuario.TabStop = true;
            this.lblSinUsuario.Text = "Sin usuario";
            this.lblSinUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSinUsuario_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 127);
            this.Controls.Add(this.lblSinUsuario);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.LinkLabel lblSinUsuario;
    }
}