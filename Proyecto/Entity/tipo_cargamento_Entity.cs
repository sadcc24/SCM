using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class tipo_cargamento_Entity
    {
        private int _id_tipo_cargamento;
        public int id_tipo_cargamento
        {
            get { return _id_tipo_cargamento; }
            set { _id_tipo_cargamento = value; }
        }
        private string _nombre_tipo_cargamento;
        public string nombre_tipo_cargamento
        {
            get { return _nombre_tipo_cargamento; }
            set { _nombre_tipo_cargamento = value; }
        }
    }
}
