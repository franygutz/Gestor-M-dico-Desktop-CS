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
    public partial class fRegistroGestor : Form
    {
        private contrasenaOlvidada contraOlvidada;
        private HubUsuario controlesHubUsuario;

        public fRegistroGestor()
        {
            InitializeComponent();
        }

        private void lContrasenaOlvidada_Click(object sender, EventArgs e)
        {
            if(contraOlvidada == null || contraOlvidada.IsDisposed)
            {
                contraOlvidada = new contrasenaOlvidada();
                contraOlvidada.FormClosed += (s, args) => this.Show(); //permite abrir el formulario de registro si el contraseña olvidad se cierra
            }

            this.Hide(); //oculta la ventana actual
            contraOlvidada.Show(); //permite abrir el formulario de contraseña olvidada
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            if (controlesHubUsuario == null || controlesHubUsuario.IsDisposed)
            {
                controlesHubUsuario = new HubUsuario();
                controlesHubUsuario.FormClosed += (s, args) => this.Show(); //permite abrir el formulario de registro si el contraseña olvidad se cierra
            }

            this.Hide(); //oculta la ventana actual
            controlesHubUsuario.Show(); //permite abrir el formulario de contraseña olvidada
        }
    }
}
