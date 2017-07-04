using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL
{
   public class tipo_trayecto_DAL
    {
        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        //  MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void inserttipotrayecto(tipo_trayecto_Entity tip)
        {
            try
            {
                cnn.insertSQL("INSERT INTO TIPOTRAYECTO (descripciontrayecto)values('" + tip.nombre_tipo_trayecto + "')");

            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verTipos()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idtipotrayecto as Codigo, descripciontrayecto as Nombre from TIPOTRAYECTO");
            return dt;
        }

        public void updatetipos(tipo_trayecto_Entity tip)
        {
            try
            {
                cnn.updateSQL("UPDATE TIPOTRAYECTO SET descripciontrayecto = '" + tip.nombre_tipo_trayecto + "' WHERE idtipotrayecto = '" + tip.id_tipo_trayecto + "'");

            }
            catch (Exception ex)
            {

            }
        }

        public void deletetipo(tipo_trayecto_Entity tip)
        {
            try
            {
                cnn.deleteSQL("DELETE TIPOTRAYECTO WHERE idtipotrayecto='" + tip.id_tipo_trayecto + "'");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
