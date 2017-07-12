using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class tipo_vehiculo_Entity
    {
        private int _id_tipo_vehiculo;
        public int id_tipo_vehiculo
        {
            get { return _id_tipo_vehiculo; }
            set { _id_tipo_vehiculo = value; }
        }
        private string _nombre_tipo;
        public string nombre_tipo
        {
            get { return _nombre_tipo; }
            set { _nombre_tipo = value; }
        }
        private int _id_tipo_carga;
        public int id_tipo_carga
        {
            get { return _id_tipo_carga; }
            set { _id_tipo_carga = value; }
        }
    }
}
