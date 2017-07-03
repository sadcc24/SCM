using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
namespace DAL
{
  public  class clsTipoMovimiento_DAL
    {
        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        // MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        public void vInsertarTipoMovimiento(clsTipoMovimiento_Entity tipomovimiento)
        {
            cnn.insertSQL("INSERT INTO [dbo].[TIPOMOVIMIENTO] (descripcion,operacion,activo) VALUES ('"
                + tipomovimiento.strDescripcion + "'," + tipomovimiento.strOperacion  + ",1)");
        }
   

     

        public DataTable vConsultarTipoMovimiento()
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT idtipomovimiento as ID , descripcion as [TIPO MOVIMIENTO], operacion as [Operacion] FROM [dbo].[TIPOMOVIMIENTO] WHERE ACTIVO = 1");
            return dtBodega;
        }


        public DataTable vConsultarFiltro(clsTipoMovimiento_Entity tipomovimiento)
        {
            DataTable dtBodegas;
            dtBodegas = cnn.getSQL("SELECT idtipomovimiento as ID, descripcion as [TIPO MOVIMIENTO], operacion as [Operacion] FROM [dbo].[TIPOMOVIMIENTO] WHERE ACTIVO = 1 AND descripcion like '%" + tipomovimiento.strDescripcion + "%'");
            return dtBodegas;
        }
    }
}
