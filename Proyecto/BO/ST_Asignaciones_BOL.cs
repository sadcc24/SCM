using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entity;

namespace BO
{
    // Programador : Dennys Choy
    // Analista : Dennys Choy
    // Fecha : 08-07-22017
    // Comentarios : Envia a Inventarios los productos de una Solicitud de Transporte listos para ingresar

    public class ST_Asignaciones_BOL
    {
       

        public void asignaVehiuloST(SolicitudTransporte_Entity enc)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.guardarVehiculoAsingado(enc);
        }

        public void eliminaVehiuloST(SolicitudTransporte_Entity enc)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.eliminarVehiculoAsingado(enc);
        }

        public Transportistas_ST_Entity verEmpleadoAsignado(int codigo)
        {
            Transportistas_ST_Entity ste = new Transportistas_ST_Entity();
            ST_Asignaciones_DAL getst = new ST_Asignaciones_DAL();
            return getst.getSinge_Empleado(codigo);
            
        }

        public void guardarTranortista(Transportistas_ST_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.insertarTransportistas(st);
        }

        public void eliminaPersonalST(Transportistas_ST_Entity enc)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.eliminarTransportistaAsingado(enc);
        }

        #region Trayecto
         //Busca el trayecto realizado
        public TrayectoST_Entity verTrayecto(int idst, int idmov)
        {
            //SolicitudTransporte_Entity st = new SolicitudTransporte_Entity();
            TrayectoST_Entity st = new TrayectoST_Entity();
            ST_Asignaciones_DAL sta = new ST_Asignaciones_DAL();
            st.idSolicitud = idst;
            st.idMovimiento = idmov;
            return sta.verTrayectoST(st);

        }
        public void guardarTrayecto(TrayectoST_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.insertarTrayecto(st);
            
        }

        public void eliminaTrayecto(TrayectoST_Entity enc)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.eliminarTrayecto(enc);
        }

        public void actualiaTrayecto(TrayectoST_Entity enc)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.actualizarTrayecto(enc);
        }
        #endregion

        #region GASTOS
        public void guardarEncabezadoGast(GatosTransportes_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.insertaEncabezadoGasto(st);
        }

        public void actualizaEncabezadoGasto(GatosTransportes_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.actualizaEncabezadoGast(st);
        }

        public DataTable verTodosGastos(GatosTransportes_Entity st)
        {
            DataTable dt = new DataTable();
            ST_Asignaciones_DAL gr = new ST_Asignaciones_DAL();
            dt = gr.todosGastos(st);
            return dt;
        }

        public DataTable verTipoGastos()
        {
            DataTable dt = new DataTable();
            ST_Asignaciones_DAL gr = new ST_Asignaciones_DAL();
            dt = gr.tipoGastos();
            return dt;
        }

        public GatosTransportes_Entity verUnGasto(int codigo)
        {
            GatosTransportes_Entity st = new GatosTransportes_Entity();
            ST_Asignaciones_DAL getst = new ST_Asignaciones_DAL();
            return getst.verUnGasto(codigo);

        }

        public GatosTransportes_Entity verIdGasto(int idst)
        {
            GatosTransportes_Entity st = new GatosTransportes_Entity();
            ST_Asignaciones_DAL getst = new ST_Asignaciones_DAL();
            return getst.getIdGasto(idst);

        }

        public void guardarDetalleGasto(GatosTransportes_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.insertaDetalleGasto(st);
        }

        public void actualizarDetalleGasto(GatosTransportes_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.actualizaDetalleGasto(st);
        }

        public void eliminarDetalleGasto(GatosTransportes_Entity st)
        {
            ST_Asignaciones_DAL guardar = new ST_Asignaciones_DAL();
            guardar.eliminaDetalleGasto(st);
        }
        #endregion
    }
}
