using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using DAL;
namespace BO
{
    // Programador : Dennys Choy
    // Analista : Dennys Choy
    // Fecha : 08-07-22017
    // Comentarios : Envia a Inventarios los productos de una Solicitud de Transporte listos para ingresar

    public class SolicitudTransporte_BOL
    {
        //Inserta en el encabezado de la Solicitud de Transporte
        //Si funciona
        #region Encabezado Solicitud de Transporte
        public void binsertaEncabezadoST(SolicitudTransporte_Entity enc)
        {
            SolicitudTransporte_DAL insertar = new SolicitudTransporte_DAL();
            insertar.insertaEncabezadoST(enc);
        }

        public void actualizaST(SolicitudTransporte_Entity st)
        {
            SolicitudTransporte_DAL actualiza = new SolicitudTransporte_DAL();
            actualiza.actualizaST(st);
        }

        public void eliminarST(SolicitudTransporte_Entity st)
        {
            SolicitudTransporte_DAL enc = new SolicitudTransporte_DAL();
            enc.eliminaST(st);
        }

        // ---- Revisado
        //Funcion para cargar el grid con los movimientos para traslado 
        public DataTable verTodoST(SolicitudTransporte_Entity st)
        {
            //SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL vst = new SolicitudTransporte_DAL();
            dt = vst.verST(st);
            return dt;
        }

        public SolicitudTransporte_Entity verUnoST(int codigo, int mov)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            st.idSolicitud = codigo;
            st.idMovimiento = mov;
            return getst.getSingle_ST(st);
        }
        #endregion



        #region Detalle de Solicitud de Transporte
        public void insertaDetalleST(Detalle_ST_Entity det)
        {
            SolicitudTransporte_DAL insertarDetalle = new SolicitudTransporte_DAL();
            insertarDetalle.insertaDetalleST(det);
        }

        public DataTable verDetalleST(SolicitudTransporte_Entity st)
        {
            DataTable dt;
            SolicitudTransporte_DAL vst = new SolicitudTransporte_DAL();
            dt = vst.verDetalleST(st);
            return dt;
        }

        //Busca productos para mostrarlos en el gridview
        public DataTable verProductos(int tipobsq, int empresa, int bodega, string codigoproducto, string producto)
        {
            //SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            DataTable productos;
            SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            productos = getst.verProductos(tipobsq, empresa, bodega, codigoproducto, producto);
            return productos;
        }

        public void actualizarDetalleST(Detalle_ST_Entity det)
        {
            SolicitudTransporte_DAL detalle = new SolicitudTransporte_DAL();
            detalle.actualizaDetalleST(det);
        }

        public void eliminarDetalleST(Detalle_ST_Entity det)
        {
            SolicitudTransporte_DAL detalle = new SolicitudTransporte_DAL();
            detalle.eliminaDetalleST(det);
        }



        #endregion

        #region Bitacora de Seguimiento
        public DataTable BitacoraST(SolicitudTransporte_Entity st)
        {
            DataTable verST;
            SolicitudTransporte_DAL bit = new SolicitudTransporte_DAL();
            verST = bit.verBitacora(st);
           // SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            //verST = getst.verST_Single(st);
            return verST;
        }

        public void seguimientoTracking(SolicitudTransporte_Entity enc)
        {
            SolicitudTransporte_DAL track = new SolicitudTransporte_DAL();
            track.registroTracking(enc);
        }

        public DataTable historialVehiculosST(SolicitudTransporte_Entity st)
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL hist = new SolicitudTransporte_DAL();
            dt = hist.HistorialVehiculoST(st);
            return dt;
        }

        public DataTable historialViajesEmpleadosST(int codigo, int puesto)
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL hist = new SolicitudTransporte_DAL();
            dt = hist.historialViajesEmpleados(codigo, puesto);
            return dt;
        }

        public DataTable histViajePorEmpleado(int codigo)
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL hist = new SolicitudTransporte_DAL();
            dt = hist.historialViajexEmpleado(codigo);
            return dt;
        }

        #endregion

        #region Funciones y Metodos
        public DataTable verEstadosST()
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL vst = new SolicitudTransporte_DAL();
            dt = vst.verEstadosST();
            return dt;
        }

        public DataTable verTipoST()
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL tipo = new SolicitudTransporte_DAL();
            dt = tipo.verTipoST();
            return dt;
        }

        public DataTable verTipoMovimiento()
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL tipo = new SolicitudTransporte_DAL();
            dt = tipo.verTipoMov();
            return dt;
        }

        public DataTable verBodegas()
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL tipo = new SolicitudTransporte_DAL();
            dt = tipo.verBodegas();
            return dt;
        }
        #endregion
    }
}
