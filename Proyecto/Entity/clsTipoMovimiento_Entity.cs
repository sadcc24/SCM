using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class clsTipoMovimiento_Entity
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :
        private string _strDescripcion;
        private string _strOperacion;
        private string _strIdTipoMovimiento;
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

        public string strIdTipoMovimiento
        {
            get { return _strIdTipoMovimiento; }
            set { _strIdTipoMovimiento = value; }
        }
    }
}
