using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
namespace DAL
{
  public  class clsMarcas_DAL
    {

        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        // MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        public void vInsertarMarca(clsMarcas_Entity marcas)
        {
            cnn.insertSQL("INSERT INTO [dbo].[MARCA] (descripcion) VALUES ('"
                + marcas.strDescripcion + "')");
        }




        public DataTable vConsultarMarcas()
        {
            DataTable dtMarcas;
            dtMarcas = cnn.getSQL("SELECT idmarca as ID, descripcion as [MARCA] FROM [dbo].[MARCA] ");
            return dtMarcas;
        }


        public DataTable vConsultarFiltro(clsMarcas_Entity marca)
        {
            DataTable dtMarcas;
            dtMarcas = cnn.getSQL("SELECT idmarca as ID, descripcion as [MARCA] FROM [dbo].[MARCA] WHERE descripcion like '%" + marca.strDescripcion + "%'");
            return dtMarcas;
        }
    }
}
