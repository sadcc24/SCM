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
using Entity;
using System.Data;

namespace DAL
{
    public class Empresas_DAL
    {
        public void vInsertEmpresa(Empresas_Entity Empresa)
        {
            Globales.cnn.insertSQL("INSERT INTO [dbo].[Empresa] (nombre_empresa,activo,idsede,idmoneda,razonsocial,direccion,telefono,identificaciontributaria) VALUES ('"
                + Empresa.strempresa + "','" + Empresa.iactivo+ "','" + Empresa.idsede+ "','" + Empresa.idmoneda + "','" + Empresa.strrazon + "','" + Empresa.strdireccion + "','" + Empresa.strtelefono + "','" + Empresa.stridentificacion+ "')");
        }

        public void vModificarEmpresa(Empresas_Entity Empresa)
        {
            Globales.cnn.updateSQL("UPDATE [dbo].[Empresa] SET nombre_empresa = '" + Empresa.strempresa + "', activo = '" + Empresa.iactivo + "', idsede = '" + int.Parse(Empresa.idsede) + "', idmoneda = '" + int.Parse(Empresa.idmoneda) + "', razonsocial = '" + Empresa.strrazon + "', direccion = '" + Empresa.strdireccion + "', telefono = '" + Empresa.strtelefono + "', identificaciontributaria = '" + Empresa.stridentificacion + "'  WHERE idempresa = '" + Empresa.idempresa + "'");
        }

        public void vEliminarEmpresa(Empresas_Entity Empresa)
        {
            Globales.cnn.updateSQL("UPDATE [dbo].[Empresa] SET activo = 0 WHERE idempresa =" + Empresa.idempresa);
        }

        public DataTable vConsultarEmpresa()
        {
            DataTable dtEmpresa;
            dtEmpresa = Globales.cnn.getSQL("SELECT idempresa as ID, nombre_empresa as Empresa, sede.idsede as 'ID Sede', sede.nombre_sede as Sede, moneda.idmoneda as 'ID Moneda', moneda.nombre_moneda as Moneda, razonsocial as 'Razón Social', direccion as Dirección, telefono as Teléfono, identificaciontributaria as 'ID Tributario' FROM [dbo].[Empresa] INNER JOIN SEDE ON Empresa.idsede = Sede.idsede INNER JOIN MONEDA ON Empresa.idmoneda = Moneda.idmoneda WHERE empresa.activo = 1");
            return dtEmpresa;
        }

        public void vConsultarEmpresa(Empresas_Entity Empresa)
        {
            Globales.cnn.getSQL("SELECT * FROM [dbo].[Empresa] INNER JOIN SEDE ON Empresa.idsede = Sede.idsede INNER JOIN MONEDA ON Empresa.idmoneda = Moneda.idmoneda  WHERE Activo = 1 and idempresa=" + Empresa.idempresa);
        }

        public DataTable vConsultarFiltro(Empresas_Entity Empresa)
        {
            DataTable dtEmpresa;
            dtEmpresa = Globales.cnn.getSQL("SELECT * FROM [dbo].[Empresa] INNER JOIN SEDE ON Empresa.idsede = Sede.idsede INNER JOIN MONEDA ON Empresa.idmoneda = Moneda.idmoneda  WHERE nombre_empresa like '%" + Empresa.strempresa + "%'");
            return dtEmpresa;
        }
    }
}
