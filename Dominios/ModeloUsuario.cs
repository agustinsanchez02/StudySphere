using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMUN;
using AccesoDatos;
using CapaSoporte.Caché;

namespace Dominios
{
    public class ModeloUsuario
    {
        Usuario Usuario = new Usuario();
        public bool iniciosesion(string user, string pass)
        {
            return Usuario.Login(user, pass);

        }
        public void ObtenerUsuarioCompleto(string user)
        {
            Usuario.ObtenetUsuarioCompleto(user);
        }

        public bool ObtenerUsuario(string Mail)
        {
            return Usuario.ObtenerUsuario(Mail);
        }

        public void obtenerprecio(int precioA, int precioM)
        {
            Usuario.ObtenerPrecios(precioA, precioM);
            
        }

        public void privilegios(int privilegios, string usuario)
        {
            Usuario.suscripcion(privilegios, usuario);
        }

    }
}
