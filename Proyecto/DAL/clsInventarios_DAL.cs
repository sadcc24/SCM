using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;


namespace DAL
{
 public   class clsInventarios_DAL
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public DataTable dtFacturasPendientes(clsInventarios_Entity facturas)
        {
            DataTable dtFacturas;
            dtFacturas = cnn.getSQL("SELECT  [idfactura]  AS  ID ,[corrfactura] AS Correlativo ,[idserie] as Serie ,[total] as Total,[saldo] as Saldo,[fecha] as Fecha,[idproveedor] as Proveedor,[idbodega] as Bodega,[idmovimiento] as [ID MOVIMIENTO] FROM [SAD2017].[dbo].[FACTURAPROVEEDORES] where saldo != 0 and idbodega = " + facturas.strBodega + " and idproveedor = " + facturas.strIdProveedor);
            return dtFacturas;
        }

        public DataTable dtConsultaUltimaContrasena()
        {
            DataTable dtContrasena;
            dtContrasena = cnn.getSQL("select IsNull(max(idcontrasena), 0)   as id from contrasena");
            return dtContrasena;
        }

        public void vInsertEncabezadoContrasena(clsInventarios_Entity contrasena)
        {
            cnn.insertSQL("INSERT INTO CONTRASENA (idproveedor,idsede,idestadocontrasena) values ("+
                contrasena.strIdProveedor         
                + ",(SELECT s.idsede FROM BODEGA B INNER JOIN EMPRESA EM ON B.idempresa = em.idempresa INNER JOIN SEDE S  ON em.idsede = s.idsede where b.idbodega = " + contrasena.strBodega + "),1)");
        }


        public void vInsertaDetalleContrasena(clsInventarios_Entity contrasena)
        {
            cnn.insertSQL("INSERT INTO DETALLECONTRASENA (idfactura,idcontrasena,fecha,monto) values (" + contrasena.strIdFactura + "," + contrasena.strIdContrasena + ",(SELECT GETDATE())," + contrasena.strmonto + ")");
            cnn.updateSQL("UPDATE [dbo].[FACTURAPROVEEDORES] SET SALDO = 0  WHERE idfactura =" + contrasena.strIdFactura);

        }

    }
}
