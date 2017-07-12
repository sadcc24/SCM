using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Detalle_ST_Entity
    {
        #region Atributos y Encapsulamiento
        
        public int idDetalle { get; set; }
        public int idProducto{ get; set; }
        public int idSolicitud { get; set; }
        public int Cantidad { get; set; }
        public int idBodega {get; set;}
        public int idMovimiento{get;set;}
        public string fecha {get;set;}
        public int idTipoMov {get; set;}
        public int idMoneda {get; set;}
        public string refMovimiento {get;set;}
        public decimal costo {get; set;}
        public decimal precio { get; set; }
        public int CantidadReal { get; set; }

        #endregion

        #region Constructor
        public  Detalle_ST_Entity()
        {
        }

        public Detalle_ST_Entity(int pDetalle, int pProducto, int pSolicitud, int pCantidad, int pidBodega, int pidMovimiento, string pfecha,
            int pidTipoMov, int pidMoneda, string prefMovimiento, decimal pCosto, decimal pPrecio, int pCantidadReal)  
        {
            this.idDetalle = pDetalle;
            this.idProducto = pProducto;
            this.idSolicitud = pSolicitud;
            this.Cantidad = pCantidad;
            this.idBodega = pidBodega;
            this.idMovimiento = pidMovimiento;
            this.fecha = pfecha;
            this.idTipoMov = pidTipoMov;
            this.idMoneda = pidMoneda;
            this.refMovimiento = prefMovimiento;
            this.costo = pCosto;
            this.precio = pPrecio;
            this.CantidadReal = pCantidadReal;

        }
        #endregion

    }
}
