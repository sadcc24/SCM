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
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        //MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        // MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
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
            dtProductos = cnn.getSQL("SELECT idtipoproducto as ID, descripcion as Descripcion FROM [dbo].[TipoProducto] where activo = 1");
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
            dtProductos = cnn.getSQL("SELECT idmetodo as ID, nommetodo as Descripcion FROM [dbo].[METODOCOSTEO]");
            return dtProductos;
        }

        public DataTable dtComboLinea()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT idlinea as ID, descripcion as Descripcion FROM [dbo].[LINEA]");
            return dtProductos;
        }
        public DataTable dtComboEstado()
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT idestado as ID, descestado as Descripcion FROM [dbo].[ESTADOPRODUCTO]");
            return dtProductos;
        }

        public DataTable dtComboUnidadMedida(clsProductos_Entity unidadmedida)
        {
            DataTable dtUnidades;
            dtUnidades = cnn.getSQL("SELECT idtipounidad as ID, descripcion as Descripcion from [dbo].[TIPOUNIDAD] where tipo = " + unidadmedida.strtipou);
            return dtUnidades;
        }


        public void vInsertProducto(clsProductos_Entity producto)
        {
            cnn.insertSQL("INSERT INTO [dbo].[Producto] (descripcion,stockminimo,stockmaximo,activo,idproveedor,idtipoproducto,idmarca,fechacreacion,idmetodo,idlinea,tamano,peso,idempresa,unidadpeso,unidadtamano) VALUES ('"
                + producto.strProducto + "'," 
                + producto.strsmin + ","
                +  producto.strsmax 
                + ",1," 
                + producto.strProveedor + "," 
                + producto.strTipoProducto + "," 
                + producto.strMarca 
                + ",(SELECT GETDATE())," 
                + producto.strMetodoCosteo + "," 
                + producto.strLinea + "," 
                + producto.strTamano + "," 
                + producto.strPeso  + "," 
                + producto.strIdEmpresa + ","
                + producto.struPeso + ","
                + producto.struTamano + ")");
        }


        public void vModifProducto(clsProductos_Entity producto)
        {
            cnn.updateSQL("UPDATE [dbo].[Producto] SET descripcion='" + producto.strProducto 
                + "', stockminimo =" + producto.strsmin 
                + " , stockmaximo =" + producto.strsmax 
                + " , idproveedor= " + producto.strProveedor 
                + " , idtipoproducto =" + producto.strTipoProducto 
                + " , idmarca =" + producto.strMarca 
                + " , idmetodo =" + producto.strMetodoCosteo 
                + " , idlinea = " + producto.strLinea 
                + " , tamano=" + producto.strTamano 
                + " , peso=" + producto.strPeso
                + " , unidadpeso=" + producto.struPeso
                + " , unidadtamano=" + producto.struTamano
                + "  WHERE idproducto =" + producto.strIdProd );
        }

        public void vEliminarProducto(clsProductos_Entity producto)
        {
            cnn.updateSQL("UPDATE [dbo].[Producto] SET ACTIVO = 0 , codestado = 2 WHERE idproducto =" + producto.strIdProd);
        }

        public DataTable vConsultarProducto()
        {
            DataTable dtProducto;
            dtProducto = cnn.getSQL("SELECT [idproducto] as ID ,[descripcion] AS Descripcion ,[stockminimo] as [Stock Mínimo] ,[stockmaximo] as [Stock Máximo],[activo] as Activo,[idproveedor] as Proveedor,[idtipoproducto] as  [Tipo Producto] ,[idmarca] as Marca,[fechacreacion] as  [Fecha Creación],[idmetodo] as [Metodo],[idlinea] as Linea,[tamano] as Tamano,[peso] as Peso ,[precio] as Precio,[costo] as Costo,[idempresa] as Empresa,[unidadpeso] as [Ünidad Peso],[unidadtamano] as [Unidad Tamano] FROM[SAD2017].[dbo].[PRODUCTO] where Activo = 1");
            return dtProducto;
        }

        public DataTable vConsultarFiltro(clsProductos_Entity producto)
        {
            DataTable dtProductos;
            dtProductos = cnn.getSQL("SELECT [idproducto] as ID ,[descripcion] AS Descripcion ,[stockminimo] as [Stock Mínimo] ,[stockmaximo] as [Stock Máximo],[activo] as Activo,[idproveedor] as Proveedor,[idtipoproducto] as  [Tipo Producto] ,[idmarca] as Marca,[fechacreacion] as  [Fecha Creación],[idmetodo] as [Metodo],[idlinea] as Linea,[tamano] as Tamano,[peso] as Peso ,[precio] as Precio,[costo] as Costo,[idempresa] as Empresa,[unidadpeso] as [Ünidad Peso],[unidadtamano] as [Unidad Tamano] FROM[SAD2017].[dbo].[PRODUCTO] where Activo = 1 and descripcion like '%" + producto.strProducto+"%'");
            return dtProductos;
        }

       


    }
}
