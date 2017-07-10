/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Bitácora
    Fecha de asignación: 28/Junio
    Fecha de entrega: 08/Julio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bitacora_Entity
    {
        private string _idbitacora;
        private string _idempresa;
        private string _codusuario;
        private string _idrol;
        private string _strequipo;
        private string _strfechahora;
        private string _strtabla;
        private string _straccion;

        public string idbitacora
        {
            get { return _idbitacora; }
            set { _idbitacora = value; }
        }

        public string idempresa
        {
            get { return _idempresa; }
            set { _idempresa = value; }
        }

        public string codusuario
        {
            get { return _codusuario; }
            set { _codusuario = value; }
        }

        public string idrol
        {
            get { return _idrol; }
            set { _idrol = value; }
        }

        public string strequipo
        {
            get { return _strequipo; }
            set { _strequipo = value; }
        }

        public string strfechahora
        {
            get { return _strfechahora; }
            set { _strfechahora = value; }
        }

        public string strtabla
        {
            get { return _strtabla; }
            set { _strtabla = value; }
        }

        public string straccion
        {
            get { return _straccion; }
            set { _straccion = value; }
        }
    }
}
