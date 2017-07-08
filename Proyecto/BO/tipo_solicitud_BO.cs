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
   public class tipo_solicitud_BO
    {
        public void insertTipo(tipo_solicitud_Entity tip)
        {
            try
            {
                tipo_solicitud_DAL tipo = new tipo_solicitud_DAL();
                tipo.inserttiposolicitud(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            tipo_solicitud_DAL tip = new tipo_solicitud_DAL();
            dt = tip.verTipos();
            return dt;
        }

        public void updateTipo(tipo_solicitud_Entity tip)
        {
            try
            {
                tipo_solicitud_DAL tipo = new tipo_solicitud_DAL();
                tipo.updatetipos(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteTipo(tipo_solicitud_Entity tip)
        {
            try
            {
                tipo_solicitud_DAL tipo = new tipo_solicitud_DAL();
                tipo.deletetipo(tip);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
