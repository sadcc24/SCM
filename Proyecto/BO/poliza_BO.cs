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
   public class poliza_BO
    {
        public void insertPoliza(poliza_Entity est)
        {
            try
            {
                poliza_DAL estado = new poliza_DAL();
                estado.insertpoliza(est);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        // Comentarios : Consultar ultimo id ingresado de Encabezado MI
        public DataTable dtConsultarUltimaPoliza()
        {
            DataTable dtProducto;
            poliza_DAL exist = new poliza_DAL();
            dtProducto = exist.dtConsultarUltimaPoliza();
            return dtProducto;
        }
    }
}
