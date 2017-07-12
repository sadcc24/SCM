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
    // Corregir info
    // Comentarios : Envia a Inventarios los productos de una Solicitud de Transporte listos para ingresar

    public class Detalle_ST_BO
    {
        public DataTable verTodoST(Detalle_ST_Entity st)
        {
            DataTable dt = new DataTable();
            Detalle_ST_DAL vst = new Detalle_ST_DAL();
            dt = vst.todosMovimientos(st);
            return dt;
        }
        //Inserta encabezado
        public void guardaEncabezado(Detalle_ST_Entity st)
        {  
            Detalle_ST_DAL guardar = new Detalle_ST_DAL();
            guardar.insertarEncabezadoMovimiento(st);
        }

        //Actualiza encabezado
        public void actualizaEncabezado(Detalle_ST_Entity st)
        {
            Detalle_ST_DAL guardar = new Detalle_ST_DAL();
            guardar.actualizaEncabezadoMovimiento(st);
        }

        //elimina encabezado
        public void eliminaEncabezado(int codigo)
        {
            Detalle_ST_DAL guardar = new Detalle_ST_DAL();
            guardar.eliminarEncabezadoMovimiento(codigo);
        }

        //Obtiene un registro para mostrarlo en los datos del formulario
        public Detalle_ST_Entity verUno_Movimiento(int codigo)
        {
            Detalle_ST_Entity st = new Detalle_ST_Entity();
            Detalle_ST_DAL getst = new Detalle_ST_DAL();
            return getst.getSinge_Movimiento(codigo);
        }

        public Detalle_ST_Entity validaExistenciaBD(int producto, int bodega)
        {
            Detalle_ST_Entity st = new Detalle_ST_Entity();
            Detalle_ST_DAL valida = new Detalle_ST_DAL();
            return valida.validaExistencia(producto, bodega);
        }
        

        #region Detalle
        public DataTable verTodoDetalle(int codigo)
        {
            DataTable dt = new DataTable();
            Detalle_ST_DAL vst = new Detalle_ST_DAL();
            dt = vst.detMovimientos_Todos(codigo);
            return dt;
        }
        #endregion
    }
}
