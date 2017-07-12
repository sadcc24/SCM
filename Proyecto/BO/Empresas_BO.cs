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
    public class Empresas_BO
    {
        public void vInsertarEmpresa(Empresas_Entity Empresa)
        {
            Empresas_DAL Empresainsert = new Empresas_DAL();
            Empresainsert.vInsertEmpresa(Empresa);
        }

        public void vModificarEmpresa(Empresas_Entity Empresa)
        {
            Empresas_DAL Empresaupdate = new Empresas_DAL();
            Empresaupdate.vModificarEmpresa(Empresa);
        }

        public void vEliminarEmpresa(Empresas_Entity Empresa)
        {
            Empresas_DAL Empresadelete = new Empresas_DAL();
            Empresadelete.vEliminarEmpresa(Empresa);
        }

        public DataTable vConsultaEmpresas()
        {
            DataTable dtEmpresas;
            Empresas_DAL Empresaconsulta = new Empresas_DAL();
            dtEmpresas = Empresaconsulta.vConsultarEmpresa();
            return dtEmpresas;

        }

        public DataTable vConsultaFiltro(Empresas_Entity Empresa)
        {
            DataTable dtEmpresas;
            Empresas_DAL Empresaconsultafiltro = new Empresas_DAL();
            dtEmpresas = Empresaconsultafiltro.vConsultarFiltro(Empresa);
            return dtEmpresas;
        }

    }
}
