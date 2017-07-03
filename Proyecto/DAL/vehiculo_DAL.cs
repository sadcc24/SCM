using System;
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
        //MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        MRP_BD cnn = new MRP_BD("sa", "SAD2017", "SAD2017", "PJSELMAN\\SAD2017");
        //  MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017V1", @"DESKTOP-F4L56EU\SQLEXPRESS");


        public void insertaVehiculo(vehiculo_Entity vehc)
        {

            cnn.insertSQL("INSERT INTO VEHICULO " +
                "(idempresa, idtipotrans, placa, modelo, chasis, linea, motor, color, marca)" +
                "VALUES(1, "+vehc._tipovehiculo +", '"+vehc._placa+"', '"+vehc._modelo+"', '"+vehc._chasis+"' " +
                ", '"+vehc._linea+"', '"+vehc._motor+"', '"+vehc._color+"', '"+vehc._marca+"')");
        }

        public void actualizaVehiculo(vehiculo_Entity vehc)
        {
            cnn.updateSQL("UPDATE VEHICULO SET placa = '"+vehc._placa+"', modelo='"+vehc._modelo+"', " +
                   " chasis = '"+vehc._chasis+"', linea = '"+vehc._linea+"' , motor = '"+vehc._motor+"', color  = '"+vehc._color+"', " +
                   " marca = '"+vehc._marca+"' , idtipotrans = " + vehc._tipovehiculo + 
                   " WHERE idtransporte = " +vehc._cod_vehiculo);
        }

        public DataTable verVehiculos(vehiculo_Entity vh)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idtransporte AS CODIGO_VEHICULO, placa AS PLACA, modelo AS MODELO, linea AS LINEA," +
                                    "motor AS MOTOR, color as COLOR, marca AS MARCA, TV.nombretipotrans as TIPO_VEHICULO " +
                                    " FROM VEHICULO V" +
                                    " JOIN TIPOVEHICULO TV ON V.idtipotrans = TV.idtipotrans" +
                                    " WHERE V.idtransporte = ISNULL(null, V.idtransporte) " +
                                    " AND V.placa LIKE ISNULL('%" + vh._placa + "%', V.placa) " +
                                    " AND V.modelo LIKE ISNULL('%" + vh._modelo + "%', V.modelo) " +
                                    " AND V.linea LIKE ISNULL('%" + vh._linea + "%', V.linea) " +
                                    " AND V.motor LIKE ISNULL('%" + vh._motor + "%', V.motor) " +
                                    " AND V.color LIKE ISNULL('%" + vh._motor + "%', V.color) " +
                                    " AND V.marca LIKE ISNULL('%" + vh._marca + "%', V.marca) " +
                                    " AND V.idtipotrans = CASE "+vh._tipovehiculo +" WHEN 0 THEN V.idtipotrans ELSE "+vh._tipovehiculo+" END");
                                    //" AND V.idtipotrans = ISNULL(" +vh._tipovehiculo+", V.idtipotrans)");
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
        #region Funciones y Metodos
        public DataTable verTipoVehiculo()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM TIPOVEHICULO");
            return dtRegistros;
        }
        #endregion
    }
}
