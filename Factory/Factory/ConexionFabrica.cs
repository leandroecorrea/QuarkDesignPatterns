using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ConexionFabrica
    {
        public IConexion GetConexion(string motor)
        {
            if (string.IsNullOrEmpty(motor))
                return new ConexionVacia();
            else if (motor.ToUpper() == "MYSQL")
                return new ConexionMySQL();
            else if (motor.ToUpper() == "ORACLE")
                return new ConexionOracle();
            else if (motor.ToUpper() == "POSTGRE")
                return new ConexionPostgreSQL();
            else if (motor.ToUpper() == "SQLSERVER")
                return new ConexionSQLServer();
            else
                return new ConexionVacia();
        }
    }
}
