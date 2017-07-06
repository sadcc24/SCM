using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;


namespace DAL
{
   public  class clsBodegas_DAL
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        // MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        public void vInsertBodega(clsBodegas_Entity bodega) {                       
            cnn.insertSQL("INSERT INTO [dbo].[Bodega] (nombre_bodega,encargado,stock_minimo,stock_maximo,activo,idempresa) VALUES ('" 
                + bodega.strNombreBodega+"','"+bodega.strNombreEncargado+ "',"+bodega.iStockMinimo + "," +bodega.iStockMaximo + ",1,"  + bodega.iIdEmpresa +  ")");
        }

        public void vModificarBodega(clsBodegas_Entity bodega) {
            cnn.updateSQL("UPDATE [dbo].[Bodega] SET nombre_bodega ='"+bodega.strNombreBodega+"', encargado = '" + bodega.strNombreEncargado + "', stock_minimo = " + bodega.iStockMinimo + ", stock_maximo = " + bodega.iStockMaximo + "  WHERE idbodega =" + bodega.iIdBodega);
        }

        public void vEliminarBodega(clsBodegas_Entity bodega) {
            cnn.updateSQL("UPDATE [dbo].[Bodega] SET ACTIVO = 0 WHERE idbodega =" + bodega.iIdBodega);
        }

        public DataTable vConsultarBodega() {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT idbodega as ID, nombre_bodega as Descripcion , encargado as Encargado, stock_minimo as [STOCK MIN], stock_maximo as [STOCK MAX] , activo as Activo, idEmpresa as IDEmpresa FROM [dbo].[Bodega] WHERE ACTIVO = 1");
            return dtBodega;
        }

        public void vConsultarBodega(clsBodegas_Entity bodega)
        {
            cnn.getSQL("SELECT * FROM [dbo].[Bodega] WHERE ACTIVO = 1 and idbodega =" + bodega.iIdBodega);
        }

        public DataTable vConsultarFiltro(clsBodegas_Entity bodega) {
            DataTable dtBodegas;
            dtBodegas = cnn.getSQL("SELECT idbodega as ID, nombre_bodega as Descripcion , encargado as Encargado, stock_minimo as [STOCK MIN], stock_maximo as [STOCK MAX] , activo as Activo, idEmpresa as IDEmpresa FROM [dbo].[Bodega] where nombre_bodega like '%"+ bodega.strNombreBodega +"%'");
            return dtBodegas;
        }
    }
}
