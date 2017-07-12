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
   public class detalle_poliza_BO
    {
        public void insertDetallePoliza(detalle_poliza_Entity est)
        {
            try
            {
                detalle_poliza_DAL estado = new detalle_poliza_DAL();
                estado.insertdetallepoliza(est);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
