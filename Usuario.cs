using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace demoUniversidad
{
    public class Usuario
    {
        public string Nombre = "";
        public string usuario = "";
        public string contraseña = "";
        public int id = 0;
        public int rol = 0;

        public Usuario()
        {
            Nombre = "";
            usuario = "";
            contraseña = "";
            id = 0;
            rol = 0;
        }

        public Usuario(string nombre, string usuario, string contraseña, int id, int rol)
        {
            this.Nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.id = id;
            this.rol = rol;
        }


        public static bool validarUsuario(string usuario, string contraseña)
        {
            List<Usuario> list = mostrar();
            for (int i = 0; i < list.Count; i++)
            {
                Usuario user = list[i]; 
                if(user.usuario.Equals(usuario) && user.contraseña.Equals(contraseña))
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            return false;
        }

        public static List<Usuario> mostrar()
        {
            return userList.mostrar();
        }

    }
}