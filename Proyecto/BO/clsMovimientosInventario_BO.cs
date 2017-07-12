using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
namespace BO
{
  public  class clsMovimientosInventario_BO
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David

        // Comentarios : Insertar Encabezado MI
        public void vInsertarMovimientoInventario(clsMovimientosInventario_Entity movimiento)
        {
            clsMovimientosInventario_DAL mov = new clsMovimientosInventario_DAL();
            mov.vInsertarMovimientoInventario(movimiento);
        }
        // Comentarios : Insertar Detalle MI
        public void vInsertarDetalleMovimientoInventario(clsMovimientosInventario_Entity movimiento)
        {
            clsMovimientosInventario_DAL mov = new clsMovimientosInventario_DAL();
            mov.vInsertarDetalleMovimientoInventario(movimiento);
        }


        // Comentarios : Modificar Existencia de Producto
        public void vModificarExistencia(clsMovimientosInventario_Entity existencia)
        {
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            exist.vModificarExistencia(existencia);
        }

        // Comentarios : Modificar costo por promedio a partir de compra
        public void vModificarCostoProducto(clsMovimientosInventario_Entity existencia)
        {
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            exist.vModificarCostoProducto(existencia);
        }


        // Comentarios : Consultar Existencia
        public DataTable vConsultarExistencia(clsMovimientosInventario_Entity existencia)
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.vConsultarExistencia(existencia);
            return dtProducto;
        }
        // Comentarios : Consultar Existencia Producto en General
        public DataTable vConsultarExistenciaProductoGeneral(clsMovimientosInventario_Entity existencia)
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.vConsultarExistenciaProductoGeneral(existencia);
            return dtProducto;
        }
        // Comentarios : Consultar Costo de Producto
        public DataTable vConsultarCostoProducto(clsMovimientosInventario_Entity existencia)
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.vConsultarCostoProducto(existencia);
            return dtProducto;
        }
        // Comentarios : Consultar operacion de tipo de movimientos
        public DataTable vConsultarOperacion(clsMovimientosInventario_Entity mov)
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.vConsultarOperacion(mov);
            return dtProducto;
        }
        // Comentarios : Consultar ultimo id ingresado de Encabezado MI
        public DataTable dtConsultarUltimoMovimiento()
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.dtConsultarUltimoMovimiento();
            return dtProducto;
        }
        // Comentario: Consultar Movimientos de Inventario de tipo egreso
        public DataTable dtConsultarEgresos(clsMovimientosInventario_Entity mov)
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.vConsultarEgresos(mov);
            return dtProducto;
        }

        // Comentario: Consultar Movimientos de Inventario de tipo egreso  -- detalle
        public DataTable detalleEgreso(clsMovimientosInventario_Entity mov)
        {
            DataTable dtProducto;
            clsMovimientosInventario_DAL exist = new clsMovimientosInventario_DAL();
            dtProducto = exist.detalleEgreso(mov);
            return dtProducto;
        }
    }
}
