using System;
using System.Data;

namespace Controladora
{
    public class ContextoUsuario
    {


        Acceso_a_Datos.Usuario user = new Acceso_a_Datos.Usuario();


        //Atributos
        private int Id;
        private string Usuario;
        private string Contraseña;
        private string Nombre;
        private string Apellido;
        private string Email;
        private int Permisos;

        public ContextoUsuario(int id, string usuario, string contraseña, string nombre, string apellido, string email, int permisos)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Contraseña = contraseña;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Permisos = permisos;
        }
        public ContextoUsuario(int id, string usuario, string nombre, string apellido, string email)
        {
            this.Id = id;
            this.Usuario = usuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
        }
        public ContextoUsuario()
        {

        }

        public int obtenerIDActual()
        {
            return user.ObtenerIDActual();
        }

        public string ObtenerUsuarioActual()
        {
            return user.ObtenerUsuarioActual();
        }
        public string ObtenerTipoCuenta()
        {
            return user.ObtenerTipoCuenta();
        }
        public string ObtenerNombreActual()
        {
            return user.ObtenerNombreActual();
        }   
        public string ObtenerApellidoActual()
        {
            return user.ObtenerApellidoActual();
        }
        public string ObtenerEmailActual()
        {
            return user.ObtenerEmailActual();
        }
        public string ObtenerTelefonoActual()
        {
            return user.ObtenerTelefonoActual();
        }

        public int obtenerpermisos()
        {
            return user.ObtenerPermisos();
        }
        public string ObtenerContraseñaActual()
        {
            return user.ObtenerContraseñaActual();
        }   

        public string AgregarUsuario(string usuario, string contraseña, string nombre, string apellido, string email, string telefono)
        {
            try
            {
                user.AgregarUsuario(usuario, contraseña, nombre, apellido, email, telefono);
                return "Usuario creado exitosamente. ";
            }
            catch (Exception e)
            {
                return Convert.ToString(e);
            }
        }
        public string cambiarcontraseña(string pass, string mail)
        {
            try
            {
                user.CambiarContraseña(pass, mail);
                return "Tu contraseña se ha actualizado exitosamente. ";
            }
            catch (Exception)
            {
                return "Error al cambiar tu contraseña";
            }
        }
        public string editarPerfilyPass(int Id, string Usuario, string Nombre, string Apellido, string Email, string telefono, string Contraseña)
        {
            try
            {
                user.editarPerfilyPass(Id, Usuario, Nombre, Apellido, Email, telefono, Contraseña);
                iniciosesion(Usuario, Contraseña);
                return "Tu perfil se ha actualizado exitosamente. ";
            }
            catch (Exception e)
            {
                return "Error, intente nuevamente, " + Convert.ToString(e) + "";
            }
        }
        public string editarperfil(int Id, string Usuario, string Nombre, string Apellido, string Email, string telefono, string Contraseña, int Permisos)
        {
            try
            {
                user.editarperfil(Id, Usuario, Nombre, Apellido, Email, telefono, Permisos);
                iniciosesion(Usuario, Contraseña);
                return "Tu perfil se ha actualizado exitosamente. ";
            }
            catch (Exception e)
            {
                return "Error, intente nuevamente, "+ Convert.ToString(e)+""  ;
            }
        }
        public string editarperfilAdmin(int Id, string Usuario, string Nombre, string Apellido, string Email, string telefono, int Permisos)
        {
            try
            {
                user.editarperfil(Id, Usuario, Nombre, Apellido, Email, telefono, Permisos);
                return "El perfil se ha actualizado exitosamente. ";
            }
            catch (Exception e)
            {
                return "Error, intente nuevamente, " + Convert.ToString(e) + "";
            }
        }
        public string iniciosesion(string usuario, string pass)
        {
            return user.Login(usuario, pass);
        }


        public void ObtenerUsuarioCompleto(string usuario)
        {
            user.ObtenetUsuarioCompleto(usuario);
        }

        public bool ObtenerUsuario(string Mail)
        {
            return user.ObtenerUsuarioMail(Mail);
        }


        public void obtenerprecio(int precioA, int precioM)
        {
            user.ObtenerPrecios(precioA, precioM);

        }

        public void permisos(int privilegios, string usuario)
        {
            user.Permisos(privilegios, usuario);
        }
        public DataTable ListarUsuarios()
        {
            return user.ListarUsuario();
        }
        public bool EliminarUsuario(int id)
        {
            return user.EliminarUsuario(id);
        }
    }
}