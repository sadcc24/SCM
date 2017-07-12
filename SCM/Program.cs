using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new mostarSplash());
            // Application.Run(new ingresoOrdenServicio(6));
            // Application.Run(new buscarVehiculos());
            // Application.Run(new ingresoGastoGasolina(1008));
           Application.Run(new buscarSolicitudTransporte());

            //  Application.Run(new txtIdBodega("1", "1"));
        }
    }
}
