using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class factura_proveedores_Entity
    {


        // Programador : PAMELA SELMAN Y JOSE ANDRES CHAJON
        // Analista : PAMELA SELMAN Y JOSE ANDRES CHAJON
        private int _id_factura;
        public int id_factura
        {
            get { return _id_factura; }
            set { _id_factura = value; }
        }
        private string _corrfactura;
        public string corrfactura
        {
            get { return _corrfactura; }
            set { _corrfactura = value; }
        }
        private string _id_serie;
        public string id_serie
        {
            get { return _id_serie; }
            set { _id_serie = value; }
        }
        private decimal _total;
        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
        private decimal _saldo;
        public decimal saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        private string _fecha;
        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private int _id_proveedor;
        public int id_proveedor
        {
            get { return _id_proveedor; }
            set { _id_proveedor = value; }
        }
        
        private int _id_bodega;
        public int id_bodega
        {
            get { return _id_bodega; }
            set { _id_bodega = value; }
        }
        private int _id_movimiento;
        public int id_movimiento
        {
            get { return _id_movimiento; }
            set { _id_movimiento = value; }
        }
        private int _id_estado_factura;
        public int id_estado_factura
        {
            get { return _id_estado_factura; }
            set { _id_estado_factura = value; }
        }


        private string _strOC;
        public string strOC
        {
            get { return _strOC; }
            set { _strOC = value; }
        }

    }
}
