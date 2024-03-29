﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
namespace DAL
{
  public  class clsTipoMovimiento_DAL
    {

        // Programador : Pamela Jacqueline Selman David
        // Analista : Pamela Jacqueline Selman David
        // Comentarios :

        MRP_BD cnn = Globales.cnn;
        //  MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        // MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        // Comentarios : INSERTAR TIPO MOV INV
        public void vInsertarTipoMovimiento(clsTipoMovimiento_Entity tipomovimiento)
        {
            cnn.insertSQL("INSERT INTO [dbo].[TIPOMOVIMIENTO] (descripcion,operacion,activo) VALUES ('"
                + tipomovimiento.strDescripcion + "'," + tipomovimiento.strOperacion  + ",1)");
        }

        // Comentarios : ELIMINAR TIPO MOV INV
        public void vEliminarTipoMovimiento(clsTipoMovimiento_Entity tipomovimiento)
        {
            cnn.deleteSQL("DELETE FROM [dbo].[TIPOMOVIMIENTO] WHERE IDTIPOMOVIMIENTO =" + tipomovimiento.strIdTipoMovimiento);
        }

        // Comentarios : CATALOGO TIPO MOV INV

        public DataTable vConsultarTipoMovimiento()
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT idtipomovimiento as ID , descripcion as [TIPO MOVIMIENTO], operacion as [Operacion] FROM [dbo].[TIPOMOVIMIENTO] WHERE ACTIVO = 1");
            return dtBodega;
        }

        // Comentarios : CATALOGO TIPO MOV
        public DataTable vConsultarTipoMovimiento2()
        {
            DataTable dtBodega;
            dtBodega = cnn.getSQL("SELECT idtipomovimiento as ID , descripcion , operacion as [Operacion] FROM [dbo].[TIPOMOVIMIENTO] WHERE ACTIVO = 1");
            return dtBodega;
        }
        // Comentarios :  FILTRAR CATALOGO

        public DataTable vConsultarFiltro(clsTipoMovimiento_Entity tipomovimiento)
        {
            DataTable dtBodegas;
            dtBodegas = cnn.getSQL("SELECT idtipomovimiento as ID, descripcion as [TIPO MOVIMIENTO], operacion as [Operacion] FROM [dbo].[TIPOMOVIMIENTO] WHERE ACTIVO = 1 AND descripcion like '%" + tipomovimiento.strDescripcion + "%'");
            return dtBodegas;
        }
    }
}
