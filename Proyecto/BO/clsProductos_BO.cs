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
 public class clsProductos_BO
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :
        #region "LLENADO COMBOS"
        public DataTable vdtComboBodega()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboBodega();
            return dtbodegas;
        }

        public DataTable vdtComboUnidad(clsProductos_Entity producto)
        {
            DataTable dtunidades;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtunidades = bodegaconsult.dtComboUnidadMedida(producto);
            return dtunidades;
        }


        public DataTable vdtComboProveedor()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboProveedor();
            return dtbodegas;
        }

        public DataTable vdtComboTipoProducto()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboTipoProducto();
            return dtbodegas;
        }

        public DataTable vdtComboMarca()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboMarca();
            return dtbodegas;
        }


        public DataTable vdtComboMetodoCosteo()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboMetodoCosteo();
            return dtbodegas;
        }

        public DataTable vdtComboLinea()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboLinea();
            return dtbodegas;
        }

        public DataTable vdtComboEstado()
        {
            DataTable dtbodegas;
            clsProductos_DAL bodegaconsult = new clsProductos_DAL();
            dtbodegas = bodegaconsult.dtComboEstado();
            return dtbodegas;
        }

        #endregion
        // Comentarios : Insertar producto
        public void vInsertarProducto(clsProductos_Entity producto)
        {
            clsProductos_DAL productinsert = new clsProductos_DAL();
            productinsert.vInsertProducto(producto);
        }
        // Comentarios : Modificar Producto
        public void vModificarProducto(clsProductos_Entity producto)
        {
            clsProductos_DAL productupdate = new clsProductos_DAL();
            productupdate.vModifProducto(producto);
        }
        // Comentarios : Eliminar Producto
        public void vEliminarProducto(clsProductos_Entity producto)
        {
            clsProductos_DAL productdelete = new clsProductos_DAL();
            productdelete.vEliminarProducto(producto);
        }

        // Comentarios : Consultar Catalogo de Productos
        public DataTable vConsultaProducto()
        {
            DataTable dtproductos;
            clsProductos_DAL productconsult = new clsProductos_DAL();
            dtproductos = productconsult.vConsultarProducto();
            return dtproductos;

        }
        // Comentarios : Filtrar Catalogo de productos
        public DataTable vConsultaFiltro(clsProductos_Entity producto)
        {
            DataTable dtProducto;
            clsProductos_DAL productoconfilt = new clsProductos_DAL();
            dtProducto = productoconfilt.vConsultarFiltro(producto);
            return dtProducto;
        }
        // Comentarios : mov productos
        public DataTable vMovimientoProductos(clsProductos_Entity producto)
        {
            DataTable dtProducto;
            clsProductos_DAL productoconfilt = new clsProductos_DAL();
            dtProducto = productoconfilt.vMovimientoProductos(producto);
            return dtProducto;
        }
        // Comentarios : existencia productos
        public DataTable vExistenciaProductos(clsProductos_Entity producto)
        {
            DataTable dtProducto;
            clsProductos_DAL productoconfilt = new clsProductos_DAL();
            dtProducto = productoconfilt.vExistenciaProductos(producto);
            return dtProducto;
        }
    }
}
