using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    public partial class agregarPaciente : Form
    {
        public agregarPaciente()
        {
            InitializeComponent();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close(); //oculta la ventana actual
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paciente guardado con éxito", "Registro de Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiarControles(Control limpiar)
        {
            foreach (Control control in limpiar.Controls)
            {
                if (control is TextBox tb)
                {
                    tb.Text = string.Empty; // Limpia el texto de TextBox
                }
                else if (control is MaskedTextBox mtb)
                {
                    mtb.Text = string.Empty; // Limpia el texto de MaskedTextBox
                }
                else if (control is ComboBox cb)
                {
                    cb.SelectedIndex = -1; // Limpia la selección del ComboBox
                }
                else if (control is CheckBox chk)
                {
                    chk.Checked = false; // Desmarca CheckBox
                }
                else if (control is RadioButton rb)
                {
                    rb.Checked = false; // Desmarca el RadioButton
                }
                else if (control is NumericUpDown nud)
                {
                    nud.Value = nud.Minimum; // Restablece el valor al mínimo
                }
                else if (control is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now; // Restablece la fecha a la actual
                }
                else if (control.HasChildren)
                {
                    // Llama recursivamente si el control contiene otros controles
                    limpiarControles(control);
                }
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles(this); //limpiar formulario actual          
        }
    }
}
