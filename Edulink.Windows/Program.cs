using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edulink.Windows
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
            Application.Run(new FrmInicioSesion());
            //Application.Run(new FrmMenuPrincipal(1, "Tecnicatura Superior en Análisis, Desarrollo y Programación de Aplicaciones"));//hardcoedeado!!!
        }
    }
}
