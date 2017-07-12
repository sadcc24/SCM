using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL
{
   public class tipo_vehiculo_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void inserttipovehiculo(tipo_vehiculo_Entity tip)
        {
            try
            {
                cnn.insertSQL("INSERT INTO TIPOVEHICULO (nombretipotrans)values('" + tip.nombre_tipo + "')");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verTipos()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idtipotrans as Codigo, nombretipotrans as Nombre from TIPOVEHICULO");
            return dt;
        }

        public void updatetipos(tipo_vehiculo_Entity tip)
        {
            try
            {
                cnn.updateSQL("UPDATE TIPOVEHICULO SET nombretipotrans = '" + tip.nombre_tipo + "' WHERE idtipotrans = '" + tip.id_tipo_vehiculo + "'");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deletetipo(tipo_vehiculo_Entity tip)
        {
            try
            {
                cnn.deleteSQL("DELETE TIPOVEHICULO WHERE idtipotrans='" + tip.id_tipo_vehiculo + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
