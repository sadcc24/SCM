using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;


namespace DAL
{
   public class orden_compra_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertoc(orden_compra_Entity oc)
        {
            try
            {
                cnn.insertSQL("INSERT INTO ORDENCOMPRA([observacion],[total],[usuario_registro],[fecha_creacion],[idsede],[idempresa],[idcentro],[idbodega],[idproveedor],[idmoneda],[idestado],[idtipooc],[idAutorizacion],[fecha_vencimiento],[idCuenta])VALUES('" + oc.observaacion + "'," + oc.total + ",'" + oc.usuario + "','" + oc.fecha_creacion + "'," + oc.id_sede + "," + oc.id_empresa + "," + oc.id_centro +"," + oc.id_bodega + "," + oc.id_proveedor + ", " + oc.id_moneda + ", " + oc.id_estado + ", " + oc.id_tipo_oc + "," + oc.id_documento + ",'" + oc.fecha_vencimiento + "'," + oc.id_cuenta + ")");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verMoneda()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM MONEDA");
            return dt;
        }

        public DataTable verEstado()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM ESTADOORDEN");
            return dt;
        }

        public DataTable verCuentaContable()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM CUENTACONTABLE");
            return dt;
        }

        public DataTable verId()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("select top 1 idordencompra from ORDENCOMPRA order by idordencompra desc");
            return dt;
        }

        public DataTable verTipo()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM TIPOOC");
            return dt;
        }

        public DataTable verBodega(int empresa)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM BODEGA WHERE idempresa = " + empresa + "");
            return dt;
        }

        public DataTable verProveedor(int sede)
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM PROVEEDOR WHERE idsede = " + sede + "");
            return dt;
        }

        public DataTable verCentroCosto()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM CENTROCOSTO");
            return dt;
        }

        public DataTable verOC()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idordencompra as Codigo, observacion as Descripcion, usuario_registro as Usuario, fecha_creacion as Fecha, total as Total FROM ORDENCOMPRA");
            return dt;
        }


        public void deleteOC(orden_compra_Entity oc)
        {
            try
            {
                cnn.updateSQL("DELETE ORDENCOMPRA WHERE idordencompra='" + oc.id_orden_compra + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
