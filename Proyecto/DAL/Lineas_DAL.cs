/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Líneas
    Fecha de asignación: 27/Junio
    Fecha de entrega: 03/Julio
*/using System;
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
        MRP_BD cnn = Globales.cnn;

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
