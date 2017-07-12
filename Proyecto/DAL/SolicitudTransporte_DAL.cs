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

    public class SolicitudTransporte_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //  MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");
        // MRP_BD cnn = new MRP_BD("r40usr", "Inter$2013", "SAD2017", "SDESRUTA40");
    
        
        #region Encabezado Solicitud de Transporte
        //Inserta en el la tabla encabezado SOLICITUDTRANSPORTE y en la bitacora del tracking
        //Funcional
        public void insertaEncabezadoST(SolicitudTransporte_Entity encabezado)
        {
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            cnn.insertSQL("INSERT INTO SOLICITUDTRANSPORTE(notas, idestadost, idempresa, idmovimiento) " +
                        "VALUES('"+encabezado.Notas+"', 1, "+empresa[0]+", "+ encabezado.idMovimiento +")");

            DataTable st = new DataTable();
            int stcodigo, idusuario, idestado, movimiento;
            string nota = "";
            st = cnn.getSQL("SELECT MAX(idsolicitud) as codigo FROM SOLICITUDTRANSPORTE");
            
            foreach (DataRow row in st.Rows)
            {
                foreach (DataColumn column in st.Columns)
                {
                    string[] usuario = Globales.Usuario.CapturarUsuario();
                    stcodigo = Convert.ToInt32(row["codigo"]);
                    nota = "Creacion de la Solicitud";
                    idestado = 1;
                    idusuario = Convert.ToInt32(usuario[0]);
                    movimiento = encabezado.idMovimiento;
                    insertaBitacora(stcodigo, idusuario, nota, idestado, movimiento);
                }
            }

        }

        //Funcion que recibe parametros para insertar en bitacora
        //Funcional
        public void insertaBitacora(int id, int idusuario, string nota, int estado, int movimiento)
        {
            cnn.insertSQL("INSERT INTO BITACORATRANSPORTE(idusuario, idsolicitud, descripcion, idestadost, idmovimiento) " +
                            " VALUES(1, " + id + ", 'Creacion de la Solicitud', 1, " +movimiento+" )");
        }

        //Funcion de Actualizar
        public void actualizaST(SolicitudTransporte_Entity st)
        {
            cnn.updateSQL("UPDATE SOLICITUDTRANSPORTE " +
                            " SET notas = '"+ st.Notas +"'," +
                            " idtiposolict = "+ st.idTipoSolicitud +
                            " WHERE idsolicitud = " + st.idSolicitud );

            string[] usuario = Globales.Usuario.CapturarUsuario();
            cnn.insertSQL("INSERT INTO BITACORATRANSPORTE(idusuario, idsolicitud, descripcion, idestadost) " +
                            " VALUES("+usuario[0]+", " + st.idSolicitud + ", 'Actualizacion de la Solicitud', 1)");
        }

        public void eliminaST(SolicitudTransporte_Entity st)
        {
            cnn.updateSQL("UPDATE SOLICITUDTRANSPORTE " +
                            " SET activo = 0 WHERE idsolicitud = " + st.idSolicitud);
        }

        //Muestra todas las solicitudes en el grid, es el unico para el form buscarSolictudTransporte
        //Funciona
        public DataTable verST(SolicitudTransporte_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            string[] empresa = Globales.Empresa.CapturarEmpresa();
            dtRegistros = cnn.getSQL("SELECT MI.idmovimiento as CODIGO_MOVIMIENTO, " +
                                        " CASE ST.idmovimiento WHEN ISNULL(ST.idmovimiento, 0) THEN CAST(st.idsolicitud AS VARCHAR) ELSE 'PENDIENTE' END AS CODIGO_SOLICITUD,  " +
                                        " B.nombre_bodega as NOMBRE_BODEGA, MI.fecha as FECHA_DE_CREACION, TM.descripcion AS TIPO_MOVIMIENTO, " +
                                        " EST.nombreestadost AS ESTADO_ACTUAL" +
                                        " FROM MOVIMIENTOSINVENTARIO  MI " +
                                        " JOIN BODEGA B ON MI.idbodega = B.idbodega " +
                                        " JOIN TIPOMOVIMIENTO TM ON MI.idtipomovimiento = TM.idtipomovimiento " +
                                        " LEFT JOIN SOLICITUDTRANSPORTE ST ON MI.idmovimiento = ST.idmovimiento " +
                                        " LEFT JOIN ESTADOSOLICITUDTRANS EST ON ST.idestadost = EST.idestadost " +
                                        " WHERE MI.idtipomovimiento = 3 " +
                                        " AND MI.idmovimiento =  CASE " + st.idMovimiento+ " WHEN 0 THEN MI.idmovimiento  ELSE " + st.idMovimiento + " END"  +
                                        " AND MI.idbodega = CASE " + st.idBodega + " WHEN 0 THEN MI.idbodega   ELSE " + st.idBodega + " END"    +
                                        " AND MI.idtipomovimiento =CASE " + st.idTipoMovimiento + " WHEN 0 THEN MI.idtipomovimiento ELSE " + st.idTipoMovimiento + " END " +
                                        " AND (EST.idestadost <> 3 OR EST.idestadost is null) " +
                                        " AND B.idempresa = " +empresa[0]+
                                        " ORDER BY ST.idmovimiento, MI.fecha "); 
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

        //Carga los datos de la Solicitud en el form de Seguimiento
        //Funcional
        public SolicitudTransporte_Entity getSingle_ST(SolicitudTransporte_Entity idst)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            DataTable dtRegistro = new DataTable();
            try
            {
                dtRegistro = cnn.getSQL("SELECT ST.idmovimiento, ST.idsolicitud, ST.notas, ST.fechasolicitud, ST.fechadesalida, ST.fecharegreso, ST.costoestimado," +
                    " ST.idestadost, ST.idempresa, EST.nombreestadost, V.marca AS vehiculo, V.placa as placavehiculo, ST.idtransporte" +
                    " FROM SOLICITUDTRANSPORTE ST " +
                    " JOIN ESTADOSOLICITUDTRANS EST ON ST.idestadost = EST.idestadost " +
                    " LEFT JOIN VEHICULO V ON ST.idtransporte = V.idtransporte " +
                    " WHERE ST.activo = 1 AND (ST.idsolicitud = " + idst.idSolicitud + " OR ST.idmovimiento = " + idst.idMovimiento + ")");
                    

                foreach (DataRow row in dtRegistro.Rows)
                {
                    foreach (DataColumn column in dtRegistro.Columns)
                    {

                        st.NombreEstado = row["nombreestadost"].ToString();
                        st.idSolicitud = Convert.ToInt32(row["idsolicitud"]);
                        st.idMovimiento = Convert.ToInt32(row["idmovimiento"]);
                        st.Notas = row["notas"].ToString();
                        st.FechaSolicitud = row["fechasolicitud"].ToString();
                        st.FechaSalida = row["fechadesalida"].ToString();
                        st.FechaRegreso = row["fecharegreso"].ToString();
                        st.idVehiculo = Convert.ToInt32(row["idtransporte"]);
                        st.idEstado = Convert.ToInt32(row["idestadost"]);
                        //st.CostoEstimado = Convert.ToDecimal(row["costoestimado"].ToString());          
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
            
            //cnn.insertSQL("INSERT INTO DETALLE_SOLIC_TRANSPORTE(idproducto, idsolicitud, cantidad)" +
             //       "VALUES(" + detalle.idProducto + ", " + detalle.idSolicitud + ", " + detalle.Cantidad + ")");
            cnn.insertSQL("INSERT INTO DETALLEMOVIMIENTOINVENTARIO (idbodega, idmovimiento, idproducto, cantidad, precio, costo)" +
            "VALUES(" + detalle.idBodega + ", " + detalle.idMovimiento+ ", "+detalle.idProducto+", " + detalle.Cantidad + " , "+detalle.precio+", "+detalle.costo+")");

            ajustaExistenciasMovimientos(detalle.Cantidad, detalle.idProducto, detalle.idBodega, 1, detalle.CantidadReal);
        }

        public void actualizaDetalleST(Detalle_ST_Entity dt)
        {

            cnn.updateSQL("UPDATE DETALLEMOVIMIENTOINVENTARIO " +
                            " SET cantidad = " + dt.Cantidad +
                            " WHERE idbodega = " + dt.idBodega +
                            " AND idmovimiento = " + dt.idMovimiento +
                            " AND idproducto = " + dt.idProducto);

            ajustaExistenciasMovimientos(dt.Cantidad, dt.idProducto, dt.idBodega, 2, dt.CantidadReal);
        }

        public void eliminaDetalleST(Detalle_ST_Entity dt)
        {

            cnn.deleteSQL("DELETE FROM DETALLEMOVIMIENTOINVENTARIO " +
                            " WHERE idbodega = " + dt.idBodega +
                            " AND idmovimiento = " + dt.idMovimiento +
                            " AND idproducto = " + dt.idProducto);

            ajustaExistenciasMovimientos(dt.Cantidad, dt.idProducto, dt.idBodega, 3, dt.CantidadReal);
        }

        //Suma o resta en exitencias de acuerdo al tipo de movimiento
        public void ajustaExistenciasMovimientos(int cantidad, int producto, int bodega, int tipo, int cantidadReal)
        {
            string ajuste = "";
            switch (tipo)
            {
                case 1:
                    //INSERCION
                    ajuste = string.Format("(cantidad - {0})", cantidad);
                    break;
                case 2:
                    //ACTUALIZACIÓN
                    cnn.updateSQL("UPDATE EXISTENCIA SET cantidad = (cantidad + "+ cantidadReal+ ") " +// ajuste +
                         " WHERE idbodega = " + bodega +
                         " AND idproducto = " + producto);
                    ajuste = string.Format("(cantidad - {0})", cantidad);
                    break;
                case 3:
                    //ELIMINACIÓN
                    ajuste = string.Format("(cantidad + {0})", cantidad);
                    break;
                default:
                    ajuste = "";
                    break;
            }

                cnn.updateSQL("UPDATE EXISTENCIA SET cantidad = " + ajuste +
                            " WHERE idbodega = " + bodega +
                            " AND idproducto = " + producto);
        }

        //Muestra el detalle de los productos de la tabla DETALLEMOVIMIENTOINVENTARIO
        //Funciona
        public DataTable verDetalleST(SolicitudTransporte_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT DMI.idproducto as CODIGO_PRODUCTO, P.descripcion AS PRODUCTO, DMI.cantidad AS CANTIDAD " +
                                        " FROM DETALLEMOVIMIENTOINVENTARIO DMI " +
                                        " JOIN PRODUCTO P ON DMI.idproducto = P.idproducto " +
                                        " WHERE DMI.idmovimiento = " + st.idMovimiento);
            return dtRegistros;
        }

        public DataTable verProductos(int tpbusqueda, int empresa, int bodega, string idproducto, string producto)
        {
            string codproducto = "null", nomproducto = null;
            string[] empresa1 = Globales.Empresa.CapturarEmpresa();
            if (tpbusqueda == 1)
            {
                if (idproducto == "")
                { codproducto = "null"; }
                else { codproducto = idproducto; }
                nomproducto = producto;
            }
            DataTable dtProducto = new DataTable();
            //, TP.descripcion AS TIPO_PRODUCTO, P.tamano AS TAMANO, P.peso AS PESO, P.precio AS PRECIO
            dtProducto = cnn.getSQL("SELECT P.idproducto AS CODIGO, P.descripcion AS PRODUCTO, E.cantidad AS CANTIDAD, P.precio AS PRECIO, " +
                                    " P.costo AS COSTO, B.nombre_bodega as BODEGA" +
                                     " FROM EXISTENCIA E " +
									 " JOIN PRODUCTO P ON E.idproducto = P.idproducto " +
									 " JOIN BODEGA B ON E.idbodega = B.idbodega " +
                                    " JOIN TIPOPRODUCTO TP ON P.idtipoproducto = TP.idtipoproducto " +
                                    " WHERE P.idproducto = isnull("+codproducto+", P.idproducto ) " +
                                    " AND P.descripcion like isnull('%"+nomproducto+"%', P.descripcion) AND B.idempresa = " + empresa1[0] +
                                    " AND E.idBodega = "+ bodega);
            return dtProducto;
        }

        #endregion

        #region BITACORA SEGUIMIENTO
        public DataTable verBitacora(SolicitudTransporte_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL(" SELECT B.descripcion as DESCRIPCION, B.fecha AS FECHA, EST.nombreestadost AS STATUS " +
                                    " FROM BITACORATRANSPORTE B " +
                                    " JOIN SOLICITUDTRANSPORTE ST ON B.idsolicitud = ST.idsolicitud " +
                                    " LEFT JOIN USUARIO_1 U ON B.idusuario = U.codusuario " +
                                    " LEFT JOIN ESTADOSOLICITUDTRANS EST ON B.idestadost = EST.idestadost " +
                                    " WHERE B.idsolicitud = " + st.idSolicitud +
                                    " AND ST.idmovimiento = CASE ST.idmovimiento WHEN 0 THEN ST.idmovimiento ELSE "+st.idMovimiento+" END " +
                                    " ORDER BY B.fecha");
            return dtRegistros;
        }

        //Bitacora en el form principal
        //Funcional
        public void registroTracking(SolicitudTransporte_Entity tracking)
        {
            cnn.insertSQL("INSERT INTO BITACORATRANSPORTE(idusuario, idsolicitud, descripcion, idestadost, idmovimiento) " +
                          " VALUES(1, " + tracking.idSolicitud + ", '"+ tracking.Notas +"', "+tracking.idEstado+", " + tracking.idMovimiento + " )");

            cnn.updateSQL("UPDATE SOLICITUDTRANSPORTE " +
                            " SET idestadost = "+ tracking.idEstado +
                            " WHERE idsolicitud = " + tracking.idSolicitud + " AND idmovimiento = " + tracking.idMovimiento);
        }

        //Muestra los ultimos 5 viajes del vehiculo seleccionado
        public DataTable HistorialVehiculoST(SolicitudTransporte_Entity vh)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL(" SELECT TOP 5 " +
                                    " ST.idtransporte AS CODV, T.kilometraje as KMS,  CONVERT(VARCHAR(10), fechasalida, 110) AS FECHA_SALIDA, T.origen AS ORIGEN, " +
                                    " CONVERT(VARCHAR(10), fechallegada, 110) AS FECHA_LLEGADA, T.destino as DESTINO " +
                                    " FROM TRAYECTO T " +
                                    " JOIN SOLICITUDTRANSPORTE ST ON T.idsolicitud = ST.idsolicitud " +
                                    " WHERE ST.idestadost in (2, 3) " +
                                    " AND ST.idtransporte = " + vh.idVehiculo + 
                                    " ORDER BY T.fechasalida DESC");
            return dtRegistros;
        }

        public DataTable historialViajesEmpleados(int codigo, int puesto)
        {
            DataTable dtRegsitros = new DataTable();
            dtRegsitros = cnn.getSQL("SELECT DP.idempleado AS CODIGO_EMPLEADO, CONCAT(DP.nombre1, ' ', DP.apellido1) as EMPLEADO, DP.identificacion as IDENTIFICACION, DP.identificacion as LICENCIA " +
                                     "   FROM DETALLEPERSONAL DP " +
                                     "  LEFT JOIN ASIGNACIONPERSONAL AP ON DP.idempleado = AP.idempleado  " +
                                     "   LEFT JOIN SOLICITUDTRANSPORTE ST ON AP.idsolicitud = ST.idsolicitud " +
                                     "  WHERE DP.idempleado NOT IN (SELECT DISTINCT idempleado " +
                                                                       " FROM ASIGNACIONPERSONAL AP " +
                                                                       " JOIN  SOLICITUDTRANSPORTE ST ON AP.idsolicitud = ST.idsolicitud " +
                                                                       " WHERE idempleado is not null " +
                                                                       " AND idestadost not in (2,3)) " +
                                       " AND DP.idempresa = 1 " +
                                       " AND DP.idempleado = CASE "+codigo+" WHEN 0 THEN DP.idempleado ELSE "+codigo+" END ");
            return dtRegsitros;
        }

        public DataTable historialViajexEmpleado(int codigo)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL(" SELECT TOP 5 AP.idempleado as CODIGO_EMPLEADO, st.idsolicitud as CODIGO_SOLICITUD, T.kilometraje as KMS,  " +
                                        " CONVERT(VARCHAR(10), fechasalida, 110) AS FECHA_SALIDA, CONVERT(VARCHAR(10), fechallegada, 110) AS FECHA_REGRESO, " +
                                        " T.origen AS ORIGEN, T.destino as DESTINO " +
                                        " FROM TRAYECTO T " +
                                        " JOIN SOLICITUDTRANSPORTE ST ON T.idsolicitud = ST.idsolicitud " +
                                        " JOIN ASIGNACIONPERSONAL AP ON T.idsolicitud = AP.idsolicitud " +
                                        " WHERE ST.idestadost in (2, 3) " +
                                        " AND AP.idempleado = " + codigo +
                                        " ORDER BY fecharegreso DESC ");
            return dtRegistros;

        }
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

        public DataTable verTipoMov()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM TIPOMOVIMIENTO");
            return dtRegistros;
        }

        public DataTable verBodegas()
        {
            //int idempresa;
            string[] empresa = Globales.Empresa.CapturarEmpresa();     
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM BODEGA WHERE activo = 1 AND idempresa = " + empresa[0]);
            return dtRegistros;
        }
        #endregion
    }
}
