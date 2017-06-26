using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
namespace DAL
{
  public  class clsProductos_DAL
    {
        MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        public DataTable dtComboBodega()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT idbodega as ID, nombre_bodega as Descripcion FROM [dbo].[Bodega] where activo = 1");
            return dtProductos;
        }

        public DataTable dtComboProveedor()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT idproveedor as ID, nombre_proveedor as Descripcion FROM [dbo].[Proveedor] where activo = 1");
            return dtProductos;
        }

        public DataTable dtComboTipoProducto()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT id_tipo_producto as ID, descripcion as Descripcion FROM [dbo].[Tipo_Producto] where activo = 1");
            return dtProductos;
        }

        public DataTable dtComboMarca()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT idmarca as ID, descripcion as Descripcion FROM [dbo].[Marca]");
            return dtProductos;
        }

        public DataTable dtComboMetodoCosteo()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT codmetodo as ID, nommetodo as Descripcion FROM [dbo].[METODOCOSTEO]");
            return dtProductos;
        }

        public DataTable dtComboLinea()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT codlinea as ID, descripcion as Descripcion FROM [dbo].[LINEA]");
            return dtProductos;
        }
        public DataTable dtComboEstado()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT codestado as ID, descestado as Descripcion FROM [dbo].[ESTADOPRODUCTO]");
            return dtProductos;
        }


        public void vInsertProducto(clsProductos_Entity producto)
        {
            cnn.insertSQL("INSERT INTO [dbo].[Producto] (descripcion,cantidad,activo,idbodega,idproveedor,id_tipo_producto,idmarca,fechacreacion,codmetodo,codlinea,codestado,tamano,peso) VALUES ('"
                + producto.strProducto + "'," + producto.strCantidad + "," + "1," + producto.strBodega + "," + producto.strProveedor + "," + producto.strTipoProducto + "," + producto.strMarca + ",(SELECT GETDATE())," + producto.strMetodoCosteo + "," + producto.strLinea + "," + producto.strEstado + "," + producto.strTamano + "," + producto.strPeso  + ")");
        }


        public void vModifProducto(clsProductos_Entity producto)
        {
            cnn.updateSQL("UPDATE [dbo].[Producto] SET descripcion='" + producto.strProducto 
                + "', cantidad =" + producto.strCantidad 
                + " , idbodega =" + producto.strBodega 
                + " , idproveedor= " + producto.strProveedor 
                + " , id_tipo_producto =" + producto.strTipoProducto 
                + " , idmarca =" + producto.strMarca 
                + " , codmetodo =" + producto.strMetodoCosteo 
                + " , codlinea = " + producto.strLinea 
                + " , tamano=" + producto.strTamano 
                + " , peso=" + producto.strPeso 
                + "  WHERE idproducto =" + producto.strIdProd );
        }

        public void vEliminarProducto(clsProductos_Entity producto)
        {
            cnn.updateSQL("UPDATE [dbo].[Producto] SET ACTIVO = 0 , codestado = 2 WHERE idproducto =" + producto.strIdProd);
        }

        public DataTable vConsultarProducto()
        {
            DataTable dtProducto;
            dtProducto = cnn.getSQL("SELECT idProducto as ID, descripcion as Descripcion, cantidad as Cantidad, idBodega as [Bodega] , idproveedor as [Proveedor], id_tipo_producto as [Tipo Producto], idmarca as [Marca], codmetodo as [Método Costeo], codlinea as [Linea], tamano as [Tamaño], peso as [Peso], codestado as [Estado] FROM [dbo].[Producto] WHERE ACTIVO = 1");
            return dtProducto;
        }

        public DataTable vConsultarFiltro(clsProductos_Entity producto)
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT idProducto as ID, descripcion as Descripcion, cantidad as Cantidad, idBodega as [Bodega] , idproveedor as [Proveedor], id_tipo_producto as [Tipo Producto], idmarca as [Marca], codmetodo as [Método Costeo], codlinea as [Linea], tamano as [Tamaño], peso as [Peso], codestado as [Estado] FROM [dbo].[Producto] WHERE ACTIVO = 1 and descripcion like '%"+producto.strProducto+"%'");
            return dtProductos;
        }


    }
}
