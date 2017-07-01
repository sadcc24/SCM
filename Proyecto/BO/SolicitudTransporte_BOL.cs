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
        public void insertaDetalleST(Detalle_ST_Entity det)
        {
            SolicitudTransporte_DAL insertarDetalle = new SolicitudTransporte_DAL();
            insertarDetalle.insertaDetalleST(det);
        }

        public void binsertaEncabezadoST(SolicitudTransporte_Entity enc)
        {
            SolicitudTransporte_DAL insertar = new SolicitudTransporte_DAL();
            insertar.insertaEncabezadoST(enc);
        }

        public DataTable verTodoST()
        {
            DataTable dt = new DataTable();
            SolicitudTransporte_DAL vst = new SolicitudTransporte_DAL();
            dt = vst.verST();
            return dt;
        }

        public SolicitudTransporte_Entity verUnoST(int codigo)
        {
            SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            SolicitudTransporte_DAL getst = new SolicitudTransporte_DAL();
            st.idSolicitud = codigo;
            return getst.getSingle_ST(st);
        }
    }
}
