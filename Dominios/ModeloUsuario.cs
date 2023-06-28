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


        Usuario user = new Usuario();


        //Atributos
        private int Id;
        private string Usuario;
        private string Contraseña;
        private string Nombre;
        private string Apellido;
        private string Email;

        public ModeloUsuario(int id, string usuario, string contraseña, string nombre, string apellido, string email)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Contraseña = contraseña;
            this.Nombre = nombre; 
            this.Apellido = apellido;
            this.Email = email;
        }
        public ModeloUsuario() 
        {
            
        }

        public string editarperfil()
        {
            try
            {
                user.editarperfil(Id, Usuario, Contraseña, Nombre, Apellido, Email);
                iniciosesion(Usuario, Contraseña);
                return "Tu perfil se ha actualizado exitosamente. ";
            }
            catch (Exception)
            {
                return "El usuario ya esta registrado, intente nuevamente";
            }
        }
        public bool iniciosesion(string usuario, string pass)
        {
            return user.Login(usuario, pass);

        }
        

        public void ObtenerUsuarioCompleto(string usuario)
        {
            user.ObtenetUsuarioCompleto(usuario);
        }

        public bool ObtenerUsuario(string Mail)
        {
            return user.ObtenerUsuario(Mail);
        }


        public void obtenerprecio(int precioA, int precioM)
        {
            user.ObtenerPrecios(precioA, precioM);
            
        }

        public void privilegios(int privilegios, string usuario)
        {
            user.suscripcion(privilegios, usuario);
        }

    }
}
