namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    partial class HubUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubUsuario));
            this.lPanelControl = new System.Windows.Forms.Label();
            this.lGestionPaciente = new System.Windows.Forms.Label();
            this.bAgregarPac = new System.Windows.Forms.Button();
            this.lGestCitas = new System.Windows.Forms.Label();
            this.bAgregarCita = new System.Windows.Forms.Button();
            this.bLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPanelControl
            // 
            this.lPanelControl.AutoSize = true;
            this.lPanelControl.BackColor = System.Drawing.Color.Transparent;
            this.lPanelControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.lPanelControl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPanelControl.ForeColor = System.Drawing.Color.Black;
            this.lPanelControl.Location = new System.Drawing.Point(171, 9);
            this.lPanelControl.Name = "lPanelControl";
            this.lPanelControl.Size = new System.Drawing.Size(246, 34);
            this.lPanelControl.TabIndex = 1;
            this.lPanelControl.Text = "Panel de Control";
            // 
            // lGestionPaciente
            // 
            this.lGestionPaciente.AutoSize = true;
            this.lGestionPaciente.BackColor = System.Drawing.Color.Transparent;
            this.lGestionPaciente.Cursor = System.Windows.Forms.Cursors.Default;
            this.lGestionPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestionPaciente.ForeColor = System.Drawing.Color.Black;
            this.lGestionPaciente.Location = new System.Drawing.Point(381, 133);
            this.lGestionPaciente.Name = "lGestionPaciente";
            this.lGestionPaciente.Size = new System.Drawing.Size(150, 18);
            this.lGestionPaciente.TabIndex = 2;
            this.lGestionPaciente.Text = "Gestionar Pacientes";
            // 
            // bAgregarPac
            // 
            this.bAgregarPac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAgregarPac.Location = new System.Drawing.Point(384, 163);
            this.bAgregarPac.Name = "bAgregarPac";
            this.bAgregarPac.Size = new System.Drawing.Size(198, 23);
            this.bAgregarPac.TabIndex = 3;
            this.bAgregarPac.Text = "Agregar Paciente";
            this.bAgregarPac.UseVisualStyleBackColor = true;
            this.bAgregarPac.Click += new System.EventHandler(this.bAgregarPac_Click);
            // 
            // lGestCitas
            // 
            this.lGestCitas.AutoSize = true;
            this.lGestCitas.BackColor = System.Drawing.Color.Transparent;
            this.lGestCitas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lGestCitas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGestCitas.ForeColor = System.Drawing.Color.Black;
            this.lGestCitas.Location = new System.Drawing.Point(12, 133);
            this.lGestCitas.Name = "lGestCitas";
            this.lGestCitas.Size = new System.Drawing.Size(117, 18);
            this.lGestCitas.TabIndex = 6;
            this.lGestCitas.Text = "Gestionar Citas";
            // 
            // bAgregarCita
            // 
            this.bAgregarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAgregarCita.Location = new System.Drawing.Point(12, 163);
            this.bAgregarCita.Name = "bAgregarCita";
            this.bAgregarCita.Size = new System.Drawing.Size(198, 23);
            this.bAgregarCita.TabIndex = 7;
            this.bAgregarCita.Text = "Agregar Cita";
            this.bAgregarCita.UseVisualStyleBackColor = true;
            this.bAgregarCita.Click += new System.EventHandler(this.bAgregarCita_Click);
            // 
            // bLogOut
            // 
            this.bLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogOut.Location = new System.Drawing.Point(212, 342);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(186, 23);
            this.bLogOut.TabIndex = 10;
            this.bLogOut.Text = "Cerrar Sesión";
            this.bLogOut.UseVisualStyleBackColor = true;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // HubUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.bAgregarCita);
            this.Controls.Add(this.lGestCitas);
            this.Controls.Add(this.bAgregarPac);
            this.Controls.Add(this.lGestionPaciente);
            this.Controls.Add(this.lPanelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HubUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPanelControl;
        private System.Windows.Forms.Label lGestionPaciente;
        private System.Windows.Forms.Button bAgregarPac;
        private System.Windows.Forms.Label lGestCitas;
        private System.Windows.Forms.Button bAgregarCita;
        private System.Windows.Forms.Button bLogOut;
    }
}