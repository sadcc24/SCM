/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Bitácora
    Fecha de asignación: 28/Junio
    Fecha de entrega: 08/Julio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class Bitacora_DAL
    {
        public DataTable vConsultarBitacora()
        {
            DataTable dtBitacora;
            dtBitacora = Globales.cnn.getSQL("SELECT bita.idbitacora as ID, emp.nombre_empresa as Empresa, usu.usuario as Usuario, rol.rol as Rol, bita.Equipo, bita.fechahora as Fecha, bita.tabla as Módulo, bita.accion as Evento FROM dbo.BITACORA bita INNER JOIN dbo.EMPRESA emp ON bita.idempresa = emp.idempresa INNER JOIN dbo.Usuario_1 usu ON bita.codusuario = Usu.codusuario INNER JOIN ROL ON bita.idrol = Rol.idrol Order By bita.fechahora desc");
            return dtBitacora;
        }

        public void vConsultarBitacora(Bitacora_Entity Bitacora)
        {
            Globales.cnn.getSQL("SELECT * FROM [dbo].[Bitacora] INNER JOIN EMPRESA ON Bitacora.idempresa = Empresa.idempresa INNER JOIN Usuario_1 ON Bitacora.codBitacora = Usuario_1.codBitacora INNER JOIN ROL ON Bitacora.idrol = Rol.idrol  WHERE Status = 1 and codBitacora=" + Bitacora.idbitacora);
        }

        public DataTable vConsultarFiltro(Bitacora_Entity Bitacora)
        {
            DataTable dtBitacora;
            dtBitacora = Globales.cnn.getSQL("SELECT bita.idbitacora as ID, emp.nombre_empresa as Empresa, usu.usuario as Usuario, rol.rol as Rol, bita.Equipo, bita.fechahora as Fecha, bita.tabla as Módulo, bita.accion as Evento FROM dbo.BITACORA bita INNER JOIN dbo.EMPRESA emp ON bita.idempresa = emp.idempresa INNER JOIN dbo.Usuario_1 usu ON bita.codusuario = Usu.codusuario INNER JOIN ROL ON bita.idrol = Rol.idrol  WHERE usu.usuario like '%" + Bitacora.codusuario + "%' Order By bita.fechahora desc");
            return dtBitacora;
        }
    }
}
