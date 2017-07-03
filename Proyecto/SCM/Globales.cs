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
        //Parámetros de Conexion {"SERVIDOR","BASEDEDATOS","USUARIO","PASSWORD"}
        //  public static string[] Conexion = { "ZGHP", "SAD2017", "admin", "@umg2017" };
        public static string[] Conexion = { "sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017" };

        public static void Inicializar()
        {

        }

    }
}
