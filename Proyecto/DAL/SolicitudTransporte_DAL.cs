using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Data;
using Entity;

namespace DAL
{
    public class SolicitudTransporte_DAL
    {
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");

        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        //MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017V1", @"DESKTOP-F4L56EU\SQLEXPRESS");


        #region Encabezado Solicitud de Transporte
        public void insertaEncabezadoST(SolicitudTransporte_Entity encabezado)
        {
            cnn.insertSQL("INSERT INTO SOLICITUDTRANSPORTE(notas, idtiposolict, idestadost, idempleado, codusuario, idrol, idempresa) " +
                        "VALUES('"+encabezado.Notas+"', "+encabezado.idTipoSolicitud+", 1, 1, 1, 1, 1)");

            DataTable st = new DataTable();
            int stcodigo;
            st = cnn.getSQL("SELECT MAX(idsolicitud) as codigo FROM SOLICITUDTRANSPORTE");
            
            foreach (DataRow row in st.Rows)
            {
                foreach (DataColumn column in st.Columns)
                {
                    stcodigo = Convert.ToInt32(row["codigo"]);
                    insertaCreacionBitacora(stcodigo);
                }
            }
            /*
             * if (dt.Rows.Count > 0) 
                    {
                    DataRow row = dt.Rows[0];

                    lbl_name = row["name"].ToString();
                    lbl_gender = row["gender"].ToString();
                    lbl_contact = row["contactno"].ToString();
                    }*/
        }

        public void insertaCreacionBitacora(int id)
        {
            cnn.insertSQL("INSERT INTO BITACORATRANSPORTE(idusuario, idsolicitud, descripcion, idestadost) " +
                            " VALUES(1, " + id + ", 'Creacion de la Solicitud', 1)");
        }

        //Funcion de Actualizar
        public void actualizaST(SolicitudTransporte_Entity st)
        {
            cnn.updateSQL("UPDATE SOLICITUDTRANSPORTE " +
                            " SET notas = '"+ st.Notas +"'," +
                            " idtiposolict = "+ st.idTipoSolicitud +
                            " WHERE idsolicitud = " + st.idSolicitud );

            cnn.insertSQL("INSERT INTO BITACORATRANSPORTE(idusuario, idsolicitud, descripcion, idestadost) " +
                            " VALUES(1, " + st.idSolicitud + ", 'Actualizacion de la Solicitud', 1)");
        }

        public void eliminaST(SolicitudTransporte_Entity st)
        {
            cnn.updateSQL("UPDATE SOLICITUDTRANSPORTE " +
                            " SET activo = 0 WHERE idsolicitud = " + st.idSolicitud);
        }

