/*  Programador: Josué Enrique Zeceña González
    Analista: Josué Enrique Zeceña González
    Comentarios: Monedas
    Fecha de asignación: 27/Junio
    Fecha de entrega: 08/Julio
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Monedas_Entity
    {
        private string _idmoneda;
        private string _strmoneda;
        private string _strsimbolo;
        private string _iactivo;

        public string idmoneda
        {
            get { return _idmoneda; }
            set { _idmoneda = value; }
        }

        public string strmoneda
        {
            get { return _strmoneda; }
            set { _strmoneda = value; }
        }

        public string strsimbolo
        {
            get { return _strsimbolo; }
            set { _strsimbolo = value; }
        }

        public string iactivo
        {
            get { return _iactivo; }
            set { _iactivo = value; }
        }
    }
}
