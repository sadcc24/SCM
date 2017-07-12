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
  public  class clsBodegas_BO
    {

        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :Función para insertar nueva bodega
        public void vInsertarBodega(clsBodegas_Entity bodega) {
            clsBodegas_DAL bodegainsert = new clsBodegas_DAL();
            bodegainsert.vInsertBodega(bodega);
        }
        // Comentario : Función para Modificar Bodega
        public void vModificarBodega(clsBodegas_Entity bodega) {
            clsBodegas_DAL bodegaupdate = new clsBodegas_DAL();
            bodegaupdate.vModificarBodega(bodega);
        }
        // Comentario : Función pra eliminar Bodega
        public void vEliminarBodega(clsBodegas_Entity bodega) {
            clsBodegas_DAL bodegadelete = new clsBodegas_DAL();
            bodegadelete.vEliminarBodega(bodega);
        }
        // Comentario: Función para consultar Catalogo de Bodegas
        public DataTable vConsultaBodegas() {
            DataTable dtbodegas;
            clsBodegas_DAL bodegaconsult = new clsBodegas_DAL();
            dtbodegas =    bodegaconsult.vConsultarBodega();
            return dtbodegas;

        }
        // Función para consultar bodegas con filtro.
        public DataTable vConsultaFiltro(clsBodegas_Entity bodega) {
            DataTable dtBodega;
            clsBodegas_DAL bodegaconsultfiltro = new clsBodegas_DAL();
            dtBodega = bodegaconsultfiltro.vConsultarFiltro(bodega);
            return dtBodega;
        }
    }
}
