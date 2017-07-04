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
   public class tipo_trayecto_BO
    {
        public void insertTipo(tipo_trayecto_Entity tip)
        {
            try
            {
                tipo_trayecto_DAL tipo = new tipo_trayecto_DAL();
                tipo.inserttipotrayecto(tip);
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            tipo_trayecto_DAL tip = new tipo_trayecto_DAL();
            dt = tip.verTipos();
            return dt;
        }

        public void updateTipo(tipo_trayecto_Entity tip)
        {
            try
            {
                tipo_trayecto_DAL tipo = new tipo_trayecto_DAL();
                tipo.updatetipos(tip);
            }
            catch (Exception ex)
            {

            }
        }

        public void deleteTipo(tipo_trayecto_Entity tip)
        {
            try
            {
                tipo_trayecto_DAL tipo = new tipo_trayecto_DAL();
                tipo.deletetipo(tip);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
