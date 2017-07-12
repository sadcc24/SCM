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
    public class clsTipoMovimiento_BO
    {

        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios : insertar Tipo de Movimiento
        public void vInsertarTipoMovimiento(clsTipoMovimiento_Entity tipom)
        {
            clsTipoMovimiento_DAL tipomovinsert = new clsTipoMovimiento_DAL();
            tipomovinsert.vInsertarTipoMovimiento(tipom);
        }
        // Comentarios : Eliminar tipo de movimiento
        public void vEliminarTipoMovimiento(clsTipoMovimiento_Entity tipom)
        {
            clsTipoMovimiento_DAL tipomovdelete = new clsTipoMovimiento_DAL();
            tipomovdelete.vEliminarTipoMovimiento(tipom);
        }

        // Comentarios : Consultar Catalogo de Tipo de Movimientos
        public DataTable vConsultarTipoMovimiento()
        {
            DataTable dttipos;
            clsTipoMovimiento_DAL tipomconsult = new clsTipoMovimiento_DAL();
            dttipos = tipomconsult.vConsultarTipoMovimiento();
            return dttipos;

        }
        // Comentarios : Consultar TipoMovimiento 
        public DataTable vConsultarTipoMovimiento2()
        {
            DataTable dttipos;
            clsTipoMovimiento_DAL tipomconsult = new clsTipoMovimiento_DAL();
            dttipos = tipomconsult.vConsultarTipoMovimiento2();
            return dttipos;

        }
        // Comentarios : Filtrar Tipos de Movimientos
        public DataTable vConsultaFiltro(clsTipoMovimiento_Entity tipom)
        {
            DataTable dtTiposm;
            clsTipoMovimiento_DAL tipomovfiltro = new clsTipoMovimiento_DAL();
            dtTiposm = tipomovfiltro.vConsultarFiltro(tipom);
            return dtTiposm;
        }
    }
}
