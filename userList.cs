using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace demoUniversidad
{
    public class userList
    {
        public static List<Usuario> users = new List<Usuario>();
        public void agregar(Usuario user)
        {
            users.Add(user);
        }
        public static void eliminar(int posicion)
        {
            users.RemoveAt(posicion);
        }
        public static List<Usuario> mostrar()
        {
            return users;
        }
    }
}
