using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Transportistas_ST_Entity
    {
        public int codigoEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string idEmpleado { get; set; }
        public string licenciaEmpleado { get; set;}
        public int idSolicitud { get; set; }
        public int idMovimiento { get; set; }
        public int idEmpresa { get; set;  }
        
        public int idUsuario { get; set; }

        public Transportistas_ST_Entity() { }
        public Transportistas_ST_Entity(int pCodEmpleado, string pnomEmpleado, string pidEmpleado, 
            string plicencia, int pidSolicitud, int pidMovimiento, int pidEmpresa, int pidUsuario)
        {
            this.codigoEmpleado = pCodEmpleado;
            this.nombreEmpleado = pnomEmpleado;
            this.idEmpleado = pidEmpleado;
            this.licenciaEmpleado = plicencia;
            this.idSolicitud = pidSolicitud;
            this.idMovimiento = pidMovimiento;
            this.idEmpresa = pidEmpresa;
            this.idUsuario = pidUsuario;
        }

    }
}
