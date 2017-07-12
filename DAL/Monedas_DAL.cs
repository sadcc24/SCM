/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Monedas
    Fecha de asignación: 27/Junio
    Fecha de entrega: 08/Julio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class Monedas_DAL
    {
        public void vInsertMoneda(Monedas_Entity moneda)
        {
            Globales.cnn.insertSQL("INSERT INTO [dbo].[Moneda] (nombre_moneda,simbolo_moneda,activo) VALUES ('" + moneda.strmoneda+ "','" + moneda.strsimbolo + "','" + moneda.iactivo + "')");
        }

        public void vModificarMoneda(Monedas_Entity moneda)
        {
            Globales.cnn.updateSQL("UPDATE [dbo].[Moneda] SET nombre_moneda ='" + moneda.strmoneda + "', simbolo_moneda = '" + moneda.strsimbolo + "', activo = '" + moneda.iactivo + "'  WHERE idmoneda ='" + moneda.idmoneda + "'");
        }

        public void vEliminarMoneda(Monedas_Entity moneda)
        {
            Globales.cnn.updateSQL("UPDATE [dbo].[Moneda] SET activo = 0 WHERE idmoneda =" + moneda.idmoneda);
        }

        public DataTable vConsultarMoneda()
        {
            DataTable dtMoneda;
            dtMoneda = Globales.cnn.getSQL("SELECT idmoneda as ID, simbolo_moneda as Simbolo, nombre_moneda as Moneda FROM [dbo].[Moneda] WHERE activo = 1");
            return dtMoneda;
        }

        public void vConsultarMoneda(Monedas_Entity moneda)
        {
            Globales.cnn.getSQL("SELECT * FROM [dbo].[Moneda] WHERE activo = 1 and idmoneda=" + moneda.idmoneda);
        }

        public DataTable vConsultarFiltro(Monedas_Entity moneda)
        {
            DataTable dtMoneda;
            dtMoneda = Globales.cnn.getSQL("SELECT idmoneda as ID, simbolo_moneda as Simbolo, nombre_moneda as Moneda FROM [dbo].[Moneda] WHERE activo = 1 and nombre_moneda like '%" + moneda.strmoneda + "%'");
            return dtMoneda;
        }

    }
}
