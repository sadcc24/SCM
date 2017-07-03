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
   public class tipo_cargamento_BO
    {
        public void insertTipo(tipo_cargamento_Entity tip)
        {
            try
            {
                tipo_cargamento_DAL tipo = new tipo_cargamento_DAL();
                tipo.inserttipocargamento(tip);
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            tipo_cargamento_DAL tip = new tipo_cargamento_DAL();
            dt = tip.verTipos();
            return dt;
        }

        public void updateTipo(tipo_cargamento_Entity tip)
        {
            try
            {
                tipo_cargamento_DAL tipo = new tipo_cargamento_DAL();
                tipo.updatetipos(tip);
            }
            catch (Exception ex)
            {

            }
        }

        public void deleteTipo(tipo_cargamento_Entity tip)
        {
            try
            {
                tipo_cargamento_DAL tipo = new tipo_cargamento_DAL();
                tipo.deletetipos(tip);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
