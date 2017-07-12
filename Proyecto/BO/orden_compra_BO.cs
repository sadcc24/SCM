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
   public class orden_compra_BO
    {
        public void insertOC(orden_compra_Entity prov)
        {
            try
            {
                orden_compra_DAL proveedor = new orden_compra_DAL();
                proveedor.insertoc(prov);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verProveedor(int sede)
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verProveedor(sede);
            return dt;
        }

        public DataTable verBodega(int empresa)
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verBodega(empresa);
            return dt;
        }

        public DataTable verId()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verId();
            return dt;
        }

        public DataTable verCentroCosto()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verCentroCosto();
            return dt;
        }

        public DataTable verEstado()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verEstado();
            return dt;
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verTipo();
            return dt;
        }

        public DataTable verMoneda()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verMoneda();
            return dt;
        }

        public DataTable verCuentaContable()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verCuentaContable();
            return dt;
        }

        public DataTable verOC()
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verOC();
            return dt;
        }

        public void deleteOC(orden_compra_Entity prov)
        {
            try
            {
                orden_compra_DAL proveedor = new orden_compra_DAL();
                proveedor.deleteOC(prov);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verCuentaxPagar(int prove)
        {
            DataTable dt = new DataTable();
            orden_compra_DAL prov = new orden_compra_DAL();
            dt = prov.verCuentasxPagar(prove);
            return dt;
        }
    }
}
