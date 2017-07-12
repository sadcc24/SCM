/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Bitácora
    Fecha de asignación: 28/Junio
    Fecha de entrega: 08/Julio
*/
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
    public class Bitacora_BO
    {
        public DataTable vConsultaBitacora()
        {
            DataTable dtBitacora;
            Bitacora_DAL Bitacoraconsulta = new Bitacora_DAL();
            dtBitacora = Bitacoraconsulta.vConsultarBitacora();
            return dtBitacora;

        }

        public DataTable vConsultaFiltro(Bitacora_Entity Bitacora)
        {
            DataTable dtBitacora;
            Bitacora_DAL Bitacoraconsultafiltro = new Bitacora_DAL();
            dtBitacora = Bitacoraconsultafiltro.vConsultarFiltro(Bitacora);
            return dtBitacora;
        }
    }
}
