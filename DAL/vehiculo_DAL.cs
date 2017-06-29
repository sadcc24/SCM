﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class Vehiculo_DAL
    {
        MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");

        public void insertaVehiculo(vehiculo_Entity vehc)
        {

            cnn.insertSQL("INSERT INTO VEHICULO " +
                "(idempresa, idtipotrans, placa, modelo, chasis, linea, motor, color, marca)" +
                "VALUES(1,1, '"+vehc._placa+"', '"+vehc._modelo+"', '"+vehc._chasis+"' " +
                ", '"+vehc._linea+"', '"+vehc._motor+"', '"+vehc._color+"', '"+vehc._marca+"')");
        }

        public void actualizaVehiculo(vehiculo_Entity vehc)
        {
            cnn.updateSQL("UPDATE VEHICULO SET placa = '"+vehc._placa+"', modelo='"+vehc._modelo+"', " +
                   "chasis = '"+vehc._chasis+"', linea = '"+vehc._linea+"' , motor = '"+vehc._motor+"', color  = '"+vehc._color+"', " +
                   "marca = '"+vehc._marca+"' WHERE idtransporte = " +vehc._cod_vehiculo);
        }

        public DataTable verVehiculos()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idtransporte AS CODIGO_VEHICULO, placa AS PLACA, modelo AS MODELO, linea AS LINEA" +
                                    ", motor AS MOTOR, color as COLOR, marca AS MARCA FROM VEHICULO");
            return dtRegistros;
        }

        public  vehiculo_Entity verVehiculo(vehiculo_Entity eVhc)
        {
            vehiculo_Entity vehiculo = new vehiculo_Entity();
            DataTable dtRegistro = new DataTable();
            try
            {
                dtRegistro = cnn.getSQL("SELECT * FROM VEHICULO WHERE idtransporte = " + eVhc._cod_vehiculo);
                
                foreach (DataRow row in dtRegistro.Rows)
                {
                    foreach (DataColumn column in dtRegistro.Columns)
                    {
                     
                        vehiculo._cod_vehiculo = Convert.ToInt32(row["idtransporte"]);
                        vehiculo._placa = row["idempresa"].ToString();
                        vehiculo._placa = row["idtipotrans"].ToString();
                        vehiculo._placa = row["placa"].ToString();
                        vehiculo._modelo = row["modelo"].ToString();
                        vehiculo._chasis = row["chasis"].ToString();
                        vehiculo._linea = row["linea"].ToString();
                        vehiculo._motor = row["motor"].ToString();
                        vehiculo._color = row["color"].ToString();
                        vehiculo._marca = row["marca"].ToString();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return vehiculo;

        }
    }
}
