using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllSeguridadSAD;

namespace SCM
{
    static class Globales
    {

        public static Enterprise Empresa = new Enterprise();
        public static Login Usuario = new Login();
        public static string Rol;
        //Parámetros de Conexion {"SERVIDOR","BASEDEDATOS","USUARIO","PASSWORD"}  MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        //
        public static string[] Conexion = { "PJSELMAN\\SAD2017", "SAD2017", "sa", "SAD2017" };
       
        public static void Inicializar()
        {

        }

    }
}
