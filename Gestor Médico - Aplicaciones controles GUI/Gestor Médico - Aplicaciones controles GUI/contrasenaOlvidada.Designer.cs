namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    partial class contrasenaOlvidada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contrasenaOlvidada));
            this.pbCuadroBlanco = new System.Windows.Forms.PictureBox();
            this.pbLogoRandom = new System.Windows.Forms.PictureBox();
            this.lGestorMdcoContra = new System.Windows.Forms.Label();
            this.lLinea = new System.Windows.Forms.Label();
            this.tbUsuarioCO = new System.Windows.Forms.TextBox();
            this.lUsuarioCO = new System.Windows.Forms.Label();
            this.lIndicacion = new System.Windows.Forms.Label();
            this.bVolver = new System.Windows.Forms.Button();
            this.bIrGmail = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuadroBlanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCuadroBlanco
            // 
            this.pbCuadroBlanco.BackColor = System.Drawing.Color.White;
            this.pbCuadroBlanco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCuadroBlanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCuadroBlanco.Location = new System.Drawing.Point(169, 65);
            this.pbCuadroBlanco.Name = "pbCuadroBlanco";
            this.pbCuadroBlanco.Size = new System.Drawing.Size(265, 249);
            this.pbCuadroBlanco.TabIndex = 0;
            this.pbCuadroBlanco.TabStop = false;
            // 
            // pbLogoRandom
            // 
            this.pbLogoRandom.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoRandom.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoRandom.Image")));
            this.pbLogoRandom.Location = new System.Drawing.Point(202, 77);
            this.pbLogoRandom.Name = "pbLogoRandom";
            this.pbLogoRandom.Size = new System.Drawing.Size(58, 51);
            this.pbLogoRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoRandom.TabIndex = 1;
            this.pbLogoRandom.TabStop = false;
            // 
            // lGestorMdcoContra
            // 
            this.lGestorMdcoContra.BackColor = System.Drawing.Color.White;
            this.lGestorMdcoContra.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lGestorMdcoContra.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestorMdcoContra.Location = new System.Drawing.Point(313, 77);
            this.lGestorMdcoContra.Name = "lGestorMdcoContra";
            this.lGestorMdcoContra.Size = new System.Drawing.Size(87, 51);
            this.lGestorMdcoContra.TabIndex = 2;
            this.lGestorMdcoContra.Text = "Gestor Médico";
            // 
            // lLinea
            // 
            this.lLinea.BackColor = System.Drawing.Color.White;
            this.lLinea.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lLinea.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLinea.Location = new System.Drawing.Point(280, 77);
            this.lLinea.Name = "lLinea";
            this.lLinea.Size = new System.Drawing.Size(22, 51);
            this.lLinea.TabIndex = 3;
            this.lLinea.Text = "|";
            // 
            // tbUsuarioCO
            // 
            this.tbUsuarioCO.AcceptsTab = true;
            this.tbUsuarioCO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsuarioCO.Location = new System.Drawing.Point(202, 161);
            this.tbUsuarioCO.Name = "tbUsuarioCO";
            this.tbUsuarioCO.Size = new System.Drawing.Size(195, 20);
            this.tbUsuarioCO.TabIndex = 4;
            // 
            // lUsuarioCO
            // 
            this.lUsuarioCO.AutoSize = true;
            this.lUsuarioCO.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lUsuarioCO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarioCO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lUsuarioCO.Location = new System.Drawing.Point(199, 143);
            this.lUsuarioCO.Name = "lUsuarioCO";
            this.lUsuarioCO.Size = new System.Drawing.Size(103, 15);
            this.lUsuarioCO.TabIndex = 5;
            this.lUsuarioCO.Text = "Digite su Usuario";
            // 
            // lIndicacion
            // 
            this.lIndicacion.BackColor = System.Drawing.Color.White;
            this.lIndicacion.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lIndicacion.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIndicacion.Location = new System.Drawing.Point(197, 194);
            this.lIndicacion.Name = "lIndicacion";
            this.lIndicacion.Size = new System.Drawing.Size(216, 62);
            this.lIndicacion.TabIndex = 6;
            this.lIndicacion.Text = "Esta opción le permite recuperar su contraseña, enviando un código de acceso a la" +
    " dirección de correo electrónico asociada al usuario ingresado. Su contaseña es " +
    "el código enviado.";
            // 
            // bVolver
            // 
            this.bVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bVolver.Location = new System.Drawing.Point(202, 272);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(61, 23);
            this.bVolver.TabIndex = 7;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bIrGmail
            // 
            this.bIrGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bIrGmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIrGmail.Location = new System.Drawing.Point(339, 272);
            this.bIrGmail.Name = "bIrGmail";
            this.bIrGmail.Size = new System.Drawing.Size(61, 23);
            this.bIrGmail.TabIndex = 8;
            this.bIrGmail.Text = "Ir a Gmail";
            this.bIrGmail.UseVisualStyleBackColor = true;
            this.bIrGmail.Click += new System.EventHandler(this.bIrGmail_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAceptar.Location = new System.Drawing.Point(272, 272);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(61, 23);
            this.bAceptar.TabIndex = 9;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // contrasenaOlvidada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bIrGmail);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.lIndicacion);
            this.Controls.Add(this.tbUsuarioCO);
            this.Controls.Add(this.lUsuarioCO);
            this.Controls.Add(this.lLinea);
            this.Controls.Add(this.lGestorMdcoContra);
            this.Controls.Add(this.pbLogoRandom);
            this.Controls.Add(this.pbCuadroBlanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "contrasenaOlvidada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pbCuadroBlanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCuadroBlanco;
        private System.Windows.Forms.PictureBox pbLogoRandom;
        private System.Windows.Forms.Label lGestorMdcoContra;
        private System.Windows.Forms.Label lLinea;
        private System.Windows.Forms.TextBox tbUsuarioCO;
        private System.Windows.Forms.Label lUsuarioCO;
        private System.Windows.Forms.Label lIndicacion;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bIrGmail;
        private System.Windows.Forms.Button bAceptar;
    }
}