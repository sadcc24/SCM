using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
namespace DAL
{
    // Programador : Dennys Choy
    // Analista : Dennys Choy
    // Comentarios : Creacion de Encabezado y Detalle de Movimientos de Inventario
    public class Detalle_ST_DAL
    {
        MRP_BD cnn = Globales.cnn;

        #region Encabezado
        public void insertarEncabezadoMovimiento(Detalle_ST_Entity st)
        {
          
            cnn.insertSQL("INSERT INTO MOVIMIENTOSINVENTARIO(idbodega, fecha, idtipomovimiento, idmoneda)" + 
                        " VALUES("+st.idBodega+",   \'"+st.fecha+"\', "+st.idTipoMov+", "+st.idMoneda+")");
        }

        public void actualizaEncabezadoMovimiento(Detalle_ST_Entity st)
        {
            cnn.updateSQL("UPDATE MOVIMIENTOSINVENTARIO SET idbodega = "+st.idBodega+", fecha = \'"+st.fecha+"\', idtipomovimiento = "+st.idTipoMov+", idmoneda = "+st.idMoneda+
                        " WHERE idmovimiento =  " + st.idMovimiento);
        }

        public void eliminarEncabezadoMovimiento(int st)
        {
            cnn.updateSQL("DELETE FROM MOVIMIENTOSINVENTARIO WHERE idmovimiento = " +st);
        }

        public DataTable todosMovimientos(Detalle_ST_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT MI.idmovimiento as CODIGO_MOVIMIENTO, MI.idbodega AS CODIGO_BODEGA, " +
                                       // " CASE ST.idmovimiento WHEN ISNULL(ST.idmovimiento, 0) THEN CAST(st.idsolicitud AS VARCHAR) ELSE 'PENDIENTE' END AS CODIGO_SOLICITUD,  " +
                                        " B.nombre_bodega as NOMBRE_BODEGA, MI.fecha as FECHA_DE_CREACION, TM.descripcion AS TIPO_MOVIMIENTO " +
                                        //" , EST.nombreestadost AS ESTADO_ACTUAL" +
                                        " FROM MOVIMIENTOSINVENTARIO  MI " +
                                        " JOIN BODEGA B ON MI.idbodega = B.idbodega " +
                                        " JOIN TIPOMOVIMIENTO TM ON MI.idtipomovimiento = TM.idtipomovimiento " +
                                        " LEFT JOIN SOLICITUDTRANSPORTE ST ON MI.idmovimiento = ST.idmovimiento " +
                                        " LEFT JOIN ESTADOSOLICITUDTRANS EST ON ST.idestadost = EST.idestadost " +
                                        " WHERE MI.idtipomovimiento = 3 " +
                                        " AND ST.idsolicitud IS NULL  " +
                                        " AND MI.idmovimiento =  CASE " + st.idMovimiento + " WHEN 0 THEN MI.idmovimiento  ELSE " + st.idMovimiento + " END" +
                                        " AND MI.idbodega = CASE " + st.idBodega + " WHEN 0 THEN MI.idbodega   ELSE " + st.idBodega + " END" +
                                        " AND MI.idtipomovimiento =CASE " + st.idTipoMov + " WHEN 0 THEN MI.idtipomovimiento ELSE " + st.idTipoMov + " END " +
                                        " AND (EST.idestadost <> 4 OR EST.idestadost is null) " +
                                        " ORDER BY ST.idmovimiento, MI.fecha ");
            return dtRegistros;
        }

        public Detalle_ST_Entity getSinge_Movimiento(int codigo)
        {
            Detalle_ST_Entity st = new Detalle_ST_Entity();
            DataTable dtRegistro = new DataTable();

            dtRegistro = cnn.getSQL(" SELECT * FROM MOVIMIENTOSINVENTARIO WHERE idmovimiento = " + codigo);
            foreach (DataRow row in dtRegistro.Rows)
            {
                foreach (DataColumn column in dtRegistro.Columns)
                {
                    st.idMovimiento = Convert.ToInt32(row["idmovimiento"]);
                    st.idBodega = Convert.ToInt32(row["idbodega"]);
                    st.fecha = row["fecha"].ToString();
                    st.idTipoMov = Convert.ToInt32(row["idtipomovimiento"]);
                }
            }
            return st;
        }
        #endregion

        #region Detalle

        public DataTable detMovimientos_Todos(int codigo)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT DMI.idmovimiento, DMI.idproducto as CODIGO_PRODUCTO, P.descripcion AS PRODUCTO, DMI.cantidad, B.nombre_bodega " +
                                    " FROM DETALLEMOVIMIENTOINVENTARIO DMI " +
                                    " JOIN MOVIMIENTOSINVENTARIO MI ON DMI.idmovimiento = MI.idmovimiento AND DMI.idbodega = MI.idbodega " +
                                    " JOIN BODEGA B ON DMI.idbodega = B.idbodega " +
                                    " JOIN PRODUCTO P ON DMI.idproducto = P.idproducto " +
                                    " WHERE DMI.idmovimiento = " + codigo);
            return dtRegistros;
        }

        public Detalle_ST_Entity validaExistencia(int producto, int bodega)
        {
            
            DataTable dtRegistros = new DataTable();
            Detalle_ST_Entity st = new Detalle_ST_Entity();
            dtRegistros = cnn.getSQL("SELECT cantidad FROM EXISTENCIA WHERE idbodega = " + bodega + " AND idproducto = " + producto);
            foreach (DataRow row in dtRegistros.Rows)
            {
                foreach (DataColumn column in dtRegistros.Columns)
                {
                    st.Cantidad = Convert.ToInt32(row["cantidad"]);
                }
            }
            return st;
        }
        #endregion
    }
}
