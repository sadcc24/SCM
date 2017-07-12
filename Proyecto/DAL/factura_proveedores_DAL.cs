using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class factura_proveedores_DAL
    {

        // Programador : PAMELA SELMAN Y JOSÉ ANDRES CHAJON
        // Analista : PAMELA SELMAN Y JOSÉ ANDRES CHAJON
        // Comentarios :
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        // Comentarios : INSERTAR FACTURA
        public void insertfactura(factura_proveedores_Entity fac)
        {
            try
            {
                cnn.insertSQL("INSERT INTO FACTURAPROVEEDORES([corrfactura],[idserie],[total],[saldo],[fecha],[idbodega],[idproveedor],[idmovimiento],[idestadofactura])VALUES('" + fac.corrfactura + "','" + fac.id_serie + "'," + fac.total + "," + fac.saldo + ",'" + fac.fecha + "'," + fac.id_bodega + "," + fac.id_proveedor + ", " + fac.id_movimiento + ", " + fac.id_estado_factura + ")");

            }
            catch (Exception ex)
            {

            }
        }
        // Comentarios : VER FACTURAS
        public DataTable verFacturas(factura_proveedores_Entity fac )
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT  idfactura as ID, corrfactura as Correlativo, total as Total, fecha as Fecha, idProveedor as Proveedor, idbodega as Bodega, idmovimiento as IDMOV,idserie as IDSerie from [FACTURAPROVEEDORES] where idproveedor = "+ fac.id_proveedor+" and idbodega = "+ fac.id_bodega +" and idestadofactura = " + fac.id_estado_factura);
            return dt;
        }

        // Comentarios: CONSULTAR OC AUTORIZADAS
        public DataTable verOC(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT IDORDENCOMPRA,OBSERVACION,TOTAL,IDPROVEEDOR,IDMONEDA,IDEMPRESA,IDBODEGA FROM ORDENCOMPRA where idproveedor = " + fac.id_proveedor + " and idbodega = " + fac.id_bodega + " and idestado = " + fac.id_estado_factura);
            return dt;
        }

        // Comentarios : VER DETALLE FACTURA ( DETALLE MOV INV)
        public DataTable detalleFactura(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("select idproducto, cantidad, costo, precio from DETALLEMOVIMIENTOINVENTARIO where idmovimiento = "+ fac.id_movimiento +" and idbodega = " + fac.id_bodega);
            return dt;
        }

        public DataTable detalleOC(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("select idproducto, cantidad, precio_unitario as costo, 0 as precio from DETALLEORDENCOMPRA where idordencompra = " +  fac.strOC);
            return dt;
        }


        	
        // Comentarios : ELIMINAR FACTURA
        public void deletefactura(factura_proveedores_Entity fac)
        {
            try
            {
                cnn.updateSQL("DELETE FACTURAPROVEEDORES WHERE idfactura='" + fac.id_factura + "'");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