        //Muestra todas las solicitudes
        public DataTable verST()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idsolicitud AS CODIGO_SOLICITUD, notas as NOTAS, fechasolicitud as FECHA_DE_SOLICITUD, costoestimado as COSTO_ESTIMADO, " +
                                    " TS.nombretipost AS TIPO_SOLICITUD, EST.nombreestadost AS ESTADO_SOLICITUD " +
                                    " FROM SOLICITUDTRANSPORTE ST " +
                                    " JOIN ESTADOSOLICITUDTRANS EST ON ST.idestadost = EST.idestadost" +
                                    " JOIN TIPOSOLICTRANS TS ON ST.idtiposolict = TS.idtiposolict " +
                                    " WHERE ST.activo = 1 ");
            return dtRegistros;
        }

        //Muestra las solicitudes segun filtro
        public DataTable verST_Single(SolicitudTransporte_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idsolicitud AS CODIGO_SOLICITUD, notas as NOTAS, fechasolicitud as FECHA_DE_SOLICITUD, costoestimado as COSTO_ESTIMADO, " +
                              " TS.nombretipost AS TIPO_SOLICITUD, EST.nombreestadost AS ESTADO_SOLICITUD " +
                              " FROM SOLICITUDTRANSPORTE ST " +
                              " JOIN ESTADOSOLICITUDTRANS EST ON ST.idestadost = EST.idestadost " +
                              " JOIN TIPOSOLICTRANS TS ON ST.idtiposolict = TS.idtiposolict " +
                              " WHERE ST.activo = 1 AND idsolicitud = " + st.idSolicitud);
           return dtRegistros;
        }

        //Muestra solamente una solicitud segun el click en el gridview para mostrarlo en el form especifico
        public SolicitudTransporte_Entity getSingle_ST(SolicitudTransporte_Entity idst)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            DataTable dtRegistro = new DataTable();
            try
            {
                dtRegistro = cnn.getSQL("SELECT  ST.idsolicitud, ST.notas, CAST(ST.fechasolicitud as DATE) as fecha1, CAST(ST.fechadesalida as DATE) as fecha2, CAST(ST.fecharegreso as DATE) as fecha3, ST.costoestimado," +
                    " ST.idtiposolict, ST.idestadost, ST.idempresa, EST.nombreestadost, TS.nombretipost " +
                    " FROM SOLICITUDTRANSPORTE ST " +
                    " JOIN ESTADOSOLICITUDTRANS EST ON ST.idestadost = EST.idestadost " +
                    " JOIN TIPOSOLICTRANS TS ON ST.idtiposolict = TS.idtiposolict " +
                    " WHERE ST.activo = 1 AND ST.idsolicitud = " + idst.idSolicitud);

                foreach (DataRow row in dtRegistro.Rows)
                {
                    foreach (DataColumn column in dtRegistro.Columns)
                    {

                        st.NombreEstado = row["nombreestadost"].ToString();
                        st.idTipoSolicitud = Convert.ToInt32(row["idtiposolict"]);
                        st.idSolicitud = Convert.ToInt32(row["idsolicitud"]);
                        st.Notas = row["notas"].ToString();
                        st.FechaSolicitud = row["fecha1"].ToString();
                        st.FechaSalida = row["fecha2"].ToString();
                        st.FechaRegreso = row["fecha3"].ToString();
                        st.CostoEstimado = Convert.ToDecimal(row["costoestimado"].ToString());
                       
                        
                        
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

       
        #region Detalle de la Solicitud de Transporte
        public void insertaDetalleST(Detalle_ST_Entity detalle)
        {
            
            cnn.insertSQL("INSERT INTO DETALLE_SOLIC_TRANSPORTE(idproducto, idsolicitud, cantidad)" +
                    "VALUES(" + detalle.idProducto + ", " + detalle.idSolicitud + ", " + detalle.Cantidad + ")");
           
        }

        public void actualizaDetalleST(Detalle_ST_Entity dt)
        {
            
            cnn.updateSQL("UPDATE DETALLE_SOLIC_TRANSPORTE " +
                            " SET cantidad = " + dt.Cantidad +
                            " WHERE idsolicitud = " + dt.idSolicitud +
                            " AND idProducto = " + dt.idProducto);
           
        }

        public void eliminaDetalleST(Detalle_ST_Entity dt)
        {
            
            cnn.deleteSQL("DELETE FROM DETALLE_SOLIC_TRANSPORTE " +
                            " WHERE idsolicitud = " + dt.idSolicitud +
                            " AND idProducto = " + dt.idProducto);
            

        }

        public DataTable verDetalleST(SolicitudTransporte_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT DST.idsolicitud AS CODIGO_SOLICITUD, DST.idproducto as CODIGO_PRODUCTO, P.descripcion as PRODUCTO," +
                                       " DST.cantidad AS CANTIDAD_ASIGNADA " +
                                       " FROM DETALLE_SOLIC_TRANSPORTE DST " +
                                       " JOIN PRODUCTO P ON DST.idproducto = P.idproducto " +
                                     "WHERE DST.idsolicitud = " + st.idSolicitud);
            return dtRegistros;
        }

        public DataTable verProductos(int tpbusqueda)
        {
            DataTable dtProducto = new DataTable();
            //, TP.descripcion AS TIPO_PRODUCTO, P.tamano AS TAMANO, P.peso AS PESO, P.precio AS PRECIO
            dtProducto = cnn.getSQL(" SELECT P.idproducto AS CODIGO, P.descripcion AS PRODUCTO, P.cantidad AS CANTIDAD " +
                                    " FROM PRODUCTO P " +
                                    " JOIN TIPOPRODUCTO TP ON P.idtipoproducto = TP.idtipoproducto " +
                                    " WHERE P.idproducto = isnull(null, P.idproducto ) " +
                                    " AND P.descripcion like isnull('%%', P.descripcion)");
            return dtProducto;
        }

        #endregion

        #region BITACORA SEGUIMIENTO
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
        #endregion

        #region CargaCombobox
        public DataTable verEstadosST()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM ESTADOSOLICITUDTRANS");
            return dtRegistros;
        }

        public DataTable verTipoST()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM TIPOSOLICTRANS");
            return dtRegistros;
        }
        #endregion
    }
}
