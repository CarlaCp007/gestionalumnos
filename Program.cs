using System;
using System.Windows.Forms;

namespace examen
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilitar estilos visuales para una mejor apariencia
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecutar la aplicación con la ventana principal
            Application.Run(new FormGestionCalificaciones());
        }
    }
}

