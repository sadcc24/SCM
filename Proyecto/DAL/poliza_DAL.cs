using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
   public class poliza_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertpoliza(poliza_Entity est)
        {
            try
            {
                cnn.insertSQL("INSERT INTO POLIZA (nombre, descripcion, fecha, idempresa)values('" + est.nombre + "','" + est.descripcion + "','" + est.fecha + "', " + est.idempresa +")");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        // Comentarios : ULTIMO ID DE POLIZA
        public DataTable dtConsultarUltimaPoliza()
        {
            DataTable dtContrasena;
            dtContrasena = cnn.getSQL("select IsNull(max(idpoliza), 0)   as id from POLIZA");
            return dtContrasena;
        }



    }
}
