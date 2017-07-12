using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;


namespace BO
{
  public  class factura_proveedores_BO
    {

        // Programador : Pamela Selman  y José Andrés Chajón
        // Analista : Pamela Jacqueline y José Andrés Chajón


        // Comentarios :insertar nueva factura
        public void insertfactura(factura_proveedores_Entity prov)
        {
            try
            {
                factura_proveedores_DAL proveedor = new factura_proveedores_DAL();
                proveedor.insertfactura(prov);
            }
            catch (Exception ex)
            {

            }
        }
        // Comentarios : Ver facturas ingresadas
        public DataTable verFacturas(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            factura_proveedores_DAL prov = new factura_proveedores_DAL();
            dt = prov.verFacturas(fac);
            return dt;
        }

        // Comentario: Consultar OC AUTORIZADAS POR CONTA
        public DataTable verOC(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            factura_proveedores_DAL prov = new factura_proveedores_DAL();
            dt = prov.verOC(fac);
            return dt;
        }
        // Comentarios : detalle factura
        public DataTable detalleFactura(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            factura_proveedores_DAL prov = new factura_proveedores_DAL();
            dt = prov.detalleFactura(fac);
            return dt;
        }

        //Comentario: Detalle OC
        public DataTable detalleOC(factura_proveedores_Entity fac)
        {
            DataTable dt = new DataTable();
            factura_proveedores_DAL prov = new factura_proveedores_DAL();
            dt = prov.detalleOC(fac);
            return dt;
        }

        // Comentarios :eliminar factura
        public void deletefactura(factura_proveedores_Entity prov)
        {
            try
            {
                factura_proveedores_DAL proveedor = new factura_proveedores_DAL();
                proveedor.deletefactura(prov);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
