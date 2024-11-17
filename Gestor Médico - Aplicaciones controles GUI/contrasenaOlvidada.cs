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
    }
}
