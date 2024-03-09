using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.Entidades
{
    public static class CacheUsuario
    {
        public static int IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Email { get; set; }
        public static string Telefono { get; set; } 
        public static int Permisos { get; set; }
    }
}
