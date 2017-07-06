using System;
using System.Data;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
   public class tipo_cargamento_DAL
    {
        MRP_BD cnn = Globales.cnn;

        public void inserttipocargamento(tipo_cargamento_Entity tip)
        {
            try
            {
                cnn.insertSQL("INSERT INTO TIPO_CARGAMENTO (nombretipocarga)values('" + tip.nombre_tipo_cargamento + "')");

            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verTipos()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idtipocarga as Codigo, nombretipocarga as Nombre from TIPO_CARGAMENTO");
            return dt;
        }

        public void updatetipos(tipo_cargamento_Entity tip)
        {
            try
            {
                cnn.updateSQL("UPDATE TIPO_CARGAMENTO SET nombretipocarga = '" + tip.nombre_tipo_cargamento + "' WHERE idtipocarga = '" + tip.id_tipo_cargamento + "'");

            }
            catch (Exception ex)
            {

            }
        }

        public void deletetipos(tipo_cargamento_Entity tip)
        {
            try
            {
                cnn.deleteSQL("DELETE TIPO_CARGAMENTO WHERE idtipocarga='" + tip.id_tipo_cargamento + "'");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
