﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class estado_solicitud_Entity
    {
        private int _id_estado_solicitud;
        public int id_estado_solicitud
        {
            get { return _id_estado_solicitud; }
            set { _id_estado_solicitud = value; }
        }
        private string _nombre_solicitud;
        public string nombre_solicitud
        {
            get { return _nombre_solicitud; }
            set { _nombre_solicitud = value; }
        }
    }
}
