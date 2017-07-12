using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class poliza_Entity
    {
        private int _idpoliza;
        private string _nombre;
        private string _descripcion;
        private string _fecha;
        private int _idempresa;

        public int idpoliza
        {
            get { return _idpoliza; }
            set { _idpoliza = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public int idempresa
        {
            get { return _idempresa; }
            set { _idempresa = value; }
        }

        
    }
}
