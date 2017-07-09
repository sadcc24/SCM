using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BO
{
   public class tipo_vehiculo_BO
    {
        public void insertTipo(tipo_vehiculo_Entity tip)
        {
            try
            {
                tipo_vehiculo_DAL tipo = new tipo_vehiculo_DAL();
                tipo.inserttipovehiculo(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            tipo_vehiculo_DAL tip = new tipo_vehiculo_DAL();
            dt = tip.verTipos();
            return dt;
        }

        public void updateTipo(tipo_vehiculo_Entity tip)
        {
            try
            {
                tipo_vehiculo_DAL tipo = new tipo_vehiculo_DAL();
                tipo.updatetipos(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteTipo(tipo_vehiculo_Entity tip)
        {
            try
            {
                tipo_vehiculo_DAL tipo = new tipo_vehiculo_DAL();
                tipo.deletetipo(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
