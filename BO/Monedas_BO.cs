/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Monedas
    Fecha de asignación: 27/Junio
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
    public class Monedas_BO
    {
        public void vInsertarMoneda(Monedas_Entity Moneda)
        {
            Monedas_DAL Monedainsert = new Monedas_DAL();
            Monedainsert.vInsertMoneda(Moneda);
        }

        public void vModificarMoneda(Monedas_Entity Moneda)
        {
            Monedas_DAL Monedaupdate = new Monedas_DAL();
            Monedaupdate.vModificarMoneda(Moneda);
        }

        public void vEliminarMoneda(Monedas_Entity Moneda)
        {
            Monedas_DAL Monedadelete = new Monedas_DAL();
            Monedadelete.vEliminarMoneda(Moneda);
        }

        public DataTable vConsultaMonedas()
        {
            DataTable dtMonedas;
            Monedas_DAL Monedaconsulta = new Monedas_DAL();
            dtMonedas = Monedaconsulta.vConsultarMoneda();
            return dtMonedas;

        }

        public DataTable vConsultaFiltro(Monedas_Entity Moneda)
        {
            DataTable dtMonedas;
            Monedas_DAL Monedaconsultafiltro = new Monedas_DAL();
            dtMonedas = Monedaconsultafiltro.vConsultarFiltro(Moneda);
            return dtMonedas;
        }

    }
}
