﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace DAL
{
   public class tipo_vehiculo_DAL
    {
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");

        public void inserttipovehiculo(tipo_vehiculo_Entity tip)
        {
            try
            {
                cnn.insertSQL("INSERT INTO TIPOVEHICULO (nombretipotrans, idtipocarga)values('" + tip.nombre_tipo + "', " + tip.id_tipo_carga + ")");

            }
            catch (Exception ex)
            {

            }
        }

        public DataTable verTipos()
        {
            DataTable dt = new DataTable();
            dt = cnn.getSQL("SELECT idtipotrans as Codigo, nombretipotrans as Nombre from TIPOVEHICULO");
            return dt;
        }

        public void updatetipos(tipo_vehiculo_Entity tip)
        {
            try
            {
                cnn.updateSQL("UPDATE TIPOVEHICULO SET nombretipotrans = '" + tip.nombre_tipo + "' WHERE idtipotrans = '" + tip.id_tipo_vehiculo + "'");

            }
            catch (Exception ex)
            {

            }
        }

        public void deletetipo(tipo_vehiculo_Entity tip)
        {
            try
            {
                cnn.deleteSQL("DELETE TIPOVEHICULO WHERE idtipotrans='" + tip.id_tipo_vehiculo + "'");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
