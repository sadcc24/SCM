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
   public class estado_contrasena_BO
    {
        public void insertEstado(estado_contrasena_Entity est)
        {
            try
            {
                estado_contrasena_DAL estado = new estado_contrasena_DAL();
                estado.insertestado(est);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verEstados()
        {
            DataTable dt = new DataTable();
            estado_contrasena_DAL est = new estado_contrasena_DAL();
            dt = est.verEstados();
            return dt;
        }

        public void updateEstados(estado_contrasena_Entity est)
        {
            try
            {
                estado_contrasena_DAL estado = new estado_contrasena_DAL();
                estado.updateEstados(est);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();

            }
        }

        public void deleteEstados(estado_contrasena_Entity est)
        {
            try
            {
                estado_contrasena_DAL estado = new estado_contrasena_DAL();
                estado.deleteEstados(est);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
