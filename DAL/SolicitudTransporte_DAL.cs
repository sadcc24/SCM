using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    public class SolicitudTransporte_DAL
    {
        MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");

        #region Encabezado Solicitud de Transporte
        public void insertaEncabezadoST(SolicitudTransporte_Entity encabezado)
        {
            cnn.insertSQL("INSERT INTO SOLICITUDTRANSPORTE(notas, fechasolicitud, fechadesalida, fecharegreso, " +
                        "costoestimado, idtiposolict, idestadost, idtipocarga, idempresa, idempleado, codusuario) " +
                        "VALUES('"+encabezado.Notas+"', '"+encabezado.FechaSolicitud+"', '"+encabezado.FechaSalida+"', '"+encabezado.FechaRegreso+"', "+encabezado.CostoEstimado+", 1, 1, 1, 1, 1, 1)");
        }

        public DataTable verST()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idsolicitud AS CODIGO_SOLICITUD, notas as NOTAS, fechasolicitud as FECHA_DE_SOLICITUD, costoestimado as COSTO_ESTIMADO  FROM SOLICITUDTRANSPORTE");
            return dtRegistros;
        }

        public SolicitudTransporte_Entity getSingle_ST(SolicitudTransporte_Entity idst)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            DataTable dtRegistro = new DataTable();
            try
            {
                dtRegistro = cnn.getSQL("SELECT * FROM SOLICITUDTRANSPORTE WHERE idsolicitud = " + idst.idSolicitud);

                foreach (DataRow row in dtRegistro.Rows)
                {
                    foreach (DataColumn column in dtRegistro.Columns)
                    {

                        st.idSolicitud = Convert.ToInt32(row["idsolicitud"]);
                        st.Notas = row["notas"].ToString();
                        st.FechaSalida = row["fechasolicitud"].ToString();
                        st.FechaSolicitud = row["fechadesalida"].ToString();
                        st.FechaRegreso = row["fecharegreso"].ToString();
                        st.CostoEstimado = Convert.ToDecimal(row["costoestimado"].ToString());
                        st.idTipoSolicitud = Convert.ToInt32(row["idtiposolicitud"].ToString());
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return st;

        }




        #endregion



        public void insertaDetalleST(Detalle_ST_Entity detalle)
        {
            cnn.insertSQL("INSERT INTO DETALLE_SOLIC_TRANSPORTE(idproducto, idsolicitud, cantidad)" +
                        "VALUES(" + detalle.idProducto + ", 1, " + detalle.Cantidad + ")");
        }

        
    }
}
