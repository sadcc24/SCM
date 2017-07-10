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
   public class proveedores_BO
    {

        public void insertProveedor(proveedores_Entity prov)
        {
            try
            {
                proveedores_DAL proveedor = new proveedores_DAL();
                proveedor.insertproveedor(prov);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verProveedores()
        {
            DataTable dt = new DataTable();
            proveedores_DAL prov = new proveedores_DAL();
            dt = prov.verProveedores();
            return dt;
        }

        public DataTable verSedes()
        {
            DataTable dt = new DataTable();
            proveedores_DAL prov = new proveedores_DAL();
            dt = prov.verSedes();
            return dt;
        }

        public void updateProveedores(proveedores_Entity prov)
        {
            try
            {
                proveedores_DAL proveedor = new proveedores_DAL();
                proveedor.updateProveedores(prov);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteProveedores(proveedores_Entity prov)
        {
            try
            {
                proveedores_DAL proveedor = new proveedores_DAL();
                proveedor.deleteProveedores(prov);
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

    }
}
