using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class tipo_trayecto_Entity
    {
        private int _id_tipo_trayecto;
        public int id_tipo_trayecto
        {
            get { return _id_tipo_trayecto; }
            set { _id_tipo_trayecto = value; }
        }
        private string _nombre_tipo_trayecto;
        public string nombre_tipo_trayecto
        {
            get { return _nombre_tipo_trayecto; }
            set { _nombre_tipo_trayecto = value; }
        }
    }
}
