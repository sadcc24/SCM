using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class estado_contrasena_Entity
    {
        private int _id_estado_contrasena;
        public int id_estado_contrasena
        {
            get { return _id_estado_contrasena; }
            set { _id_estado_contrasena = value; }
        }
        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
