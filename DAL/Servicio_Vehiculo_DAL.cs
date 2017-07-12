using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;

namespace DAL
{
    // Programador : Dennys Choy
    // Analista : Dennys Choy
    // Fecha : 08-07-22017
    // Comentarios : Envia a Inventarios los productos de una Solicitud de Transporte listos para ingresar

    public class Servicio_Vehiculo_DAL
    {
        MRP_BD cnn = Globales.cnn;
        //MRP_BD cnn = new MRP_BD("ivan", "developer1993", "SAD2017", @"DESKTOP-F4L56EU\SQLEXPRESS");
        // MRP_BD cnn = new MRP_BD("r40usr", "Inter$2013", "SAD2017", "SDESRUTA40");

        public void insertarServicio(Servicio_Vehiculo_Entity st)
        {

            cnn.insertSQL("INSERT INTO MORDENSERVICIOV (idtransporte, facturataller, fechaservicio, fechaproximoservicio, kmsactuales, kmsproximoservicio, monto, idtiposerviciovh) " +
                            " VALUES(" + st.idtransporte + ", '"+st.factura+"',\'"+st.fecha+"\', \'"+st.fechaprox+"\', "+st.kmsactual+", "+st.kmsprox+","+st.monto+","+st.idTipoServicio+")");

            actualizaKMS(st.idtransporte, st.kmsactual);
        }

        public void actualizarServicio(Servicio_Vehiculo_Entity st)
        {
            cnn.updateSQL(string.Format("UPDATE MORDENSERVICIOV SET facturataller = '{0}', fechaservicio = '{1}', kmsactuales = {2}, kmsproximoservicio = {3}, monto = {4} WHERE idordenserv = {5}" ,  
                                                                    st.factura, st.fecha, st.kmsactual, st.kmsprox, st.monto, st.idorden));

            actualizaKMS(st.idtransporte, st.kmsactual);
        }

        public void actualizaKMS(int vehiculo, decimal kms)
        {
            cnn.updateSQL("UPDATE VEHICULO SET kilometraje = " + kms + " WHERE idtransporte = " + vehiculo);
        }

        public void eliminarServicio(int vh)
        {
            cnn.deleteSQL("DELETE FROM MORDENSERVICIOV WHERE idordenserv = " + vh);
        }
        public DataTable verTodoServicios(int vh)
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT idordenserv AS CODIGO, facturataller AS FACTURA, fechaservicio AS FECHA, kmsactuales AS KILOMETROS, " +
                                        " kmsproximoservicio AS KMS_PROXIMO_SERVICIO, monto AS GASTO" +
                                " FROM MORDENSERVICIOV " + 
                                " WHERE idtransporte = " + vh);
            return dtRegistros;
        }

        public Servicio_Vehiculo_Entity verUnServicio(int vh)
        {
            DataTable dtRegistros = new DataTable();
            Servicio_Vehiculo_Entity st = new Servicio_Vehiculo_Entity();
            dtRegistros = cnn.getSQL("SELECT * FROM MORDENSERVICIOV " +
                  " WHERE idordenserv = " + vh );
            foreach (DataRow row in dtRegistros.Rows)
            {
                foreach (DataColumn column in dtRegistros.Columns)
                {
                    st.idtransporte = Convert.ToInt32(row["idtransporte"]);
                    st.idorden = Convert.ToInt32(row["idordenserv"]);
                    st.factura = row["facturataller"].ToString();
                    st.fecha = row["fechaservicio"].ToString();
                    st.fechaprox = row["fechaproximoservicio"].ToString();
                    st.kmsactual = Convert.ToDecimal(row["kmsactuales"]);
                    st.kmsprox = Convert.ToDecimal(row["kmsproximoservicio"]);
                    st.monto = Convert.ToDecimal(row["monto"]);
                    
                    if(row["idAutorizacion"].ToString() == "")
                    {
                        st.idAutorizacion = 0;
                    }else { st.idAutorizacion = 1;  }
                    //st.idAutorizacion = Convert.ToInt32(row["idAutorizacion"]);

                }
            }
            return st;
        }


        public DataTable verTiposServicios()
        {
            DataTable dtRegistros = new DataTable();
            dtRegistros = cnn.getSQL("SELECT * FROM TIPOSERVICIOVH");
            return dtRegistros;
        }
    }
}
