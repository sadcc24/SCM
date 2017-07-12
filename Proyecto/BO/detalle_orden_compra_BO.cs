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
   public class detalle_orden_compra_BO
    {
        public void insertDetalle(detalle_orden_compra_Entity prov)
        {
            try
            {
               detalle_orden_compra_DAL proveedor = new detalle_orden_compra_DAL();
                proveedor.insertdetalle(prov);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verDetalle(int orden)
        {
            DataTable dt = new DataTable();
            detalle_orden_compra_DAL prov = new detalle_orden_compra_DAL();
            dt = prov.verDetalle(orden);
            return dt;
        }

        public DataTable getProductos(int prod, int prove)
        {
            DataTable dt = new DataTable();
            detalle_orden_compra_DAL prov = new detalle_orden_compra_DAL();
            dt = prov.getProductos(prod,prove);
            return dt;
        }


    }
}
