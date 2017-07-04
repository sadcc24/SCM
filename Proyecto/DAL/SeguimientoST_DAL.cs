using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    class SeguimientoST_DAL
    {
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        // MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        #region Bitacora
        public DataTable verBitacora(SolicitudTransporte_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT B.descripcion as DESCRIPCION, B.fecha AS FECHA, EST.nombreestadost AS ESTADO " +
                                    "FROM BITACORATRANSPORTE B " +
                                    "JOIN SOLICITUDTRANSPORTE ST ON B.idsolicitud = ST.idsolicitud " +
                                    "LEFT JOIN USUARIO_1 U ON B.idusuario = U.codusuario " +
                                    "LEFT JOIN ESTADOSOLICITUDTRANS EST ON B.idestadost = EST.idestadost " +
                                    "WHERE B.idsolicitud = " + st.idSolicitud);
            return dtRegistros;
        }

        #endregion
    }
}
