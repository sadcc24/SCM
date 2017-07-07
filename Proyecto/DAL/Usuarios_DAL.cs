/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Usuarios
    Fecha de asignación: 20/Junio
    Fecha de entrega: 03/Julio
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class Usuarios_DAL
    {      
        public void vInsertUsuario(Usuarios_Entity usuario)
        {
            Globales.cnn.insertSQL("INSERT INTO [dbo].[Usuario_1] (idrol,usuario,password,rol,status,preguntasecreta) VALUES ('"
                + usuario.iRol + "','" + usuario.strUsuario + "','" + usuario .strPassword + "','NULL','" + usuario.iStatus + "','" + usuario.strPregunta + "')");
        }

        public void vModificarUsuario(Usuarios_Entity usuario)
        {
            Globales.cnn.updateSQL("UPDATE [dbo].[Usuario_1] SET idrol ='" + usuario.iRol + "', usuario = '" + usuario.strUsuario+ "', password = '" + usuario.strPassword + "', status = '" + usuario.iStatus + "', preguntasecreta = '" + usuario.strPregunta + "'  WHERE codusuario ='" + usuario.iCodUsuario + "'");
        }

        public void vEliminarUsuario(Usuarios_Entity usuario)
        {
            Globales.cnn.updateSQL("UPDATE [dbo].[Usuario_1] SET Status = 0 WHERE codusuario =" + usuario.iCodUsuario);
        }

        public DataTable vConsultarUsuario()
        {
            DataTable dtUsuario;
            dtUsuario = Globales.cnn.getSQL("SELECT Rol.idrol, Rol.Rol as Rol, codusuario as ID, Usuario FROM [dbo].[Usuario_1] INNER JOIN ROL ON Usuario_1.idrol = Rol.idrol  WHERE Status = 1");
            return dtUsuario;
        }

        public void vConsultarUsuario(Usuarios_Entity usuario)
        {
            Globales.cnn.getSQL("SELECT * FROM [dbo].[Usuario_1] INNER JOIN ROL ON Usuario_1.idrol = Rol.idrol  WHERE Status = 1 and codusuario=" + usuario.iCodUsuario);
        }

        public DataTable vConsultarFiltro(Usuarios_Entity usuario)
        {
            DataTable dtUsuario;
            dtUsuario = Globales.cnn.getSQL("SELECT Rol.rol as Rol, codusuario as ID, Usuario FROM [dbo].[Usuario_1] INNER JOIN ROL ON Usuario_1.idrol = Rol.idrol WHERE usuario like '%" + usuario.strUsuario + "%' Group by rol.rol, codusuario, usuario");
            return dtUsuario;
        }
    }
}
