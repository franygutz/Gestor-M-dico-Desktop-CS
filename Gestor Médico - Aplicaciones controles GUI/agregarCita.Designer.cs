namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    partial class agregarCita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarCita));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lAggNuevaCita = new System.Windows.Forms.Label();
            this.lLinea = new System.Windows.Forms.Label();
            this.pbLogoRandom = new System.Windows.Forms.PictureBox();
            this.lFechaCita = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lFechaSeleccionada = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNombrePaciente = new System.Windows.Forms.Label();
            this.lTipoCita = new System.Windows.Forms.Label();
            this.combTipoCita = new System.Windows.Forms.ComboBox();
            this.lDoctor = new System.Windows.Forms.Label();
            this.combDoctor = new System.Windows.Forms.ComboBox();
            this.lDuracion = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbRequerimiento = new System.Windows.Forms.CheckBox();
            this.cbPrioridad = new System.Windows.Forms.CheckBox();
            this.bVolver = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-48, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lAggNuevaCita
            // 
            this.lAggNuevaCita.BackColor = System.Drawing.Color.White;
            this.lAggNuevaCita.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lAggNuevaCita.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAggNuevaCita.Location = new System.Drawing.Point(392, 22);
            this.lAggNuevaCita.Name = "lAggNuevaCita";
            this.lAggNuevaCita.Size = new System.Drawing.Size(208, 27);
            this.lAggNuevaCita.TabIndex = 15;
            this.lAggNuevaCita.Text = "Agregar Nueva Cita";
            // 
            // lLinea
            // 
            this.lLinea.BackColor = System.Drawing.Color.White;
            this.lLinea.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lLinea.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLinea.Location = new System.Drawing.Point(364, 9);
            this.lLinea.Name = "lLinea";
            this.lLinea.Size = new System.Drawing.Size(22, 51);
            this.lLinea.TabIndex = 14;
            this.lLinea.Text = "|";
            // 
            // pbLogoRandom
            // 
            this.pbLogoRandom.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoRandom.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoRandom.Image")));
            this.pbLogoRandom.Location = new System.Drawing.Point(308, 12);
            this.pbLogoRandom.Name = "pbLogoRandom";
            this.pbLogoRandom.Size = new System.Drawing.Size(50, 40);
            this.pbLogoRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoRandom.TabIndex = 13;
            this.pbLogoRandom.TabStop = false;
            // 
            // lFechaCita
            // 
            this.lFechaCita.AutoSize = true;
            this.lFechaCita.BackColor = System.Drawing.Color.White;
            this.lFechaCita.Cursor = System.Windows.Forms.Cursors.Default;
            this.lFechaCita.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaCita.Location = new System.Drawing.Point(16, 84);
            this.lFechaCita.Name = "lFechaCita";
            this.lFechaCita.Size = new System.Drawing.Size(174, 16);
            this.lFechaCita.TabIndex = 16;
            this.lFechaCita.Text = "Seleccionar Fecha de la Cita";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Location = new System.Drawing.Point(18, 109);
            this.monthCalendar1.MinDate = new System.DateTime(2024, 11, 17, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lFechaSeleccionada
            // 
            this.lFechaSeleccionada.BackColor = System.Drawing.Color.White;
            this.lFechaSeleccionada.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lFechaSeleccionada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaSeleccionada.Location = new System.Drawing.Point(15, 280);
            this.lFechaSeleccionada.Name = "lFechaSeleccionada";
            this.lFechaSeleccionada.Size = new System.Drawing.Size(252, 41);
            this.lFechaSeleccionada.TabIndex = 18;
            this.lFechaSeleccionada.Visible = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(326, 89);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(199, 20);
            this.tbNombre.TabIndex = 20;
            // 
            // lNombrePaciente
            // 
            this.lNombrePaciente.AutoSize = true;
            this.lNombrePaciente.BackColor = System.Drawing.Color.White;
            this.lNombrePaciente.Cursor = System.Windows.Forms.Cursors.Default;
            this.lNombrePaciente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombrePaciente.Location = new System.Drawing.Point(323, 72);
            this.lNombrePaciente.Name = "lNombrePaciente";
            this.lNombrePaciente.Size = new System.Drawing.Size(103, 15);
            this.lNombrePaciente.TabIndex = 19;
            this.lNombrePaciente.Text = "Nombre Paciente";
            // 
            // lTipoCita
            // 
            this.lTipoCita.AutoSize = true;
            this.lTipoCita.BackColor = System.Drawing.Color.White;
            this.lTipoCita.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTipoCita.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoCita.Location = new System.Drawing.Point(323, 121);
            this.lTipoCita.Name = "lTipoCita";
            this.lTipoCita.Size = new System.Drawing.Size(73, 15);
            this.lTipoCita.TabIndex = 21;
            this.lTipoCita.Text = "Tipo de Cita";
            // 
            // combTipoCita
            // 
            this.combTipoCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combTipoCita.FormattingEnabled = true;
            this.combTipoCita.Items.AddRange(new object[] {
            "Consulta Médica",
            "Reunión",
            "Evaluación"});
            this.combTipoCita.Location = new System.Drawing.Point(326, 139);
            this.combTipoCita.Name = "combTipoCita";
            this.combTipoCita.Size = new System.Drawing.Size(199, 21);
            this.combTipoCita.TabIndex = 22;
            // 
            // lDoctor
            // 
            this.lDoctor.AutoSize = true;
            this.lDoctor.BackColor = System.Drawing.Color.White;
            this.lDoctor.Cursor = System.Windows.Forms.Cursors.Default;
            this.lDoctor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDoctor.Location = new System.Drawing.Point(323, 173);
            this.lDoctor.Name = "lDoctor";
            this.lDoctor.Size = new System.Drawing.Size(111, 15);
            this.lDoctor.TabIndex = 23;
            this.lDoctor.Text = "Nombre del Doctor";
            // 
            // combDoctor
            // 
            this.combDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combDoctor.FormattingEnabled = true;
            this.combDoctor.Items.AddRange(new object[] {
            "Claire Cottrill",
            "Chappell Roan",
            "Faye Webster",
            "Troye Sivan"});
            this.combDoctor.Location = new System.Drawing.Point(326, 191);
            this.combDoctor.Name = "combDoctor";
            this.combDoctor.Size = new System.Drawing.Size(199, 21);
            this.combDoctor.TabIndex = 24;
            // 
            // lDuracion
            // 
            this.lDuracion.AutoSize = true;
            this.lDuracion.BackColor = System.Drawing.Color.White;
            this.lDuracion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lDuracion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDuracion.Location = new System.Drawing.Point(323, 226);
            this.lDuracion.Name = "lDuracion";
            this.lDuracion.Size = new System.Drawing.Size(155, 15);
            this.lDuracion.TabIndex = 25;
            this.lDuracion.Text = "Duración de Cita (minutos)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(326, 244);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // cbRequerimiento
            // 
            this.cbRequerimiento.AutoSize = true;
            this.cbRequerimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRequerimiento.Location = new System.Drawing.Point(326, 279);
            this.cbRequerimiento.Name = "cbRequerimiento";
            this.cbRequerimiento.Size = new System.Drawing.Size(133, 17);
            this.cbRequerimiento.TabIndex = 27;
            this.cbRequerimiento.Text = "Requiere Recordatorio";
            this.cbRequerimiento.UseVisualStyleBackColor = true;
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.AutoSize = true;
            this.cbPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPrioridad.Location = new System.Drawing.Point(326, 302);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(88, 17);
            this.cbPrioridad.TabIndex = 28;
            this.cbPrioridad.Text = "Prioridad Alta";
            this.cbPrioridad.UseVisualStyleBackColor = true;
            // 
            // bVolver
            // 
            this.bVolver.Location = new System.Drawing.Point(19, 342);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(171, 23);
            this.bVolver.TabIndex = 29;
            this.bVolver.Text = "Volver";
            this.bVolver.UseVisualStyleBackColor = true;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(211, 342);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(171, 23);
            this.bGuardar.TabIndex = 30;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bLimpiar
            // 
            this.bLimpiar.Location = new System.Drawing.Point(397, 342);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(171, 23);
            this.bLimpiar.TabIndex = 31;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // agregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.cbPrioridad);
            this.Controls.Add(this.cbRequerimiento);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lDuracion);
            this.Controls.Add(this.combDoctor);
            this.Controls.Add(this.lDoctor);
            this.Controls.Add(this.combTipoCita);
            this.Controls.Add(this.lTipoCita);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombrePaciente);
            this.Controls.Add(this.lFechaSeleccionada);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lFechaCita);
            this.Controls.Add(this.lAggNuevaCita);
            this.Controls.Add(this.lLinea);
            this.Controls.Add(this.pbLogoRandom);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "agregarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nueva Cita";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lAggNuevaCita;
        private System.Windows.Forms.Label lLinea;
        private System.Windows.Forms.PictureBox pbLogoRandom;
        private System.Windows.Forms.Label lFechaCita;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lFechaSeleccionada;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lNombrePaciente;
        private System.Windows.Forms.Label lTipoCita;
        private System.Windows.Forms.ComboBox combTipoCita;
        private System.Windows.Forms.Label lDoctor;
        private System.Windows.Forms.ComboBox combDoctor;
        private System.Windows.Forms.Label lDuracion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox cbRequerimiento;
        private System.Windows.Forms.CheckBox cbPrioridad;
        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bLimpiar;
    }
}