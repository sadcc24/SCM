/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Objetos Globales
    Fecha de asignación: 20/Junio
    Fecha de entrega: 03/Julio
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllSeguridadSAD;

namespace DAL
{
    public static class Globales
    {

        public static Enterprise Empresa = new Enterprise();
        public static Login Usuario = new Login();
        public static string Rol;
        //Parámetros de Conexion -> {"SERVIDOR","BASEDEDATOS","USUARIO","PASSWORD"}
        //public static string[] Conexion = { "ZGHP", "SAD2017", "admin", "@umg2017" };
      
        public static string[] Conexion = { @"DESKTOP-F4L56EU\SQLEXPRESS", "SAD2017", "ivan", "developer1993" };
        //public static string[] Conexion = { "SDESRUTA40", "utpl", "r40usr", "Inter$2013" };
        
        //Parámetros de Conexion -> {"USUARIO","PASSWORD","BASEDEDATOS","SERVIDOR"}
        //  public static MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        
        public static MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");
        //public static MRP_BD cnn = new MRP_BD("r40usr", "Inter$2013", "utpl", "SDESRUTA40");


        public static void Inicializar()
        {

        }

    }
}
