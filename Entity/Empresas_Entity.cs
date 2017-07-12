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
    public class Empresas_Entity
    {
        private string _idempresa;
        private string _strempresa;
        private string _iactivo;
        private string _idsede;
        private string _idmoneda;
        private string _strrazon;
        private string _strdireccion;
        private string _strtelefono;
        private string _stridentificacion;

        public string idempresa
        { 
            get { return _idempresa; }
            set { _idempresa = value; }
        }

        public string strempresa
        {
            get { return _strempresa; }
            set { _strempresa = value; }
        }

        public string iactivo
        {
            get { return _iactivo; }
            set { _iactivo = value; }
        }

        public string idsede
        {
            get { return _idsede; }
            set { _idsede = value; }
        }

        public string idmoneda
        {
            get { return _idmoneda; }
            set { _idmoneda = value; }
        }

        public string strrazon
        {
            get { return _strrazon; }
            set { _strrazon = value; }
        }

        public string strdireccion
        {
            get { return _strdireccion; }
            set { _strdireccion = value; }
        }

        public string strtelefono
        {
            get { return _strtelefono; }
            set { _strtelefono = value; }
        }

        public string stridentificacion
        {
            get { return _stridentificacion; }
            set { _stridentificacion = value; }
        }

    }
}
