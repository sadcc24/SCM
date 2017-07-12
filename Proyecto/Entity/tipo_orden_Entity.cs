using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class tipo_orden_Entity
    {
        private int _id_tipo;
        public int id_tipo
        {
            get { return _id_tipo; }
            set { _id_tipo = value; }
        }
        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
