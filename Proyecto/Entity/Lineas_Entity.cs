using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Lineas_Entity
    {
        private string _iCodLineas;        
        private string _strDescripcion;        
        private string _iEstado;
        private string _iCondicion;

        public string iCodLineas
        {
            get { return _iCodLineas; }
            set { _iCodLineas = value; }
        }
        
        public string strDescripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        public string iEstado
        {
            get { return _iEstado; }
            set { _iEstado = value; }
        }
        public string iCondicion
        {
            get { return _iCondicion; }
            set { _iCondicion = value; }
        }
    }
}
