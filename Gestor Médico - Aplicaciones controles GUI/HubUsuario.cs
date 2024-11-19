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
    public partial class HubUsuario : Form
    {
        agregarPaciente agregarPac;
        agregarCita agregarCi;
        public HubUsuario()
        {
            InitializeComponent();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close(); //oculta la ventana actual
        }

        private void bAgregarPac_Click(object sender, EventArgs e)
        {
            if (agregarPac == null || agregarPac.IsDisposed)
            {
                agregarPac = new agregarPaciente();
                agregarPac.FormClosed += (s, args) => this.Show(); //permite abrir el formulario de registro si el contraseña olvidad se cierra
            }

            this.Hide(); //oculta la ventana actual
            agregarPac.Show(); //permite abrir el formulario de contraseña olvidada
        }

        private void bAgregarCita_Click(object sender, EventArgs e)
        {
            if (agregarCi == null || agregarCi.IsDisposed)
            {
                agregarCi = new agregarCita();
                agregarCi.FormClosed += (s, args) => this.Show(); //permite abrir el formulario de registro si el contraseña olvidad se cierra
            }

            this.Hide(); //oculta la ventana actual
            agregarCi.Show(); //permite abrir el formulario de contraseña olvidada
        }
    }
}
