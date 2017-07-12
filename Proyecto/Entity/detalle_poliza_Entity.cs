using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class detalle_poliza_Entity
    {
        private int _idpoliza;
        private int _idcuenta;
        private string _clasificacion;
        private decimal _total;

        public int idpoliza
        {
            get { return _idpoliza; }
            set { _idpoliza = value; }
        }

        public int idcuenta
        {
            get { return _idcuenta; }
            set { _idcuenta = value; }
        }

        public string clasificacion
        {
            get { return _clasificacion; }
            set { _clasificacion = value; }
        }

        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
