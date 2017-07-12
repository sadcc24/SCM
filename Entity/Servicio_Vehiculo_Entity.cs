using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio_Vehiculo_Entity
    {
        /*
         * [idtransporte] [int] NOT NULL,
	        [idordenserv] [int] IDENTITY(1,1) NOT NULL,
	        [facturataller] [varchar](50) NULL,
	        [fechaservicio] [datetime] NULL,
	        [fechaproximoservicio] [datetime] NULL,
	        [kmsactuales] [numeric](10, 3) NULL,
	        [kmsproximoservicio] [numeric](10, 3) NULL,
	        [monto] [decimal](10, 2) NULL,
	        [idAutorizacion] [int] NULL,
	        [idtiposerviciovh] [int] NOT NULL,
	        [idmovimiento] [int] NULL,
         * */
        
        public int idtransporte { get; set; }
        public int idorden {get; set;}
        public string factura { get; set; }
        public string fecha { get; set; }
        public string fechaprox { get; set; }
        public decimal kmsactual { get; set; }
        public decimal kmsprox { get; set; }
        public decimal monto { get; set; }
        public int idAutorizacion { get; set; }
        public int idTipoServicio { get; set; }

        public Servicio_Vehiculo_Entity() { }
        public Servicio_Vehiculo_Entity(int pIdTransporte, int pIdOrden, string pFactura, string pFecha, string pFechaprox, decimal pKms,
            decimal pKmsprox, decimal pMonto, int pidAut, int pidTipoServicio)
        {
            this.idtransporte = pIdTransporte;
            this.idorden = pIdOrden;
            this.factura = pFactura;
            this.fecha = pFecha;
            this.fechaprox = pFechaprox;
            this.kmsactual = pKms;
            this.kmsprox = pKmsprox;
            this.monto = pMonto;
            this.idAutorizacion = pidAut;
            this.idTipoServicio = pidTipoServicio;
        }

    }
}
