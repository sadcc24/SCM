using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public class clsMovimientosInventario_Entity
    {

        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David

        private string _strIdTipoMovimiento;
        private string _iIdBodega;
        private string _strFecha;
        private string _idmoneda;
        private string _strdocref;
        private string _strIdProducto;
        private string _strCantidad;
        private string _strCosto;
        private string _strIdMovimiento;

        public string strIdTipoMovimiento { get { return _strIdTipoMovimiento; } set { _strIdTipoMovimiento = value; } }
        public string strIdBodega { get { return _iIdBodega; } set { _iIdBodega = value; } }
        public string strFecha { get { return _strFecha; } set { _strFecha = value; } }

        public string strIdMoneda { get { return _idmoneda; } set { _idmoneda = value; } }
        public string strDocRef { get { return _strdocref; } set { _strdocref = value; } }
        public string strIdProducto { get { return _strIdProducto; } set { _strIdProducto = value; } }

        public string strCantidad { get { return _strCantidad; } set { _strCantidad = value; } }

        public string strCosto { get { return _strCosto; } set { _strCosto = value; } }
        public string strIdMovimiento { get { return _strIdMovimiento; } set { _strIdMovimiento = value; } }

    }
}
