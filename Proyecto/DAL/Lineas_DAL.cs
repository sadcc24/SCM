using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class Lineas_DAL
    {
        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        // MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");

        public void vInsertLinea(Lineas_Entity Linea)
        {
            cnn.insertSQL("INSERT INTO [dbo].[Linea] (condicion,estado,descripcion) VALUES ('"
                + Linea.iCondicion + "','" + Linea.iEstado+ "','" + Linea.strDescripcion + "')");
        }

        public void vModificarLinea(Lineas_Entity Linea)
        {
            cnn.updateSQL("UPDATE [dbo].[Linea] SET estado = '" + Linea.iEstado + "', descripcion = '" + Linea.strDescripcion + "' WHERE idlinea ='" + Linea.iCodLineas + "'");
        }

        public void vEliminarLinea(Lineas_Entity Linea)
        {
            cnn.updateSQL("UPDATE [dbo].[Linea] SET estado = 0  WHERE idlinea =" + Linea.iCodLineas);
        }

        public DataTable vConsultarLinea()
        {
            DataTable dtLinea;
            dtLinea = cnn.getSQL("SELECT idlinea, descripcion FROM [dbo].[Linea] WHERE Estado = 1");
            return dtLinea;
        }

        public void vConsultarLinea(Lineas_Entity Linea)
        {
            cnn.getSQL("SELECT * FROM [dbo].[Linea] WHERE Estado = 1 and codLinea=" + Linea.iCodLineas);
        }

        public DataTable vConsultarFiltro(Lineas_Entity Linea)
        {
            DataTable dtLinea;
            dtLinea = cnn.getSQL("SELECT idlinea, descripcion  FROM [dbo].[Linea]  WHERE Descripcion like '%" + Linea.strDescripcion + "%'");
            return dtLinea;
        }
    }
}
