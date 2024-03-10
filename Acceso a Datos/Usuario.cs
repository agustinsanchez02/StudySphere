using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using MODELO.Entidades;


namespace Acceso_a_Datos
{
    public class Usuario 
    {
        public Usuario(int id, string user, string contrasena, string nombre, string apellido, string email, string telefono,int permisos) => usuario = new MODELO.Entidades.Usuario(id, user, contrasena, nombre, apellido, email, telefono, permisos);
        public Usuario() => usuario = new MODELO.Entidades.Usuario();
        MODELO.Entidades.Usuario usuario = new MODELO.Entidades.Usuario();

        Mail Mail = new Mail();
        #region Usuario Nuevo
        #region Editar Perfil
        public void editarperfil(int Id, string Usuario, string Nombre, string Apellido, string Email, string Telefono, int permisos)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "update Usuarios set Usuario=@usuario, Nombre=@nombre, " +
                                           " Apellido=@apellido, Email=@email, Telefono=@telefono, Permisos=@permisos  Where IDusuario =@id ";
                    command.Parameters.AddWithValue("@usuario", Usuario);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@apellido", Apellido);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@telefono", Telefono);
                    command.Parameters.AddWithValue("@Permisos", permisos);

                    command.Parameters.AddWithValue("@id", Id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void editarPerfilyPass(int Id, string Usuario, string Nombre, string Apellido, string Email, string Telefono, string Contraseña)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "update Usuarios set Usuario=@usuario, Nombre=@nombre, " +
                                           " Apellido=@apellido, Email=@email, Telefono=@telefono, Contraseña=@contraseña Where IDusuario =@id ";
                    command.Parameters.AddWithValue("@usuario", Usuario);
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@apellido", Apellido);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@telefono", Telefono);
                    command.Parameters.AddWithValue("@contraseña", MetodosComunes.Encrypt.GetSHA256(Contraseña));
                    command.Parameters.AddWithValue("@id", Id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        #endregion

        #region Agregar Usuario
        public string AgregarUsuario(string Usuario,string Contraseña, string Nombre, string Apellido, string email, string Telefono )
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Usuarios VALUES('" + Usuario + "', '" + Contraseña + "', '" + Nombre + "', '" + Apellido + "', '" + email + "', '" + Telefono + "' , 1)";
                    command.CommandType = CommandType.Text;
                    int r = command.ExecuteNonQuery();

                    if (r > 0)
                    {
                        SmtpClient cliente = Mail.SmtpClient();
                        MailMessage correo = Mail.Mail_Registro(email, Nombre, Apellido, Usuario);
                        cliente.Send(correo);
                        string mensaje = string.Empty;
                        connection.Close();
                        return "Usuario registrado exitosamente";
                    }
                    else
                    {
                        connection.Close();
                        return "No se ha podido registrar el usuario.";
                    }
                }
            }
        }
        #endregion
        
        #region Login
        public string Login(string user, string password)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select * from Usuarios where Usuario=@user and Contraseña=@password";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@password", MetodosComunes.Encrypt.GetSHA256(password));
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IdUsuario = reader.GetInt32(0);
                            CacheUsuario.Usuario = reader.GetString(1);
                            CacheUsuario.Contraseña = reader.GetString(2);
                            CacheUsuario.Nombre = reader.GetString(3);
                            CacheUsuario.Apellido = reader.GetString(4);
                            CacheUsuario.Email = reader.GetString(5);
                            CacheUsuario.Telefono = reader.GetString(6);
                            CacheUsuario.Permisos = reader.GetInt32(7);
                        }
                        connection.Close();
                        return "Agregado";
                    }
                    else
                    {
                        connection.Close();
                        return "Error";
                    }
                }
            }
         
        }
        #endregion

        #region Obtener Precios
        public void ObtenerPrecios(int precioA, int precioM)
        {
            MODELO.Entidades.Precios.precioA = precioA;
            MODELO.Entidades.Precios.precioM = precioM;

        }
        public virtual bool ObtenerUsuarioMail(string Mail)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select * from Usuarios where Email=@email";
                    command.Parameters.AddWithValue("@email", Mail);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usuario.User = reader.GetString(1);
                            usuario.Email = reader.GetString(5);
                        }
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }
        #endregion

        #region Permisos
        public void Permisos(int privilegios, string user)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "update Usuarios set Permisos = '"+ privilegios+"' where Usuario = '"+user +"'";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usuario.Idusuario = Convert.ToInt32(reader.GetValue(0));
                            usuario.User = reader.GetString(1);
                            usuario.Contrasena = reader.GetString(2);
                            usuario.Nombre = reader.GetString(3);
                            usuario.Apellido = reader.GetString(4);
                            usuario.Email = reader.GetString(5);
                            usuario.Permisos = reader.GetInt32(6);

                        }
                    }
                    connection.Close();
                }
            }
        }
        #endregion

        #region Obtener Usuario Completo
        public void ObtenetUsuarioCompleto(string user)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select * from Usuarios where Usuario= '"+ user + "'";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IdUsuario = Convert.ToInt32(reader.GetValue(0));
                            CacheUsuario.Usuario = reader.GetString(1);
                            CacheUsuario.Contraseña = reader.GetString(2);
                            CacheUsuario.Nombre = reader.GetString(3);
                            CacheUsuario.Apellido = reader.GetString(4);
                            CacheUsuario.Email = reader.GetString(5);
                            CacheUsuario.Telefono = reader.GetString(6);
                            CacheUsuario.Permisos = reader.GetInt32(7);

                        }
                    }
                    connection.Close();
                }
            }
        }

        public Mail GetMail()
        {
            return Mail;
        }
        #endregion

        #endregion

        #region Editar Usuario
        #region Cambiar Contraseña
        public string CambiarContraseña( string pass, string mail)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "UPDATE Usuarios SET Contraseña =  '" + pass + "' WHERE Email = '" + mail + "'";
                    command.CommandType = CommandType.Text;
                    int r = command.ExecuteNonQuery();
                    if (r > 0)
                    {
                        SmtpClient cliente = Mail.SmtpClient();
                        MailMessage correo = Mail.Mail_cambiopass(mail);
                        cliente.Send(correo);
                        string mensaje = string.Empty;
                        connection.Close();
                        return "Contraseña cambiada exitosamente";
                    }
                    else
                    {
                        connection.Close();
                        return "Error";
                    }
                }
            }          
        }   
        #endregion
        #region Editar Perfil
        public string EditarPerfil(int id, string user, string pass, string nombre, string apellido, string email)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "update Usuarios set Usuario=@usuario, Contraseña=@contraseña, Nombre=@nombre, " +
                                           " Apellido=@apellido, Email=@email, Where IDusuario =@id ";
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@contraseña", pass);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    return "Usuario editado exitosamente";
                }
            }
        }
        #endregion
        #region Eliminar Usuario
        public bool EliminarUsuario(int id)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "delete from Usuarios where IDusuario = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
        }
        #endregion
        #region Listar Usuarios
        public DataTable ListarUsuario()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select IDusuario, Usuario, Nombre, Apellido, Email, Telefono, Permisos from Usuarios";
                    command.CommandType = CommandType.Text;
                    SqlDataReader resultado = command.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        dataTable.Load(resultado);
                    }
                    connection.Close();
                    return dataTable;
                }
            }
        }
        #endregion

        #region Obtener Usuario por ID
        public DataTable UsuarioPorId()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Select * from Usuarios where IDusuario = @id";
                    command.Parameters.AddWithValue("@id", usuario.Idusuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader lector = command.ExecuteReader();
                    table.Load(lector);
                    lector.Close();
                }
                connection.Close();
                return table;
            }
        }
        #endregion

        #region Filtro Usuarios

        public List<MODELO.Entidades.Usuario> FiltroUsuario()
        {

            var tabla = UsuarioPorId();
            var infoDocumento = new List<MODELO.Entidades.Usuario>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new MODELO.Entidades.Usuario
                {
                    Idusuario = Convert.ToInt32(item[0]),
                    User = item[1].ToString(),
                    Nombre = item[3].ToString(),
                    Apellido = item[4].ToString(),
                    Email = item[5].ToString()
                });
            }
            return infoDocumento;
        }
        #endregion
        #endregion

        #region Obtener Datos Usuario Actual
        public int ObtenerIDActual()
        {
            return CacheUsuario.IdUsuario;
        }
        public string ObtenerUsuarioActual()
        {
            return CacheUsuario.Usuario;
        }

        public string ObtenerContraseñaActual()
        {
            return CacheUsuario.Contraseña;
        }
        public string ObtenerEmailActual()
        {
               return CacheUsuario.Email;
        }
        public string ObtenerTelefonoActual()
        {
            return CacheUsuario.Telefono;
        }
        public string ObtenerNombreActual()
        {
            return CacheUsuario.Nombre;
        }   
        public string ObtenerApellidoActual()
        {
            return CacheUsuario.Apellido;
        }
        
        public int ObtenerPermisos()
        {
            return CacheUsuario.Permisos;
        }
        public string ObtenerTipoCuenta()
        {
            if (usuario.Permisos == 0)
            {
                string TipoCuenta = "Admin";
                return TipoCuenta;
            }
            else
            {
                if (usuario.Permisos == 1)
                {
                    string TipoCuenta = "Study Basic";
                    return TipoCuenta;
                }
                else
                {
                    if (usuario.Permisos == 2)
                    {
                        string TipoCuenta = "Study Plus";
                        return TipoCuenta;
                    }
                    else
                    {
                        if (usuario.Permisos == 3)
                        {
                            string TipoCuenta = "Study Premium";
                            return TipoCuenta;
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }

        }
        #endregion

    }
}
