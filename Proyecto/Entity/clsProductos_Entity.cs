using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public class clsProductos_Entity
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        private string _strproducto;
        private string _strcantidad;
        private string _strbodega;
        private string _strproveedor;
        private string _strtipoprod;
        private string _strmarca;
        private string _strmetodocosteo;
        private string _strlinea;
        private string _strestado;
        private string _strtamano;
        private string _strpeso;
        private string _strutamano;
        private string _strupeso;
        private string _stridprod;
        private string _strtipou;
        private string _smax;
        private string _smin;
        private string _strIdEmpresa;

        public string strProducto { get { return _strproducto; }  set { _strproducto = value; } }
        public string strCantidad { get { return _strcantidad; } set { _strcantidad = value; } }
        public string strBodega { get { return _strbodega; } set { _strbodega = value; } }
        public string strProveedor { get { return _strproveedor; } set { _strproveedor = value; } }
        public string strTipoProducto { get { return _strtipoprod; } set { _strtipoprod = value; } }
        public string strMarca { get { return _strmarca; } set { _strmarca = value; } }
        public string strMetodoCosteo { get { return _strmetodocosteo; } set { _strmetodocosteo = value; } }
        public string strLinea { get { return _strlinea; } set { _strlinea = value; } }
        public string strEstado { get { return _strestado; } set { _strestado = value; } }
        public string strTamano { get { return _strtamano; } set { _strtamano = value; } }
        public string strPeso { get { return _strpeso; } set { _strpeso = value; } }

        public string struTamano { get { return _strutamano; } set { _strutamano = value; } }
        public string struPeso { get { return _strupeso; } set { _strupeso = value; } }
        public string strIdProd { get { return _stridprod; } set { _stridprod = value; } }
        public string strtipou { get { return _strtipou; } set { _strtipou = value; } }

        public string strsmax { get { return _smax; } set { _smax = value; } }
        public string strsmin { get { return _smin; } set { _smin = value; } }
        public string strIdEmpresa { get { return _strIdEmpresa; } set { _strIdEmpresa = value; } }
    }
}
