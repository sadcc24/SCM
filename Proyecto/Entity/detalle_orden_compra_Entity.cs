using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class detalle_orden_compra_Entity
    {
        private int _id_detalle_orden_compra;
        public int id_detalle_orden_compra
        {
            get { return _id_detalle_orden_compra; }
            set { _id_detalle_orden_compra = value; }
        }
      
        private int _cantidad;
        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private decimal _precio_unitario;
        public decimal precio_unitario
        {
            get { return _precio_unitario; }
            set { _precio_unitario = value; }
        }
        private decimal _total;
        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
        
        private int _id_producto;
        public int id_producto
        {
            get { return _id_producto; }
            set { _id_producto = value; }
        }

        private int _id_orden_compra;
        public int id_orden_compra
        {
            get { return _id_orden_compra; }
            set { _id_orden_compra = value; }
        }
        
    }
}
