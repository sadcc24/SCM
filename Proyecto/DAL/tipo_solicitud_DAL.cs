using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class tipo_solicitud_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void inserttiposolicitud(tipo_solicitud_Entity tip)
        {
            try
            {
                cnn.insertSQL("INSERT INTO TIPOSOLICTRANS (nombretipost)values('" + tip.nombre_solicitud + "')");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verTipos()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idtiposolict as Codigo, nombretipost as Nombre from TIPOSOLICTRANS");
            return dt;
        }

        public void updatetipos(tipo_solicitud_Entity tip)
        {
            try
            {
                cnn.updateSQL("UPDATE TIPOSOLICTRANS SET nombretipost = '" + tip.nombre_solicitud + "' WHERE idtiposolict = '" + tip.id_tipo_solicitud + "'");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deletetipo(tipo_solicitud_Entity tip)
        {
            try
            {
                cnn.deleteSQL("DELETE TIPOSOLICTRANS WHERE idtiposolict='" + tip.id_tipo_solicitud + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
