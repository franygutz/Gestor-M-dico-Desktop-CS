namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    partial class agregarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarPaciente));
            this.pbCuadro = new System.Windows.Forms.PictureBox();
            this.lNombreCompleto = new System.Windows.Forms.Label();
            this.lCedula = new System.Windows.Forms.Label();
            this.lSexo = new System.Windows.Forms.Label();
            this.lNacimiento = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lDireccion = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lLinea = new System.Windows.Forms.Label();
            this.pbLogoRandom = new System.Windows.Forms.PictureBox();
            this.lAgregarNUevoPaciente = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.mtbCedula = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCuadro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCuadro
            // 
            this.pbCuadro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbCuadro.Location = new System.Drawing.Point(133, 26);
            this.pbCuadro.Name = "pbCuadro";
            this.pbCuadro.Size = new System.Drawing.Size(351, 327);
            this.pbCuadro.TabIndex = 0;
            this.pbCuadro.TabStop = false;
            // 
            // lNombreCompleto
            // 
            this.lNombreCompleto.AutoSize = true;
            this.lNombreCompleto.BackColor = System.Drawing.Color.White;
            this.lNombreCompleto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lNombreCompleto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreCompleto.Location = new System.Drawing.Point(159, 99);
            this.lNombreCompleto.Name = "lNombreCompleto";
            this.lNombreCompleto.Size = new System.Drawing.Size(111, 16);
            this.lNombreCompleto.TabIndex = 2;
            this.lNombreCompleto.Text = "Nombre Completo";
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.BackColor = System.Drawing.Color.White;
            this.lCedula.Cursor = System.Windows.Forms.Cursors.Default;
            this.lCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCedula.Location = new System.Drawing.Point(149, 137);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(121, 16);
            this.lCedula.TabIndex = 3;
            this.lCedula.Text = "Cédula de Identidad";
            // 
            // lSexo
            // 
            this.lSexo.AutoSize = true;
            this.lSexo.BackColor = System.Drawing.Color.White;
            this.lSexo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lSexo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSexo.Location = new System.Drawing.Point(233, 177);
            this.lSexo.Name = "lSexo";
            this.lSexo.Size = new System.Drawing.Size(37, 16);
            this.lSexo.TabIndex = 4;
            this.lSexo.Text = "Sexo";
            // 
            // lNacimiento
            // 
            this.lNacimiento.AutoSize = true;
            this.lNacimiento.BackColor = System.Drawing.Color.White;
            this.lNacimiento.Cursor = System.Windows.Forms.Cursors.Default;
            this.lNacimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNacimiento.Location = new System.Drawing.Point(140, 210);
            this.lNacimiento.Name = "lNacimiento";
            this.lNacimiento.Size = new System.Drawing.Size(130, 16);
            this.lNacimiento.TabIndex = 5;
            this.lNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.BackColor = System.Drawing.Color.White;
            this.lTelefono.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(216, 244);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(54, 16);
            this.lTelefono.TabIndex = 6;
            this.lTelefono.Text = "Teléfono";
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.BackColor = System.Drawing.Color.White;
            this.lDireccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.Location = new System.Drawing.Point(209, 279);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(61, 16);
            this.lDireccion.TabIndex = 7;
            this.lDireccion.Text = "Dirección";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(276, 99);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(199, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(276, 275);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDireccion.Size = new System.Drawing.Size(199, 20);
            this.tbDireccion.TabIndex = 9;
            // 
            // lLinea
            // 
            this.lLinea.BackColor = System.Drawing.Color.White;
            this.lLinea.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lLinea.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLinea.Location = new System.Drawing.Point(229, 35);
            this.lLinea.Name = "lLinea";
            this.lLinea.Size = new System.Drawing.Size(22, 51);
            this.lLinea.TabIndex = 11;
            this.lLinea.Text = "|";
            // 
            // pbLogoRandom
            // 
            this.pbLogoRandom.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoRandom.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoRandom.Image")));
            this.pbLogoRandom.Location = new System.Drawing.Point(152, 35);
            this.pbLogoRandom.Name = "pbLogoRandom";
            this.pbLogoRandom.Size = new System.Drawing.Size(58, 51);
            this.pbLogoRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoRandom.TabIndex = 10;
            this.pbLogoRandom.TabStop = false;
            // 
            // lAgregarNUevoPaciente
            // 
            this.lAgregarNUevoPaciente.BackColor = System.Drawing.Color.White;
            this.lAgregarNUevoPaciente.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lAgregarNUevoPaciente.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAgregarNUevoPaciente.Location = new System.Drawing.Point(267, 48);
            this.lAgregarNUevoPaciente.Name = "lAgregarNUevoPaciente";
            this.lAgregarNUevoPaciente.Size = new System.Drawing.Size(208, 27);
            this.lAgregarNUevoPaciente.TabIndex = 12;
            this.lAgregarNUevoPaciente.Text = "Agregar Nuevo Paciente";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.BackColor = System.Drawing.Color.White;
            this.rbFemenino.Location = new System.Drawing.Point(288, 176);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 13;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = false;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.Color.White;
            this.rbMasculino.Location = new System.Drawing.Point(375, 176);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 14;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // mtbCedula
            // 
            this.mtbCedula.Location = new System.Drawing.Point(277, 138);
            this.mtbCedula.Mask = "0000-0000-0000";
            this.mtbCedula.Name = "mtbCedula";
            this.mtbCedula.Size = new System.Drawing.Size(198, 20);
            this.mtbCedula.TabIndex = 15;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(272, 240);
            this.mtbTelefono.Mask = "0000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(198, 20);
            this.mtbTelefono.TabIndex = 16;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(272, 210);
            this.dtpNacimiento.MaxDate = new System.DateTime(2024, 11, 18, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(198, 20);
            this.dtpNacimiento.TabIndex = 17;
            this.dtpNacimiento.Value = new System.DateTime(2024, 11, 18, 0, 0, 0, 0);
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(176, 316);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(75, 23);
            this.bVolver.TabIndex = 18;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(277, 316);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 19;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(375, 316);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bLimpiar.TabIndex = 20;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // agregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.mtbCedula);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFemenino);
            this.Controls.Add(this.lAgregarNUevoPaciente);
            this.Controls.Add(this.lLinea);
            this.Controls.Add(this.pbLogoRandom);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.lTelefono);
            this.Controls.Add(this.lNacimiento);
            this.Controls.Add(this.lSexo);
            this.Controls.Add(this.lCedula);
            this.Controls.Add(this.lNombreCompleto);
            this.Controls.Add(this.pbCuadro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "agregarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Nuevo Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.pbCuadro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCuadro;
        private System.Windows.Forms.Label lNombreCompleto;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.Label lSexo;
        private System.Windows.Forms.Label lNacimiento;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label lLinea;
        private System.Windows.Forms.PictureBox pbLogoRandom;
        private System.Windows.Forms.Label lAgregarNUevoPaciente;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.MaskedTextBox mtbCedula;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bLimpiar;
    }
}