﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
namespace DAL
{
  public  class clsMarcas_DAL
    {
        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        MRP_BD cnn = Globales.cnn;
        // MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        // MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        // Comentarios :Insertar Marca
        public void vInsertarMarca(clsMarcas_Entity marcas)
        {
            cnn.insertSQL("INSERT INTO [dbo].[MARCA] (descripcion) VALUES ('"
                + marcas.strDescripcion + "')");
        }
        // Comentarios : Eliminar marca cuando no tenga llaves
        public void vEliminarMarca(clsMarcas_Entity marcas)
        {
            cnn.deleteSQL("DELETE FROM [dbo].[MARCA] where idmarca =" + marcas.strIdMarca);
        }


        // Comentarios : Consultar catalogo marcas
        public DataTable vConsultarMarcas()
        {
            DataTable dtMarcas;
            dtMarcas = cnn.getSQL("SELECT idmarca as ID, descripcion as [MARCA] FROM [dbo].[MARCA] ");
            return dtMarcas;
        }

        // Comentarios : filtrar marcas
        public DataTable vConsultarFiltro(clsMarcas_Entity marca)
        {
            DataTable dtMarcas;
            dtMarcas = cnn.getSQL("SELECT idmarca as ID, descripcion as [MARCA] FROM [dbo].[MARCA] WHERE descripcion like '%" + marca.strDescripcion + "%'");
            return dtMarcas;
        }
    }
}
