/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Empresas
    Fecha de asignación: 27/Junio
    Fecha de entrega: 09/Julio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleados_Entity
    {
        private string _idempleado;
        private string _idempresa;
        private string _idestado;
        private string _codusuario;
        private string _idrol;

        public string idempleado
        {
            get { return _idempleado; }
            set { _idempleado = value; }
        }

        public string idempresa
        {
            get { return _idempresa; }
            set { _idempresa= value; }
        }
        public string idestado
        {
            get { return _idestado; }
            set { _idestado= value; }
        }

        public string codusuario
        {
            get { return _codusuario; }
            set { _codusuario= value; }
        }

        public string idrol
        {
            get { return _idrol; }
            set { _idrol = value; }
        }
    }
}
