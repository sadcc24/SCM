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
    public class Lineas_BO
    {
        public void vInsertarLinea(Lineas_Entity Linea)
        {
            Lineas_DAL Lineainsert = new Lineas_DAL();
            Lineainsert.vInsertLinea(Linea);
        }

        public void vModificarLinea(Lineas_Entity Linea)
        {
            Lineas_DAL Lineaupdate = new Lineas_DAL();
            Lineaupdate.vModificarLinea(Linea);
        }

        public void vEliminarLinea(Lineas_Entity Linea)
        {
            Lineas_DAL Lineadelete = new Lineas_DAL();
            Lineadelete.vEliminarLinea(Linea);
        }

        public DataTable vConsultaLineas()
        {
            DataTable dtLineas;
            Lineas_DAL Lineaconsulta = new Lineas_DAL();
            dtLineas= Lineaconsulta.vConsultarLinea();
            return dtLineas;

        }

        public DataTable vConsultaFiltro(Lineas_Entity Linea)
        {
            DataTable dtLineas;
            Lineas_DAL Lineaconsultafiltro = new Lineas_DAL();
            dtLineas= Lineaconsultafiltro.vConsultarFiltro(Linea);
            return dtLineas;
        }
    }
}
