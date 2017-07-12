/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Empleados
    Fecha de asignación: 27/Junio
    Fecha de entrega: 09/Julio
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
    public class Empleados_DAL
    {
        public void vInsertEmpleado(Empleados_Entity Empleado)
        {
            Globales.cnn.insertSQL("INSERT INTO [dbo].[Empleado] (idempresa,idestado,codusuario,idrol) VALUES ('"
                + Empleado.idempresa + "','" + Empleado.idestado + "','" + Empleado.codusuario+ "','" + Empleado.idrol + "')");
        }

        public void vEliminarEmpleado(Empleados_Entity Empleado)
        {
            Globales.cnn.updateSQL("DELETE FROM [dbo].[Empleado] WHERE idempleado =" + Empleado.idempleado);
        }

        public DataTable vConsultarEmpleado()
        {
            DataTable dtEmpleado;
            dtEmpleado = Globales.cnn.getSQL("SELECT idempleado as ID, Empresa.idempresa as IdEmpresa, Empresa.nombre_empresa as Empresa, Usuario_1.codusuario as IdUsuario, Usuario_1.Usuario, Empleado.idrol as Rol FROM [dbo].[Empleado] INNER JOIN Usuario_1 ON empleado.codusuario = usuario_1.codusuario INNER JOIN Empresa ON Empleado.idempresa = Empresa.idempresa Order By Usuario_1.codusuario, Empresa.idempresa, Empleado.idempleado");
            return dtEmpleado;
        }

        public void vConsultarEmpleado(Empleados_Entity Empleado)
        {
            Globales.cnn.getSQL("SELECT idempleado as ID, Empresa.idempresa as IdEmpresa, Empresa.nombre_empresa as Empresa, Usuario_1.codusuario as IdUsuario, Usuario_1.Usuario, Empleado.idrol FROM [dbo].[Empleado] INNER JOIN Usuario_1 ON empleado.codusuario = usuario_1.codusuario INNER JOIN Empresa ON Empleado.idempresa = Empresa.idempresa WHERE idempleado=" + Empleado.idempleado);
        }

        public DataTable vConsultarFiltro(Empleados_Entity Empleado)
        {
            DataTable dtEmpleado;
            dtEmpleado = Globales.cnn.getSQL("SELECT idempleado as ID, Empresa.idempresa as IdEmpresa, Empresa.nombre_empresa as Empresa,  Usuario_1.codusuario as IdUsuario, Usuario_1.Usuario, Empleado.idrolROM [dbo].[Empleado] INNER JOIN Usuario_1 ON empleado.codusuario = usuario_1.codusuario INNER JOIN Empresa ON Empleado.idempresa = Empresa.idempresa  WHERE nombre_Empleado like '%" + Empleado.codusuario + "%'  Order By Usuario_1.codusuario, Empresa.idempresa, Empleado.idempleado");
            return dtEmpleado;
        }
    }
}
