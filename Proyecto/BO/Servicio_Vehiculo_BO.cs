using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using DAL;

namespace BO
{
    // Programador : Dennys Choy
    // Analista : Dennys Choy
    // Fecha : 08-07-22017
    // Comentarios : 

    public class Servicio_Vehiculo_BO
    {
        public void guardarServicio(Servicio_Vehiculo_Entity st)
        {
            Servicio_Vehiculo_DAL guardar = new Servicio_Vehiculo_DAL();
            guardar.insertarServicio(st);
        }

        public void actualizarServicio(Servicio_Vehiculo_Entity st)
        {
            Servicio_Vehiculo_DAL guardar = new Servicio_Vehiculo_DAL();
            guardar.actualizarServicio(st);
        }

        public void eliminarServicio(int st)
        {
            Servicio_Vehiculo_DAL guardar = new Servicio_Vehiculo_DAL();
            guardar.eliminarServicio(st);
        }

        public Servicio_Vehiculo_Entity verServicio(int codigo)
        { 
            Servicio_Vehiculo_Entity sve = new Servicio_Vehiculo_Entity();
            Servicio_Vehiculo_DAL veruno = new Servicio_Vehiculo_DAL();
            return veruno.verUnServicio(codigo);
        }

        public DataTable verTodosServicios(int st)
        {
            DataTable dt = new DataTable();
            Servicio_Vehiculo_DAL stv = new Servicio_Vehiculo_DAL();
            dt = stv.verTodoServicios(st);
            return dt;
        }

        public DataTable verTipoServicio()
        {
            DataTable dt = new DataTable();
            Servicio_Vehiculo_DAL stv = new Servicio_Vehiculo_DAL();
            dt = stv.verTiposServicios();
            return dt;
        }
  
    }
}
