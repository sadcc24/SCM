using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class clsInventarios_Entity
    {


        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :


        private string _strIdProveedor;
        private string _strBodega;
        private string _strIdFactura;
        private string _strIdContrasena;
        private string _strmonto;
        private string _strIdMovimiento;

        public string strIdProveedor { get { return _strIdProveedor; } set { _strIdProveedor = value; } }
        public string strBodega { get { return _strBodega; } set { _strBodega = value; } }

        public string strIdFactura { get { return _strIdFactura; } set { _strIdFactura = value; } }
        public string strIdContrasena { get { return _strIdContrasena; } set { _strIdContrasena = value; } }
        public string strmonto { get { return _strmonto; } set { _strmonto = value; } }
        public string strIdMovimiento { get { return _strIdMovimiento; } set { _strIdMovimiento = value; } }


    }
}
