using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GatosTransportes_Entity
    {
        public int idDetGasto { get; set; }
        public decimal totalGasto { get; set; }
        public string fechafactura { get; set; }
        public string Notas { get; set; }
        public int idGasto { get; set; }
        public int idtransporte { get; set; }
        public int idSolicitud { get; set; }
        public int idMovimiento { get; set; }
        public int idTipoGasto { get; set; }
        public decimal kms { get; set; }
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public decimal gastoTotal { get; set; }
        public string factura { get; set; }
        public int idAutoriza { get; set; }
        public decimal gastoPivote { get; set; }

        public GatosTransportes_Entity() { }
        public GatosTransportes_Entity(int pidDetGasto, decimal pidTotal, string pfechaFactura, string pNotas,
            int pidGasto, int pidtransporte, int pidSolicitud, int pidMovimiento, int pidTipoGAsto, decimal pGastoPivote,
            decimal pkms, int pidEmpresa, int pidUsuario, decimal pgastoTotal, string pfactura, int pidAutoriza)
        {
            this.idDetGasto = pidGasto;
            this.totalGasto = pidTotal;
            this.fechafactura = pfechaFactura;
            this.Notas = pNotas;
            this.idGasto = pidGasto;
            this.idtransporte = pidtransporte;
            this.idSolicitud = pidSolicitud;
            this.idMovimiento = pidMovimiento;
            this.idTipoGasto = pidTipoGAsto;
            this.kms = pkms;
            this.idEmpresa = pidEmpresa;
            this.idUsuario = pidUsuario;
            this.gastoTotal = pgastoTotal;
            this.factura = pfactura;
            this.idAutoriza = pidAutoriza;
            this.gastoPivote = pGastoPivote;
        }
    }
}
