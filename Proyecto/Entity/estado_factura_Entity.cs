using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class estado_factura_Entity
    {
        private int _id_estado;
        public int id_estado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }
        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
