using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;


namespace DAL
{
   public class estado_solicitud_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertestado(estado_solicitud_Entity est)
        {
            try
            {
                cnn.insertSQL("INSERT INTO ESTADOSOLICITUDTRANS (nombreestadost)values('" + est.nombre_solicitud + "')");

            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verEstados()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idestadost as Codigo, nombreestadost as Nombre from ESTADOSOLICITUDTRANS");
            return dt;
        }

        public void updateEstados(estado_solicitud_Entity est)
        {
            try
            {
                cnn.updateSQL("UPDATE ESTADOSOLICITUDTRANS SET nombreestadost = '" + est.nombre_solicitud +"' WHERE idestadost = '" + est.id_estado_solicitud + "'");

            }
            catch (Exception ex)
            {

            }
        }

        public void deleteEstados(estado_solicitud_Entity est)
        {
            try
            {
                cnn.deleteSQL("DELETE ESTADOSSOLICITUDTRANS WHERE idestadost='" + est.id_estado_solicitud + "'");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
