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
            bool validar = false;
            List<Usuario> list = userList.mostrar();
            for (int i = 0; i < list.Count; i++)
            {
                Usuario user = list[i];
                if (user.usuario.Equals(usuario) && user.contraseña.Equals(contraseña))
                {
                    validar = true;
                    break;
                }
            }
            return validar;
        }
        public static void verificarRol()
        {
            List<Usuario> list = userList.mostrar();
            int rol = -1;
            for (int i = 0; i < list.Count; i++)
            {
                Usuario user = list[i];
                if (user.rol.Equals(0))
                {
                    rol = 0;
                }
                else if (user.rol.Equals(1))
                {
                    rol = 1;
                }
                else if (user.rol.Equals(2))
                {
                    rol = 2;
                }
            }
            Login.estado = rol;
        }

        public static string Bienvenido(string user)
        {
            List<Usuario> list = userList.mostrar();
            string nombre = "";
            for (int i = 0; i < list.Count; i++)
            {
                Usuario obj = list[i];
                if (obj.usuario.Equals(user))
                {
                    nombre = obj.Nombre;
                }
            }
            return nombre;
        }
    }
}