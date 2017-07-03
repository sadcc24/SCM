using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class clsTipoMovimiento_Entity
    {

        private string _strDescripcion;
        private string _strOperacion;

        public string strDescripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        public string strOperacion
        {
            get { return _strOperacion; }
            set { _strOperacion = value; }
        }
    }
}
