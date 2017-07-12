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
   public class tipo_orden_BO
    {
        public void insertTipo(tipo_orden_Entity tip)
        {
            try
            {
                tipo_orden_DAL tipo = new tipo_orden_DAL();
                tipo.inserttipoorden(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            tipo_orden_DAL tip = new tipo_orden_DAL();
            dt = tip.verTipos();
            return dt;
        }

        public void updateTipo(tipo_orden_Entity tip)
        {
            try
            {
                tipo_orden_DAL tipo = new tipo_orden_DAL();
                tipo.updatetipos(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteTipo(tipo_orden_Entity tip)
        {
            try
            {
                tipo_orden_DAL tipo = new tipo_orden_DAL();
                tipo.deletetipo(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
