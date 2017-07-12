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
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("admin", "@umg2017", "SAD2017", "ZGHP");
        //MRP_BD cnn = new MRP_BD("sa", "ja", "SAD2017", @"LAPTOP-BN23V9UD\SQLEXPRESS");
        //MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");
        //MRP_BD cnn = new MRP_BD("r40usr", "Inter$2013", "SAD2017", "SDESRUTA40");


        public void insertaVehiculo(vehiculo_Entity vehc)
        {

            cnn.insertSQL("INSERT INTO VEHICULO " +
                "(idempresa, idtipotrans, placa, modelo, chasis, linea, motor, color, marca, kilometraje)" +
                "VALUES("+vehc._empresa +", "+vehc._tipovehiculo +", '"+vehc._placa+"', '"+vehc._modelo+"', '"+vehc._chasis+"' " +
                ", '"+vehc._linea+"', '"+vehc._motor+"', '"+vehc._color+"', '"+vehc._marca+"', "+vehc._kms+")");
        }

        public void actualizaVehiculo(vehiculo_Entity vehc)
        {
            cnn.updateSQL("UPDATE VEHICULO SET placa = '"+vehc._placa+"', modelo='"+vehc._modelo+"', " +
                   " chasis = '"+vehc._chasis+"', linea = '"+vehc._linea+"' , motor = '"+vehc._motor+"', color  = '"+vehc._color+"', " +
                   " marca = '"+vehc._marca+"' , idtipotrans = " + vehc._tipovehiculo + ", kilometraje = " + vehc._kms +
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

        public  vehiculo_Entity verVehiculo(int codigo)
        {
            vehiculo_Entity vehiculo = new vehiculo_Entity();
            DataTable dtRegistro = new DataTable();

            dtRegistro = cnn.getSQL("SELECT V.*, TP.nombretipotrans, S.kmsproximoservicio " +
                                            " FROM VEHICULO V " +
                                            " JOIN TIPOVEHICULO TP ON V.idtipotrans = TP.idtipotrans " + 
                                            " LEFT JOIN (SELECT TOP 1 kmsproximoservicio,  idtransporte  " +
		                                                 " FROM MORDENSERVICIOV " +
		                                                 " WHERE idtransporte =  " + codigo +
		                                                 " ORDER BY fechaservicio) S ON V.idtransporte = S.idtransporte " +
                                            " WHERE V.idtransporte = " + codigo);
                
                foreach (DataRow row in dtRegistro.Rows)
                {
                    foreach (DataColumn column in dtRegistro.Columns)
                    {
                     
                        vehiculo._cod_vehiculo = Convert.ToInt32(row["idtransporte"]);
                        //vehiculo._placa = row["idempresa"].ToString();
                        vehiculo._tipovehiculo = Convert.ToInt32(row["idtipotrans"]);
                        vehiculo._placa = row["placa"].ToString();
                        vehiculo._modelo = row["modelo"].ToString();
                        vehiculo._chasis = row["chasis"].ToString();
                        vehiculo._linea = row["linea"].ToString();
                        vehiculo._motor = row["motor"].ToString();
                        vehiculo._color = row["color"].ToString();
                        vehiculo._marca = row["marca"].ToString();
                        if (row["kilometraje"] == DBNull.Value)
                        {
                            vehiculo._kms = 0.0; 
                        }
                        else { 
                            vehiculo._kms = Convert.ToDouble(row["kilometraje"]); 
                        }
                        vehiculo._nombretipov = row["nombretipotrans"].ToString();
                        if (row["kmsproximoservicio"] == DBNull.Value)
                        {
                            vehiculo._kmsprox = 0;
                        }
                        else
                        {
                            vehiculo._kmsprox = Convert.ToDecimal(row["kmsproximoservicio"]); 
                        }
                    }
                }
            
        
            return vehiculo;

        }

        #region Seguimiento de SolicituD
        //Muestra todos los vehiculos disponibles para un viaje
        public DataTable VehiculosDisponiblesST(vehiculo_Entity vh)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT V.idtransporte AS CODIGO, TV.nombretipotrans as TIPO_VEHICULO , marca AS MARCA, modelo AS MODELO , placa AS PLACA, kilometraje as KMS " +
                                     " FROM VEHICULO V " +
                                     " JOIN TIPOVEHICULO TV ON V.idtipotrans = TV.idtipotrans " +
                                     " WHERE V.idtransporte not in (SELECT DISTINCT idtransporte " +
                                                                 " FROM SOLICITUDTRANSPORTE " +
                                                                 " WHERE idtransporte is not null " +
                                                                 " AND idestadost not in (2, 3)) " +
                                     " AND V.idtipotrans = CASE "+ vh._tipovehiculo +" WHEN 0 THEN V.idtipotrans ELSE " + vh._tipovehiculo + " END" +
                                     " AND V.idtransporte = CASE " + vh._cod_vehiculo+ " WHEN 0 THEN V.idtransporte ELSE " + vh._cod_vehiculo + " END");
            //" AND V.idtipotrans = ISNULL(" +vh._tipovehiculo+", V.idtipotrans)");
            return dtRegistros;
        }

      
        #endregion
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
