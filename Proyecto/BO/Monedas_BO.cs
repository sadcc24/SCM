/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Monedas
    Fecha de asignación: 27/Junio
    Fecha de entrega: 08/Julio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;

namespace BO
{
    public class Monedas_BO
    {
        public void vInsertarUsuario(Usuarios_Entity usuario)
        {
            Usuarios_DAL usuarioinsert = new Usuarios_DAL();
            usuarioinsert.vInsertUsuario(usuario);
        }

        public void vModificarUsuario(Usuarios_Entity usuario)
        {
            Usuarios_DAL usuarioupdate = new Usuarios_DAL();
            usuarioupdate.vModificarUsuario(usuario);
        }

        public void vEliminarUsuario(Usuarios_Entity usuario)
        {
            Usuarios_DAL usuariodelete = new Usuarios_DAL();
            usuariodelete.vEliminarUsuario(usuario);
        }

        public DataTable vConsultaUsuarios()
        {
            DataTable dtusuarios;
            Usuarios_DAL usuarioconsulta = new Usuarios_DAL();
            dtusuarios = usuarioconsulta.vConsultarUsuario();
            return dtusuarios;

        }

        public DataTable vConsultaFiltro(Usuarios_Entity usuario)
        {
            DataTable dtUsuarios;
            Usuarios_DAL usuarioconsultafiltro = new Usuarios_DAL();
            dtUsuarios = usuarioconsultafiltro.vConsultarFiltro(usuario);
            return dtUsuarios;
        }

    }
}
