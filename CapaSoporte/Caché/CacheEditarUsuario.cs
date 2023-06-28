using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSoporte.Caché
{
    public class CacheEditarUsuario: ConexionSQL
    {
        public int IDusuario { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

      
        public CacheEditarUsuario(int id, string usuario, string nombre, string apellido, string email)
        {
            this.IDusuario = id;
            this.Usuario = usuario;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
        }
        public CacheEditarUsuario()
        {

        }

        public DataTable ListarUsuario()
        {
            DataTable dataTable = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select IDusuario, Usuario, Nombre, Apellido, Email from Clientes";
                    command.CommandType = CommandType.Text;
                    SqlDataReader resultado = command.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        dataTable.Load(resultado);
                    }
                    return dataTable;
                }
            }
        }
        public DataTable UsuarioPorId()
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Clientes where IDusuario = @id";
                    command.Parameters.AddWithValue("@id", IDusuario);
                    command.CommandType = CommandType.Text;
                    SqlDataReader lector = command.ExecuteReader();
                    table.Load(lector);
                    lector.Close();
                }
                return table;
            }
        }
        public List<CacheEditarUsuario> FiltroUsuario()
        {

            var tabla = UsuarioPorId();
            var infoDocumento = new List<CacheEditarUsuario>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new CacheEditarUsuario
                {
                    IDusuario = Convert.ToInt32(item[0]),
                    Usuario = item[1].ToString(),
                    Nombre = item[3].ToString(),
                    Apellido = item[4].ToString(),
                    Email = item[5].ToString()
                });
            }
            return infoDocumento;
        }

        public string editarPerfil(int Id, string Usuario, string Nombre, string Apellido, string Email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = "update Clientes set Usuario=@usuario, Nombre=@nombre, " +
                                               " Apellido=@apellido, Email=@email Where IDusuario =@id ";
                        command.Parameters.AddWithValue("@usuario", Usuario);
                        command.Parameters.AddWithValue("@nombre", Nombre);
                        command.Parameters.AddWithValue("@apellido", Apellido);
                        command.Parameters.AddWithValue("@email", Email);
                        command.Parameters.AddWithValue("@id", Id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        return "Usuario Modificado con exito";
                    }
                    catch
                    {
                        return "No se ha podido modificar el usuario";
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

                        }
                    }
                }
            }
        }

    }
}
