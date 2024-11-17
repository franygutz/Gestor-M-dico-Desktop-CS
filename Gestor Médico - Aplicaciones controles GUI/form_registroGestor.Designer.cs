namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    partial class fRegistroGestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegistroGestor));
            this.lGestorMdco = new System.Windows.Forms.Label();
            this.lingresoCredenciales = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lContraseña = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.mtbContrasena = new System.Windows.Forms.MaskedTextBox();
            this.bIngresar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lContrasenaOlvidada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lGestorMdco
            // 
            this.lGestorMdco.AutoSize = true;
            this.lGestorMdco.BackColor = System.Drawing.Color.Transparent;
            this.lGestorMdco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestorMdco.Location = new System.Drawing.Point(355, 56);
            this.lGestorMdco.Name = "lGestorMdco";
            this.lGestorMdco.Size = new System.Drawing.Size(156, 24);
            this.lGestorMdco.TabIndex = 0;
            this.lGestorMdco.Text = "Gestor Médico";
            // 
            // lingresoCredenciales
            // 
            this.lingresoCredenciales.AutoSize = true;
            this.lingresoCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.lingresoCredenciales.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lingresoCredenciales.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lingresoCredenciales.Location = new System.Drawing.Point(356, 80);
            this.lingresoCredenciales.Name = "lingresoCredenciales";
            this.lingresoCredenciales.Size = new System.Drawing.Size(124, 14);
            this.lingresoCredenciales.TabIndex = 1;
            this.lingresoCredenciales.Text = "Ingreso de Credenciales";
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lUsuario.Location = new System.Drawing.Point(356, 117);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(103, 15);
            this.lUsuario.TabIndex = 2;
            this.lUsuario.Text = "Digite su Usuario";
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lContraseña.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lContraseña.Location = new System.Drawing.Point(356, 190);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Size = new System.Drawing.Size(124, 15);
            this.lContraseña.TabIndex = 3;
            this.lContraseña.Text = "Digite su Contraseña";
            // 
            // tbUsuario
            // 
            this.tbUsuario.AcceptsTab = true;
            this.tbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuario.Location = new System.Drawing.Point(359, 144);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(195, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // mtbContrasena
            // 
            this.mtbContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbContrasena.Location = new System.Drawing.Point(359, 218);
            this.mtbContrasena.Name = "mtbContrasena";
            this.mtbContrasena.PasswordChar = '*';
            this.mtbContrasena.Size = new System.Drawing.Size(195, 20);
            this.mtbContrasena.TabIndex = 4;
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(359, 296);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(86, 23);
            this.bIngresar.TabIndex = 5;
            this.bIngresar.Text = "Ingresar";
            this.bIngresar.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(468, 296);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(86, 23);
            this.bSalir.TabIndex = 6;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // lContrasenaOlvidada
            // 
            this.lContrasenaOlvidada.AutoSize = true;
            this.lContrasenaOlvidada.BackColor = System.Drawing.Color.Transparent;
            this.lContrasenaOlvidada.Font = new System.Drawing.Font("Arial Narrow", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContrasenaOlvidada.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lContrasenaOlvidada.Location = new System.Drawing.Point(406, 241);
            this.lContrasenaOlvidada.Name = "lContrasenaOlvidada";
            this.lContrasenaOlvidada.Size = new System.Drawing.Size(105, 13);
            this.lContrasenaOlvidada.TabIndex = 7;
            this.lContrasenaOlvidada.Text = "He olvidado mi Contraseña";
            this.lContrasenaOlvidada.Click += new System.EventHandler(this.lContrasenaOlvidada_Click);
            // 
            // fRegistroGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.lContrasenaOlvidada);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.mtbContrasena);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.lingresoCredenciales);
            this.Controls.Add(this.lGestorMdco);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "fRegistroGestor";
            this.Text = "Registro - Gestor Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGestorMdco;
        private System.Windows.Forms.Label lingresoCredenciales;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.MaskedTextBox mtbContrasena;
        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lContrasenaOlvidada;
    }
}