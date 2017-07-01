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
        #endregion

        #region Constructor
        public  Detalle_ST_Entity()
        {
        }

        public Detalle_ST_Entity(int pDetalle, int pProducto, int pSolicitud, int pCantidad)  
        {
            this.idDetalle = pDetalle;
            this.idProducto = pProducto;
            this.idSolicitud = pSolicitud;
            this.Cantidad = pCantidad;
        }
        #endregion

    }
}
