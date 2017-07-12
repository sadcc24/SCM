using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
   public class detalle_poliza_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertdetallepoliza(detalle_poliza_Entity est)
        {
            try
            {
                cnn.insertSQL("INSERT INTO DETALLEPOLIZA (idPoliza, idCuenta, clasificacion, valor)values(" + est.idpoliza + "," + est.idcuenta + ",'" + est.clasificacion + "', " + est.total + ")");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }


    }
}
