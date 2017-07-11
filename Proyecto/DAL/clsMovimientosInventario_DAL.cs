using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class clsMovimientosInventario_DAL
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        MRP_BD cnn = Globales.cnn;

        // Comentarios : Consultar existencia de producto por  bodega
        public DataTable vConsultarExistencia(clsMovimientosInventario_Entity existencia)
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT CANTIDAD from existencia where idproducto = " + existencia.strIdProducto + " AND idbodega = " + existencia.strIdBodega);
            return dtBodega;
        }
        #region "PROMEDIO COSTO"
        public DataTable vConsultarExistenciaProductoGeneral(clsMovimientosInventario_Entity existencia)
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT SUM(CANTIDAD) from existencia where idproducto = " + existencia.strIdProducto);
            return dtBodega;
        }

        public DataTable vConsultarCostoProducto(clsMovimientosInventario_Entity existencia)
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT costo FROM PRODUCTO WHERE idproducto = " + existencia.strIdProducto);
            return dtBodega;
        }

        #endregion

        // Comentarios : Modificar existencia
        public void vModificarExistencia(clsMovimientosInventario_Entity existencia)
        {
            cnn.updateSQL("UPDATE EXISTENCIA SET CANTIDAD = (SELECT CANTIDAD from existencia where idproducto = " + existencia.strIdProducto + " AND idbodega = "+ existencia.strIdBodega +") + "+existencia.strCantidad+" WHERE idproducto = "+existencia.strIdProducto +"  AND idbodega = " + existencia.strIdBodega);
        }

        // Comentarios : Modificar costo por promedio al comprar
        public void vModificarCostoProducto(clsMovimientosInventario_Entity existencia)
        {
            cnn.updateSQL("UPDATE PRODUCTO SET costo = "+existencia.strCosto + " WHERE idproducto = " + existencia.strIdProducto);
        }

        // Comentarios : Insertar EncabezadO Movimiento de Inventario
        public void vInsertarMovimientoInventario(clsMovimientosInventario_Entity mov)
        {
            cnn.insertSQL("INSERT INTO [dbo].[MOVIMIENTOSINVENTARIO] (idbodega,fecha,idtipomovimiento,idmoneda,docref) VALUES("
                + mov.strIdBodega  + ",'" + mov.strFecha + "'," + mov.strIdTipoMovimiento + "," + mov.strIdMoneda + ",'" + mov.strDocRef + "')");
        }
        // Comentarios : Insertar Detalle Movimiento de Inventario
        public void vInsertarDetalleMovimientoInventario(clsMovimientosInventario_Entity mov)
        {
            cnn.insertSQL("INSERT INTO[dbo].[DETALLEMOVIMIENTOINVENTARIO] (idbodega,idmovimiento,idproducto,cantidad,costo) VALUES("
                + mov.strIdBodega + "," + mov.strIdMovimiento + "," + mov.strIdProducto + "," + mov.strCantidad + "," + mov.strCosto + ")");
        }

        // Comentarios : Consultar operacion  TIPO DE MI

        public DataTable vConsultarOperacion(clsMovimientosInventario_Entity mov)
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT OPERACION FROM TIPOMOVIMIENTO WHERE IDTIPOMOVIMIENTO =" + mov.strIdTipoMovimiento);
            return dtBodega;
        }
        // Comentarios : ULTIMO ID DE MI
        public DataTable dtConsultarUltimoMovimiento()
        {
            DataTable dtContrasena;
            dtContrasena = cnn.getSQL("select IsNull(max(idmovimiento), 0)   as id from MOVIMIENTOSINVENTARIO");
            return dtContrasena;
        }

    }
}
