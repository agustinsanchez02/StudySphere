using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaSoporte.Caché
{
    public class CacheArchivos: ConexionSQL
    {
        public  int Id { get; set; }
        public  string Nombre { get; set; }
        public string Extension { get; set; }
        public  byte[] Doc { get; set; }
        public string Usuario { get; set; }

        public bool GuardarArchivo(string nombre, string extension, byte[] file, string usuario)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Archivos (Nombre,Extension, doc, usuario) VALUES (@nombre, @extension,@doc, @usuario)";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@extension", extension);
                    command.Parameters.AddWithValue("@doc", file);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.CommandType = CommandType.Text;
                    int r = command.ExecuteNonQuery();

                    if (r > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public DataTable ListarDocs()
        {
            DataTable dataTable = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select id, Nombre, extension, usuario from Archivos";
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

        public DataTable ArchivoPorId()
        {
            DataTable table = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Archivos where id = @id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader lector = command.ExecuteReader();
                    table.Load(lector);
                    lector.Close();
                }
                return table;
            }
        }

        public bool BorrarArchivo()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from Archivos where id = @id";
                    command.Parameters.AddWithValue("@id", Id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                return true;
            }
        }

        public List<CacheArchivos> FiltroDocumentos()
        {

            var tabla = ArchivoPorId();
            var infoDocumento = new List<CacheArchivos>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new CacheArchivos
                {
                    Id = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Extension = item[2].ToString(),
                    Doc = (byte[])item[3],
                    Usuario = item[4].ToString()
                });
            }
            return infoDocumento;
        }
    }
}
