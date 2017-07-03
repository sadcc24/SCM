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
    public class SolicitudTransporte_BOL
    {

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

        public DataTable verTodoST()
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL vst = new SolicitudTransporte_DAL();
            dt = vst.verST();
            return dt;
        }

        public DataTable verST_Single(SolicitudTransporte_Entity st)
        {
            DataTable verST;
            SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            verST = getst.verST_Single(st);
            return verST;
        }

        public SolicitudTransporte_Entity verUnoST(int codigo)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            st.idSolicitud = codigo;
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
        public DataTable verProductos(int tipobsq)
        {
            //SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            DataTable productos;
            SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            productos = getst.verProductos(tipobsq);
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
        #endregion
    }
}
