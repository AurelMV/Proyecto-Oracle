using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CapaDatos2
{
    public class Conexion
    {
        private static Conexion Con = null;

        public Conexion()
        {


        }

        public OracleConnection CrearConexion()
        {

            OracleConnection cadena = new OracleConnection();
            try
            {
                //conecion con oracle
                cadena.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
                                          "(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
                                          "User Id=Palola;Password=123456;";

            }
            catch (Exception ex)
            {
                cadena = null;

                throw ex;
            }
            return cadena;

        }
        public static Conexion getInstancia()
        {
            if (Con == null)
            {

                Con = new Conexion();

            }
            return Con;

        }
    }
}
