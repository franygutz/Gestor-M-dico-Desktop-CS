using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    public partial class agregarCita : Form
    {
        public agregarCita()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lFechaSeleccionada.Text = $"Fecha seleccionada: {e.Start.ToShortDateString()}"; //muestra la fecha seleccionada en el label
            lFechaSeleccionada.Visible = true; //hace visible el label
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close(); //oculta la ventana actual
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cita guardada con éxito", "Registro de Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiarControlesCita(Control limpiar)
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
                    limpiarControlesCita(control);
                }
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControlesCita(this); //limpiar formulario actual
            monthCalendar1.SetDate(DateTime.Today);  //restablecer la fecha seleccionada a la fecha actual
            monthCalendar1.MinDate = DateTime.Today;  //restablecer la fecha mínima, si es necesario
            lFechaSeleccionada.Visible = false;  //ocultar el Label
            lFechaSeleccionada.Text = "Fecha seleccionada:";
        }
    }
}
