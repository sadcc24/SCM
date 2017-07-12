using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
   public class estado_orden_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertestado(estado_orden_Entity est)
        {
            try
            {
                cnn.insertSQL("INSERT INTO ESTADOORDEN (descripcion)values('" + est.descripcion + "')");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verEstados()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idestado as Codigo, descripcion as Nombre from ESTADOORDEN");
            return dt;
        }

        public void updateEstados(estado_orden_Entity est)
        {
            try
            {
                cnn.updateSQL("UPDATE ESTADOORDEN SET descripcion = '" + est.descripcion + "' WHERE idestado = '" + est.id_estado + "'");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteEstados(estado_orden_Entity est)
        {
            try
            {
                cnn.deleteSQL("DELETE ESTADOORDEN WHERE idestado='" + est.id_estado + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
