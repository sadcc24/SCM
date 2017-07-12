using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class proveedores_Entity
    {
        private int _id_proveedor;
        public int id_proveedor
        {
            get { return _id_proveedor; }
            set { _id_proveedor = value; }
        }
        private string _nombre_proveedor;
        public string nombre_proveedor
        {
            get { return _nombre_proveedor; }
            set { _nombre_proveedor = value; }
        }
        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private int _telefono;
        public int telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private int _id_sede;
        public int id_sede
        {
            get { return _id_sede; }
            set { _id_sede = value; }
        }
        private string _nit;
        public string nit
        {
            get { return _nit; }
            set { _nit = value; }
        }
        private Boolean _activo;
        public Boolean activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
    }
}
