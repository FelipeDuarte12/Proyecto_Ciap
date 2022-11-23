using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace accesoDatos
{
    //Crea la conexion con la base de datos
    public abstract class conexionSQL
    {
        private readonly string conexionString;
        public conexionSQL()
        {
            conexionString = "Server=(Localdb)\\CIAP;DataBase= CIAPEJEMPLO;integrated security = true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }

    }
}