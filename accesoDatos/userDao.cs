using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace accesoDatos
{
    public class userDao : conexionSQL
    {
        //Esta funcion booleana esta encargada de logear el usuario con los datos obtenidos desde la base de datos
        public bool login(string user, string pass)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from usuarios where loginName = @user  and password = @pass";
                    comando.Parameters.AddWithValue("@user", user);
                    comando.Parameters.AddWithValue("@pass", pass);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        public string tipo(string user, string pass)
        {
            string tipo_trabajador = "";
            
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select usuarios.tipo from usuarios where loginName = @user  and password = @pass";
                    tipo_trabajador = comando.CommandText;
                    
                    return tipo_trabajador;
                    
                }
            }
        }
    }
}
