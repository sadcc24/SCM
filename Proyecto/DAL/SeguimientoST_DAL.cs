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
    // Fecha : 08-07-22017
    // Comentarios : Envia a Inventarios los productos de una Solicitud de Transporte listos para ingresar

    class SeguimientoST_DAL
    {
        MRP_BD cnn = Globales.cnn;
        // MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");
        //MRP_BD cnn = new MRP_BD("r40usr", "Inter$2013", "SAD2017", "SDESRUTA40");
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
