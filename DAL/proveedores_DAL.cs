using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class proveedores_DAL
    {
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");

        public void insertproveedor(proveedores_Entity prov)
        {
            try
            {
                cnn.insertSQL("INSERT INTO Proveedor (nombre_proveedor, direccion, telefono, nit, activo)values('" + prov.nombre_proveedor +"','" + prov.direccion +"'," + prov.telefono + ",'" + prov.nit + "','" + prov.activo + "')");
                
            } catch (Exception ex)
            {

            }
        }

        public DataTable verProveedores()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idproveedor as Codigo, nombre_proveedor as Nombre, direccion as Direccion, telefono as Telefono, nit as NIT FROM Proveedor where activo=1");
            return dt;
        }

        public void updateProveedores(proveedores_Entity prov)
        {
            try
            {
                cnn.updateSQL("UPDATE Proveedor SET nombre_proveedor='" + prov.nombre_proveedor + "', direccion='" + prov.direccion + "', telefono=" + prov.telefono + ", nit='" + prov.nit + "' WHERE idproveedor = " + prov.id_proveedor + "");

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteProveedores(proveedores_Entity prov)
        {
            try
            {
                cnn.updateSQL("UPDATE Proveedor SET activo=0 WHERE idproveedor='" + prov.id_proveedor + "'");
            }
            catch (Exception ex)
            {

            }
        }

    }
}
