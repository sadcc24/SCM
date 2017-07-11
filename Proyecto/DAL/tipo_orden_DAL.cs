using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class tipo_orden_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void inserttipoorden(tipo_orden_Entity tip)
        {
            try
            {
                cnn.insertSQL("INSERT INTO TIPOOC (descripcion)values('" + tip.descripcion + "')");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verTipos()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idtipooc as Codigo, descripcion as Nombre from TIPOOC");
            return dt;
        }

        public void updatetipos(tipo_orden_Entity tip)
        {
            try
            {
                cnn.updateSQL("UPDATE TIPOOC SET descripcion = '" + tip.descripcion + "' WHERE idtipooc = '" + tip.id_tipo + "'");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deletetipo(tipo_orden_Entity tip)
        {
            try
            {
                cnn.deleteSQL("DELETE TIPOORDEN WHERE idtipooc='" + tip.id_tipo + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
