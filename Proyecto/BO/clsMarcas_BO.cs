using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
namespace BO
{
   public class clsMarcas_BO
    {

        public void vInsertarMarca(clsMarcas_Entity marca)
        {
            clsMarcas_DAL marcainsert = new clsMarcas_DAL();
            marcainsert.vInsertarMarca(marca);
        }




        public DataTable vConsultarMarcas()
        {
            DataTable dtmarcas;
            clsMarcas_DAL marcasconsult = new clsMarcas_DAL();
            dtmarcas = marcasconsult.vConsultarMarcas();
            return dtmarcas;

        }

        public DataTable vConsultaFiltro(clsMarcas_Entity marcav)
        {
            DataTable marcas;
            clsMarcas_DAL marcasfiltro = new clsMarcas_DAL();
            marcas = marcasfiltro.vConsultarFiltro(marcav);
            return marcas;
        }
    }
}
