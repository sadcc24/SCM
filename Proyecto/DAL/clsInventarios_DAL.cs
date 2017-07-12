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
        // MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        // Comentarios : Consultar Facturas con estado 1
        public DataTable dtFacturasPendientes(clsInventarios_Entity facturas)
        {
            DataTable dtFacturas;
            dtFacturas = cnn.getSQL("SELECT  [idfactura]  AS  ID ,[corrfactura] AS Correlativo ,[idserie] as Serie ,[total] as Total,[saldo] as Saldo,[fecha] as Fecha,[idproveedor] as Proveedor,[idbodega] as Bodega,[idmovimiento] as [ID MOVIMIENTO], idestadofactura as Estado FROM [dbo].[FACTURAPROVEEDORES] where idestadofactura = 1 and idbodega = " + facturas.strBodega + " and idproveedor = " + facturas.strIdProveedor);
            return dtFacturas;
        }
        // Comentarios : Consultar Ultima contraseña
        public DataTable dtConsultaUltimaContrasena()
        {
            DataTable dtContrasena;
            dtContrasena = cnn.getSQL("select IsNull(max(idcontrasena), 0)   as id from contrasena");
            return dtContrasena;
        }
        // Comentarios: insertar encabezado contraseña
        public void vInsertEncabezadoContrasena(clsInventarios_Entity contrasena)
        {
            cnn.insertSQL("INSERT INTO CONTRASENA (idproveedor,idsede,idestadocontrasena) values ("+
                contrasena.strIdProveedor         
                + ",(SELECT s.idsede FROM BODEGA B INNER JOIN EMPRESA EM ON B.idempresa = em.idempresa INNER JOIN SEDE S  ON em.idsede = s.idsede where b.idbodega = " + contrasena.strBodega + "),1)");
        }

        // Comentarios : insertar detalle contraseña
        public void vInsertaDetalleContrasena(clsInventarios_Entity contrasena)
        {
            cnn.insertSQL("INSERT INTO DETALLECONTRASENA (idfactura,idcontrasena,fecha,monto) values (" + contrasena.strIdFactura + "," + contrasena.strIdContrasena + ",(SELECT GETDATE())," + contrasena.strmonto + ")");
            cnn.updateSQL("UPDATE [dbo].[FACTURAPROVEEDORES] SET idestadofactura = 2  WHERE idfactura =" + contrasena.strIdFactura);

        }

        // Comentario: Consultar Cuentas Contables
        public DataTable verCuentaContable()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT * FROM CUENTACONTABLE");
            return dt;
        }

    }
}
