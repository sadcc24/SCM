using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
   public class estado_contrasena_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertestado(estado_contrasena_Entity est)
        {
            try
            {
                cnn.insertSQL("INSERT INTO ESTADOCONTRASENA (descripcion)values('" + est.descripcion + "')");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verEstados()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idestadocontrasena as Codigo, descripcion as Nombre from ESTADOCONTRASENA");
            return dt;
        }

        public void updateEstados(estado_contrasena_Entity est)
        {
            try
            {
                cnn.updateSQL("UPDATE ESTADOCONTRASENA SET descripcion = '" + est.descripcion + "' WHERE idestadocontrasena = '" + est.id_estado_contrasena + "'");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteEstados(estado_contrasena_Entity est)
        {
            try
            {
                cnn.deleteSQL("DELETE ESTADOCONTRASENA WHERE idestadocontrasena='" + est.id_estado_contrasena + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
