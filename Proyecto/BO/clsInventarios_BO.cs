using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data;
namespace BO
{
 public    class clsInventarios_BO
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :
        public DataTable vConsultarFacturas(clsInventarios_Entity producto)
        {
            DataTable dtProducto;
            clsInventarios_DAL consfacturas = new clsInventarios_DAL();
            dtProducto = consfacturas.dtFacturasPendientes(producto);
            return dtProducto;
        }

        public DataTable vConsultaUltimoID()
        {
            DataTable dtIdContrasena;
            clsInventarios_DAL conscontrasena = new clsInventarios_DAL();
            dtIdContrasena = conscontrasena.dtConsultaUltimaContrasena();
            return dtIdContrasena;
        }

        public void vInsertarEncabezadoContrasena(clsInventarios_Entity contrasena)
        {
            clsInventarios_DAL encabezadocontrainsert = new clsInventarios_DAL();
            encabezadocontrainsert.vInsertEncabezadoContrasena(contrasena);
        }

        public void vInsertarDetalleContrasena(clsInventarios_Entity contrasena)
        {
            clsInventarios_DAL detallecontrainsert = new clsInventarios_DAL();
            detallecontrainsert.vInsertaDetalleContrasena(contrasena);
        }
    }
}
