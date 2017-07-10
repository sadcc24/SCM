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
    public class Empleados_BO
    {
        public void vInsertarEmpleado(Empleados_Entity Empleado)
        {
            Empleados_DAL Empleadoinsert = new Empleados_DAL();
            Empleadoinsert.vInsertEmpleado(Empleado);
        }

        public void vEliminarEmpleado(Empleados_Entity Empleado)
        {
            Empleados_DAL Empleadodelete = new Empleados_DAL();
            Empleadodelete.vEliminarEmpleado(Empleado);
        }

        public DataTable vConsultaEmpleados()
        {
            DataTable dtEmpleados;
            Empleados_DAL Empleadoconsulta = new Empleados_DAL();
            dtEmpleados = Empleadoconsulta.vConsultarEmpleado();
            return dtEmpleados;
        }

        public DataTable vConsultaFiltro(Empleados_Entity Empleado)
        {
            DataTable dtEmpleados;
            Empleados_DAL Empleadoconsultafiltro = new Empleados_DAL();
            dtEmpleados = Empleadoconsultafiltro.vConsultarFiltro(Empleado);
            return dtEmpleados;
        }
    }
}
