using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class orden_compra_Entity
    {
        private int _id_orden_compra;
        public int id_orden_compra
        {
            get { return _id_orden_compra; }
            set { _id_orden_compra = value; }
        }
        private string _observacion;
        public string observaacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }
        private decimal _total;
        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        private DateTime _fecha_creacion;
        public DateTime fecha_creacion
        {
            get { return _fecha_creacion; }
            set { _fecha_creacion = value; }
        }
        private int _id_sede;
        public int id_sede
        {
            get { return _id_sede; }
            set { _id_sede = value; }
        }
        private int _id_empresa;
        public int id_empresa
        {
            get { return _id_empresa; }
            set { _id_empresa = value; }
        }
        private int _id_centro;
        public int id_centro
        {
            get { return _id_centro; }
            set { _id_centro = value; }
        }
        private int _id_bodega;
        public int id_bodega
        {
            get { return _id_bodega; }
            set { _id_bodega = value; }
        }
        private int _id_proveedor;
        public int id_proveedor
        {
            get { return _id_proveedor; }
            set { _id_proveedor = value; }
        }
        private int _id_moneda;
        public int id_moneda
        {
            get { return _id_moneda; }
            set { _id_moneda = value; }
        }
        private int _id_estado;
        public int id_estado
        {
            get { return _id_estado; }
            set { _id_estado = value; }
        }
        private int _id_tipo_oc;
        public int id_tipo_oc
        {
            get { return _id_tipo_oc; }
            set { _id_tipo_oc = value; }
        }
        private int _id_documento;
        public int id_documento
        {
            get { return _id_documento; }
            set { _id_documento = value; }
        }
        private int _id_cuenta;
        public int id_cuenta
        {
            get { return _id_cuenta; }
            set { _id_cuenta = value; }
        }
        private DateTime _fecha_vencimiento;
        public DateTime fecha_vencimiento
        {
            get { return _fecha_vencimiento; }
            set { _fecha_vencimiento = value; }
        }
    }
}
