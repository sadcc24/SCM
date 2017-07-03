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
   public class estado_solicitud_BO
    {
        public void insertEstado(estado_solicitud_Entity est)
        {
            try
            {
                estado_solicitud_DAL estado = new estado_solicitud_DAL();
                estado.insertestado(est);
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verEstados()
        {
            DataTable dt = new DataTable();
            estado_solicitud_DAL est = new estado_solicitud_DAL();
            dt = est.verEstados();
            return dt;
        }

        public void updateEstados(estado_solicitud_Entity est)
        {
            try
            {
                estado_solicitud_DAL estado = new estado_solicitud_DAL();
                estado.updateEstados(est);
            }
            catch (Exception ex)
            {

            }
        }

        public void deleteEstados(estado_solicitud_Entity est)
        {
            try
            {
                estado_solicitud_DAL estado = new estado_solicitud_DAL();
                estado.deleteEstados(est);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
