using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
   public class estado_factura_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void insertestado(estado_factura_Entity est)
        {
            try
            {
                cnn.insertSQL("INSERT INTO ESTADOFACTURA (descripcion)values('" + est.descripcion + "')");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public DataTable verEstados()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idestadofactura as Codigo, descripcion as Nombre from ESTADOFACTURA");
            return dt;
        }

        public void updateEstados(estado_factura_Entity est)
        {
            try
            {
                cnn.updateSQL("UPDATE ESTADOFACTURA SET descripcion = '" + est.descripcion + "' WHERE idestadofactura = '" + est.id_estado + "'");

            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }

        public void deleteEstados(estado_factura_Entity est)
        {
            try
            {
                cnn.deleteSQL("DELETE ESTADOORDEN WHERE idestadofactura='" + est.id_estado + "'");
            }
            catch (Exception ex)
            {
                String error = ex.ToString();
            }
        }
    }
}
