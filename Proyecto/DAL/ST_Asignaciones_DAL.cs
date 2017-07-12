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

    public class ST_Asignaciones_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");
        //MRP_BD cnn = new MRP_BD("r40usr", "Inter$2013", "SAD2017", "SDESRUTA40");

        public void insertaBitacora(int idsolicitud, int idusuario, string nota, int estado, int movimiento)
        {
            cnn.insertSQL("INSERT INTO BITACORATRANSPORTE(idusuario, idsolicitud, descripcion, idestadost, idmovimiento) " +
                            " VALUES("+idusuario+", " + idsolicitud + ", '"+nota+"', "+estado+", " + movimiento + " )");
        }

        public void guardarVehiculoAsingado(SolicitudTransporte_Entity sta)
        {
            cnn.insertSQL("UPDATE SOLICITUDTRANSPORTE " +
                           " SET idestadost = 6 , " +
                           " idtransporte = " + sta.idVehiculo +
                           " WHERE idsolicitud = " + sta.idSolicitud +
                           " AND idmovimiento = " + sta.idMovimiento);


            int stcodigo, idusuario, movimiento;
            stcodigo = sta.idSolicitud;
            movimiento = sta.idMovimiento;
            idusuario = sta.idUsuario;
            string nota = "Asignacion de transporte a la solcitud "; 
            insertaBitacora(stcodigo, idusuario, nota, 6, movimiento);      
        }

        public void eliminarVehiculoAsingado(SolicitudTransporte_Entity sta)
        {
            cnn.insertSQL("UPDATE SOLICITUDTRANSPORTE " +
                           " SET idestadost = 6 , " +
                           " idtransporte = null" +
                           " WHERE idsolicitud = " + sta.idSolicitud +
                           " AND idmovimiento = " + sta.idMovimiento);


            int stcodigo, idusuario, movimiento;
            stcodigo = sta.idSolicitud;
            movimiento = sta.idMovimiento;
            idusuario = sta.idUsuario;
            string nota = "Eliminacion del vehiculo en la solicitud";
            insertaBitacora(stcodigo, idusuario, nota, 6, movimiento);
        }

        #region Transportistas
        public Transportistas_ST_Entity getSinge_Empleado(int codigo)
        {
            Transportistas_ST_Entity st = new Transportistas_ST_Entity();
            DataTable dtRegistro = new DataTable();
           
            dtRegistro = cnn.getSQL("SELECT ST.idsolicitud, AP.idempleado, CONCAT(DP.nombre1, ' ', DP.apellido1) as nombreempleado, DP.identificacion " +
                                    " FROM SOLICITUDTRANSPORTE ST " +
                                    " JOIN ASIGNACIONPERSONAL AP ON ST.idsolicitud = AP.idsolicitud " +
                                    " JOIN DETALLEPERSONAL DP ON AP.idempleado = DP.idempleado " +
                                    " WHERE ST.idsolicitud = " + codigo);
            foreach (DataRow row in dtRegistro.Rows)
            {
                foreach (DataColumn column in dtRegistro.Columns)
                {
                    st.codigoEmpleado = Convert.ToInt32(row["idempleado"]);
                    st.idEmpleado = row["identificacion"].ToString();
                    st.nombreEmpleado = row["nombreempleado"].ToString();
                    st.licenciaEmpleado = row["identificacion"].ToString();                        
                }
            }
            return st;
        }

       
        public void insertarTransportistas(Transportistas_ST_Entity st)
        {
            cnn.insertSQL("INSERT INTO ASIGNACIONPERSONAL(idsolicitud, idempleado, idempresa, idmovimiento) " +
                            " VALUES("+st.idSolicitud +", "+ st.codigoEmpleado +", "+st.idEmpresa+ ", "+st.idMovimiento+" )");

            int stcodigo, idusuario, movimiento;
            stcodigo = st.idSolicitud;
            movimiento = st.idMovimiento;
            idusuario = st.idUsuario;
            string nota = "Asignacion de transporte a la solcitud ";
            insertaBitacora(stcodigo, idusuario, nota, 7, movimiento);

        }

        public void eliminarTransportistaAsingado(Transportistas_ST_Entity sta)
        {
            cnn.insertSQL("DELETE FROM ASIGNACIONPERSONAL " +
                           " WHERE idsolicitud = " + sta.idSolicitud +
                           " AND idempleado = " + sta.codigoEmpleado );


            int stcodigo, idusuario, movimiento;
            stcodigo = sta.idSolicitud;
            movimiento = sta.idMovimiento;
            idusuario = sta.idUsuario;
            string nota = "Se ha quitado al conductor de la solicitud";
            insertaBitacora(stcodigo, idusuario, nota, 7, movimiento);
        }
        #endregion

        #region Trayecto 
        public void insertarTrayecto(TrayectoST_Entity st)
        {
            cnn.insertSQL("INSERT INTO TRAYECTO (idsolicitud, idmovimiento, fechasalida, fechallegada, origen, destino, kilometraje) " +
                            "VALUES("+st.idSolicitud+", "+st.idMovimiento+",'"+st.fechasalida+"', '"+st.fechallegada+"','"+st.origen+"','"+st.destino+"',"+st.kms+")");

            int stcodigo, idusuario, movimiento;
            stcodigo = st.idSolicitud;
            movimiento = st.idMovimiento;
            idusuario = st.idUsuario;
            string nota = "Ingreso del trayecto en la solicitud";
            insertaBitacora(stcodigo, idusuario, nota, 8, movimiento);
        }

        public void actualizarTrayecto(TrayectoST_Entity st)
        {

            cnn.updateSQL("UPDATE TRAYECTO SET " +
                            " fechallegada = \'" + st.fechallegada + "\'," +
                            " fechasalida = \'" + st.fechasalida + "\'," +
                            " origen = '" + st.origen + "'," +
                            " destino = '" + st.destino + "'," +
                            " kilometraje = " + st.kms + 
                            " WHERE idsolicitud = "+st.idSolicitud);

            int stcodigo, idusuario, movimiento;
            stcodigo = st.idSolicitud;
            movimiento = st.idMovimiento;
            idusuario = st.idUsuario;
            string nota = "Actualizacion de la informacion del trayecto";
            insertaBitacora(stcodigo, idusuario, nota, 8, movimiento);
        }

        public void eliminarTrayecto(TrayectoST_Entity st)
        {
            cnn.updateSQL("UPDATE TRAYECTO SET " +
                           " fechallegada = '' ," +
                           " fechasalida = '' ," +
                           " origen = '' ," +
                           " destino = '' ," +
                           " kilometraje = 0" +
                           " WHERE idsolicitud = " + st.idSolicitud);


            int stcodigo, idusuario, movimiento;
            stcodigo = st.idSolicitud;
            movimiento = st.idMovimiento;
            idusuario = st.idUsuario;
            string nota = "Eliminacion del trayecto en la solicitud";
            insertaBitacora(stcodigo, idusuario, nota, 8, movimiento);
        }

        public TrayectoST_Entity verTrayectoST(TrayectoST_Entity idst)
        {
            TrayectoST_Entity st = new TrayectoST_Entity();
            DataTable dtRegistro = new DataTable();
            dtRegistro = cnn.getSQL("SELECT * FROM TRAYECTO WHERE idsolicitud = " + idst.idSolicitud);
            foreach (DataRow row in dtRegistro.Rows)
            {
                foreach (DataColumn column in dtRegistro.Columns)
                {
                    st.fechasalida= row["fechasalida"].ToString();
                    st.fechallegada = row["fechallegada"].ToString();
                    st.origen = row["origen"].ToString();
                    st.destino = row["destino"].ToString();
                    st.kms = Convert.ToDecimal(row["kilometraje"]);
                    st.idTrayecto = Convert.ToInt32(row["idtrayecto"]);
                    
                }
            }
            return st;
        }
        #endregion

        #region Gastos
        public void insertaEncabezadoGasto(GatosTransportes_Entity st)
        {
            cnn.insertSQL("INSERT INTO M_GASTOTRANSPORTE(idtransporte, idsolicitud, gastotoal) " +
                " VALUES("+st.idtransporte+","+st.idSolicitud+",0)");
        }

        public void actualizarGastoTotal(int solicitud, decimal monto, decimal pivote, int tipo)
        {
            string actualiza = "";
            switch (tipo)
            {
                case 1:
                    //INSERTA
                    actualiza = string.Format(" (gastotoal +  {0}) ", monto);
                    break;
                case 2:
                    //ACTUALIZACIÓN
                    cnn.updateSQL("UPDATE M_GASTOTRANSPORTE SET gastotoal = (gastotoal - "+pivote+") " +
                                    " WHERE idsolicitud = " + solicitud);
                    actualiza = string.Format("(gastotoal + {0})", monto);
                    break;
                case 3:
                    //ELIMINACIÓN
                    actualiza = string.Format("(gastotoal - {0})", monto);
                    break;
            }

            cnn.updateSQL("UPDATE M_GASTOTRANSPORTE SET gastotoal = " + actualiza + 
                            " WHERE idsolicitud = " + solicitud);
        }
        public void actualizaEncabezadoGast(GatosTransportes_Entity st)
        {
            cnn.updateSQL("UPDATE M_GASTOTRANSPORTE SET gastotoal = " + st.totalGasto + " WHERE idsolicitud = "+st.idSolicitud);
        }

        public DataTable todosGastos(GatosTransportes_Entity st)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idetallegasto as CODIGO, facturaasociada AS FACTURA, montototal AS GASTO, fechafactura AS FECHA, " +
                                        " notafactura AS NOTAS, TP.nombre AS TIPO_GASTO " +
                                        " FROM DETALLEGASTOTRANSPORTE DGT " +
                                        " JOIN TIPOGASTO TP ON DGT.tipogasto = TP.idgasto " +
                                        " WHERE idsolicitud = " + st.idSolicitud);
            return dtRegistros;
        }

        public GatosTransportes_Entity verUnGasto(int codigo)
        {
            GatosTransportes_Entity st = new GatosTransportes_Entity();
            DataTable dtRegistro = new DataTable();

            dtRegistro = cnn.getSQL("SELECT * FROM DETALLEGASTOTRANSPORTE WHERE idetallegasto = " + codigo);
            foreach (DataRow row in dtRegistro.Rows)
            {
                foreach (DataColumn column in dtRegistro.Columns)
                {
                    st.idDetGasto = Convert.ToInt32(row["idetallegasto"]);
                    st.factura = row["facturaasociada"].ToString();
                    st.totalGasto = Convert.ToDecimal(row["montototal"]);
                    st.fechafactura = row["fechafactura"].ToString();
                    st.Notas = row["notafactura"].ToString();
                    st.idTipoGasto = Convert.ToInt32(row["tipogasto"]);
                    st.idtransporte = Convert.ToInt32(row["idtransporte"]);
                    st.idSolicitud = Convert.ToInt32(row["idsolicitud"]);
                    st.idGasto = Convert.ToInt32(row["idgastotransporte"]);
                    st.kms = Convert.ToDecimal(row["kilometraje"]);
                }
            }
            return st;
        }

        public void insertaDetalleGasto(GatosTransportes_Entity st)
        {
            cnn.insertSQL("INSERT INTO DETALLEGASTOTRANSPORTE(facturaasociada, montototal, fechafactura, notafactura, tipogasto, idtransporte, idgastotransporte, idsolicitud, kilometraje) " +
                " VALUES('" + st.factura+ "'," + st.totalGasto+ ",\'"+st.fechafactura+"\','" + st.Notas+ "',"+st.idTipoGasto+","+st.idtransporte+","+st.idGasto+","+st.idSolicitud+","+st.kms+")");

            actualizarGastoTotal(st.idSolicitud, st.totalGasto, st.gastoPivote, 1);
        }

        public void actualizaDetalleGasto(GatosTransportes_Entity st)
        {
            cnn.updateSQL("UPDATE DETALLEGASTOTRANSPORTE SET facturaasociada='"+st.factura+"', montototal="+st.totalGasto+", fechafactura='"+st.fechafactura+"', notafactura = '"+st.Notas+"', "+ 
                            " tipogasto="+st.idTipoGasto+ " , kilometraje = "+st.kms+" WHERE idetallegasto = "+st.idDetGasto );

            actualizarGastoTotal(st.idSolicitud, st.totalGasto, st.gastoPivote, 2);
        }
        
        public void eliminaDetalleGasto(GatosTransportes_Entity st)
        {
            cnn.deleteSQL("DELETE FROM DETALLEGASTOTRANSPORTE WHERE idetallegasto = " + st.idDetGasto);

            actualizarGastoTotal(st.idSolicitud, st.totalGasto, st.gastoPivote, 3);
        }
        public GatosTransportes_Entity getIdGasto(int idst)
        {
            GatosTransportes_Entity st = new GatosTransportes_Entity();
            DataTable dtRegistro = new DataTable();

            dtRegistro = cnn.getSQL("SELECT ST.idtransporte, MGT.idgastotransporte, MGT.gastotoal, MGT.idAutorizacion " +
                                        " FROM SOLICITUDTRANSPORTE ST " +
                                        " LEFT JOIN M_GASTOTRANSPORTE MGT ON ST.idsolicitud = MGT.idsolicitud " +
                                        " WHERE ST.idsolicitud = " + idst);
            foreach (DataRow row in dtRegistro.Rows)
            {
                foreach (DataColumn column in dtRegistro.Columns)
                {
                    st.idtransporte = Convert.ToInt32(row["idtransporte"]);
                    if (row["idgastotransporte"] == DBNull.Value)
                    {
                        st.idGasto = 0;
                        st.gastoTotal = 0;
                        st.idAutoriza = 0;
                    }
                    else
                    {
                        st.idGasto = Convert.ToInt32(row["idgastotransporte"]);
                        st.gastoTotal = Convert.ToDecimal(row["gastotoal"]);
                        if(row["idAutorizacion"] == DBNull.Value) { st.idAutoriza = 0; }
                        else { st.idAutoriza = Convert.ToInt32(row["idAutorizacion"]); }
                        
                    }
                }
            }
            return st;

        }

        public DataTable tipoGastos()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM TIPOGASTO");
            return dtRegistros;
        }
        #endregion

    }
}
