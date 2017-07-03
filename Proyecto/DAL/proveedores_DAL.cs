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
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertproveedor(proveedores_Entity prov)
        {
            try
            {
                cnn.insertSQL("INSERT INTO PROVEEDOR (nombre_proveedor, direccion, telefono, nit, activo, idsede)values('" + prov.nombre_proveedor +"','" + prov.direccion +"'," + prov.telefono + ",'" + prov.nit + "','" + prov.activo + "'," + prov.id_sede + ")");
                
            } catch (Exception ex)
            {

            }
        }

        public DataTable verProveedores()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idproveedor as Codigo, nombre_proveedor as Nombre, direccion as Direccion, telefono as Telefono, nit as NIT FROM PROVEEDOR where activo=1");
            return dt;
        }

        public DataTable verSedes()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM Sede");
            return dt;
        }

        public void updateProveedores(proveedores_Entity prov)
        {
            try
            {
                cnn.updateSQL("UPDATE PROVEEDOR SET nombre_proveedor='" + prov.nombre_proveedor + "', direccion='" + prov.direccion + "', telefono=" + prov.telefono + ", nit='" + prov.nit + "' WHERE idproveedor = " + prov.id_proveedor + "");

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteProveedores(proveedores_Entity prov)
        {
            try
            {
                cnn.updateSQL("UPDATE PROVEEDOR SET activo=0 WHERE idproveedor='" + prov.id_proveedor + "'");
            }
            catch (Exception ex)
            {

            }
        }

    }
}
