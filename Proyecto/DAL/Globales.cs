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
        public static string[] Conexion = { "ZGHP", "SAD2017", "admin", "@umg2017" };
        //Parámetros de Conexion -> {"USUARIO","PASSWORD","BASEDEDATOS","SERVIDOR"}
        public static MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");

        public static void Inicializar()
        {

        }

    }
}
