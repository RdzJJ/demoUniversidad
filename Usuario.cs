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
        string NombreCompleto = "";
        string usuario = "";
        int id = 0;
        int rol = 0;

        public Usuario(string NombreCompleto, string usuario, int id, int rol)
        {
            this.NombreCompleto = NombreCompleto;
            this.usuario = usuario;
            this.id = id;
            this.rol = rol;
        }
    }
}