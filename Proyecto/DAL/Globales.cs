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
        public static string[] Conexion = { "PJSELMAN\\SAD2017", "SAD17", "sa", "SAD2017" };
        //Parámetros de Conexion -> {"USUARIO","PASSWORD","BASEDEDATOS","SERVIDOR"}
        public static MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD17", "PJSELMAN\\SAD2017");

        public static void Inicializar()
        {

        }

    }
}
