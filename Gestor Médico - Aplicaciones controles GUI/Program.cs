using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Aplicación de los controles de GUI en una aplicación ejemplo: Gestor Médico
Elaborado por: Franya Gutiérrez y Angie Rodríguez (Pareja N6)
Fecha de creación: 17/11/2024
Fecha de modificación: 17/11/2024
Versión: 2.0
Propósito: Aplicar los controles de GUI en una aplicación ejemplo
 */

namespace Gestor_Médico___Aplicaciones_controles_GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fRegistroGestor());
        }
    }
}
