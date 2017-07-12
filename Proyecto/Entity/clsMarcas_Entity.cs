using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class clsMarcas_Entity
    {

        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        private string _strDescripcion;
        private string _strIdMarca;
        public string strDescripcion
        {
            get { return _strDescripcion; }
            set { _strDescripcion = value; }
        }

        public string strIdMarca
        {
            get { return _strIdMarca; }
            set { _strIdMarca = value; }
        }
    }
}
