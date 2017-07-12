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
    // Comentarios : Envia a Inventarios los productos de una Solicitud de Transporte listos para ingresar

    public class Vehiculo_BO
    {
        public void insertarVhcBO(vehiculo_Entity vhc)
        {
            Vehiculo_DAL vhcInsert = new Vehiculo_DAL();
            vhcInsert.insertaVehiculo(vhc);
        }

        public void actualizaVehiculoBO(vehiculo_Entity vhc)
        {
            Vehiculo_DAL actualiza = new Vehiculo_DAL();
            actualiza.actualizaVehiculo(vhc);
        }

        public DataTable verTodosVehiculos(vehiculo_Entity vh)
        {
            DataTable dt = new DataTable();
            Vehiculo_DAL vhc = new Vehiculo_DAL();
            dt = vhc.verVehiculos(vh);
            return dt;
        }

       public vehiculo_Entity verUno(int codigo)
        {
            vehiculo_Entity vehiculo = new vehiculo_Entity();
            Vehiculo_DAL vhc = new Vehiculo_DAL();
            vehiculo._cod_vehiculo = codigo;
            return vhc.verVehiculo(codigo);
        }

       #region Seguimiento Asignacion ST
       public DataTable verVehiculosDisponibles(vehiculo_Entity vh)
       {
           DataTable dt = new DataTable();
           Vehiculo_DAL vhc = new Vehiculo_DAL();
           dt = vhc.VehiculosDisponiblesST(vh);
           return dt;
       }

       #endregion

       #region Funciones y Metodos
       public DataTable verTipoVH()
        {
            DataTable dt = new DataTable();
            Vehiculo_DAL vh = new Vehiculo_DAL();
            dt = vh.verTipoVehiculo();
            //SolicitudTransporte_DAL tipo = new SolicitudTransporte_DAL();
            return dt;
        }
        #endregion
    }
}
