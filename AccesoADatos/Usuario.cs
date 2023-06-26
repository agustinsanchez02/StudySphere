using System.Data.SqlClient;
using System.Data;
using COMUN;
using CapaSoporte.Caché;
using System;
using MercadoPago.Resource.User;
using System.Net.Mail;

namespace AccesoDatos
{
    public class Usuario : ConexionSQL
    {
        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from clientes where Usuario=@user and Contraseña=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", MetodosComunes.Encrypt.GetSHA256(password));
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IDusuario = reader.GetInt32(0);
                            CacheUsuario.Usuario = reader.GetString(1);
                            CacheUsuario.Nombre = reader.GetString(3);
                            CacheUsuario.Apellido = reader.GetString(4);
                            CacheUsuario.Email = reader.GetString(5);
                            CacheUsuario.Privilegios = reader.GetInt32(6);

                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
           
        }
        public void ObtenerPrecios(int precioA, int precioM)
        {
            Precios.precioA = precioA;
            Precios.precioM = precioM;
            
        }
        public bool ObtenerUsuario(string Mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from clientes where Email=@email";
                    command.Parameters.AddWithValue("@email", Mail);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.Usuario = reader.GetString(1);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public void suscripcion(int privilegios, string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Clientes set Privilegios = @privilegios where Usuario = @user";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@privilegios", privilegios);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IDusuario = reader.GetInt32(0);
                            CacheUsuario.Usuario = reader.GetString(1);
                            CacheUsuario.Nombre = reader.GetString(3);
                            CacheUsuario.Apellido = reader.GetString(4);
                            CacheUsuario.Email = reader.GetString(5);
                            CacheUsuario.Privilegios = reader.GetInt32(6);

                        }
                    }
                }
            }
        }
        public void ObtenetUsuarioCompleto(string user)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from clientes where Usuario=@user";
                    command.Parameters.AddWithValue("@user", user);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IDusuario = reader.GetInt32(0);
                            CacheUsuario.Usuario = reader.GetString(1);
                            CacheUsuario.Nombre = reader.GetString(3);
                            CacheUsuario.Apellido = reader.GetString(4);
                            CacheUsuario.Email = reader.GetString(5);
                            CacheUsuario.Privilegios = reader.GetInt32(6);

                        }
                    }
                }
            }
        }
    }
}