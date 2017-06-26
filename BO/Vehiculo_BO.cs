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
    public class Vehiculo_BO
    {
        public void insertarVhcBO(vehiculo_Entity vhc)
        {
            Vehiculo_DAL vhcInsert = new Vehiculo_DAL();
            vhcInsert.insertaVehiculo(vhc);
        }

        public DataTable verTodosVehiculos()
        {
            DataTable dt = new DataTable();
            Vehiculo_DAL vhc = new Vehiculo_DAL();
            dt = vhc.verVehiculos();
            return dt;
        }

       public vehiculo_Entity verUno(int codigo)
        {
            vehiculo_Entity vehiculo = new vehiculo_Entity();
            Vehiculo_DAL vhc = new Vehiculo_DAL();
            vehiculo._cod_vehiculo = codigo;
            return vhc.verVehiculo(vehiculo);
        }
    }
}
