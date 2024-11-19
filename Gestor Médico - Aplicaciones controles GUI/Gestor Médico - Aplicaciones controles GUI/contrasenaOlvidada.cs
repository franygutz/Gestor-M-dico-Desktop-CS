using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    public partial class contrasenaOlvidada : Form
    {
        public contrasenaOlvidada()
        {
            InitializeComponent();
        }


        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close(); //oculta la ventana actual
        }

        private void bIrGmail_Click(object sender, EventArgs e)
        {
            string url = "https://workspace.google.com/intl/es-419/gmail/"; //url de gmail
            System.Diagnostics.Process.Start(url); // permite abrirlo en el navegador predeterminado
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha enviado un correo con la nueva contraseña", "Registro de Usuario - Contraseña Olvidada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Control control in Controls)
            {
                if (control is TextBox tb)
                {
                    tb.Text = string.Empty; // Limpia el texto de TextBox
                }
                else if (control is MaskedTextBox mtb)
                {
                    mtb.Text = string.Empty; // Limpia el texto de MaskedTextBox
                }
            }
        }
    }
}
