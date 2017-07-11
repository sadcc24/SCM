using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class detalle_orden_compra_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertdetalle(detalle_orden_compra_Entity prov)
        {
            try
            {
                cnn.insertSQL("INSERT INTO DETALLEORDENCOMPRA (cantidad, precio_unitario, total, idordencompra, idproducto)values(" + prov.cantidad + "," + prov.precio_unitario + "," + prov.total + "," + prov.id_orden_compra + "," + prov.id_producto + ")");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable getProductos(int prod, int prov)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("select descripcion from PRODUCTO where idproducto = " + prod + " and idproveedor = " + prov + "");
            return dt;
        }

        public DataTable verDetalle(int orden)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT cantidad as Cantidad, precio_unitario as Precio, total as Total, idordencompra as CodigoOrden, idproducto as Codigo FROM DETALLEORDENCOMPRA where idordencompra= " + orden + "");
            return dt;
        }

        //public void updateOrdenes(detalle_orden_compra_Entity prov)
        //{
        //    try
        //    {
        //        cnn.updateSQL("UPDATE DETALLEORDENCOMPRA SET nombre_proveedor='" + prov.nombre_proveedor + "', direccion='" + prov.direccion + "', telefono=" + prov.telefono + ", nit='" + prov.nit + "' WHERE idproveedor = " + prov.id_proveedor + "");

        //    }
        //    catch (Exception ex)
        //    {
        //        String error = ex.ToString();
        //    }
        //}

        //public void deleteProveedores(proveedores_Entity prov)
        //{
        //    try
        //    {
        //        cnn.updateSQL("UPDATE PROVEEDOR SET activo=0 WHERE idproveedor='" + prov.id_proveedor + "'");
        //    }
        //    catch (Exception ex)
        //    {
        //        String error = ex.ToString();
        //    }
        //}
    }
}
