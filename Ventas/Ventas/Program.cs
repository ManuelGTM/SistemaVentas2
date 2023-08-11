using Control_Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Security.RightsManagement;

namespace Ventas
{
    internal static class Program
    {
        public static int vidPedido = 0;
        public static int vidCliente = 0;
        public static int vidProducto = 0;
        public static bool modificar = false;
        public static bool nuevo = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FMenu());
        }
    }
}
