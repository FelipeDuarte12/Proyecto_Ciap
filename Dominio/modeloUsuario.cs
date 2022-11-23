using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accesoDatos;

namespace Dominio
{
    //Se encarga del login entre los datos ingresados y los datos en la base de datos
    public class modeloUsuario
    {
        userDao userdao = new userDao();
        public bool loginUser(string user, string pass)
        {
            return userdao.login(user, pass);
        }
        public string tipo_trabajador(string user, string pass)
        {
            return userdao.tipo(user, pass);
        }
    }
}