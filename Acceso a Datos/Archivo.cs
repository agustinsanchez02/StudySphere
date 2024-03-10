using MODELO.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class Archivo
    {
        #region Atributos
        public virtual int? Idarchivo { get; set; }
        public string Nombre { get; set; }
        public int? Tamaño { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string Materia { get; set; }
        public string Carrera { get; set; }
        public int? Idusuario { get; set; }

        public byte[] Doc { get; set; }
        public string Extension { get; set; }
        #endregion


        public bool GuardarArchivo(string nombre,long tamaño ,string extension, byte[] file, int IDUsuario, string Materia, string Carrera)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Archivo (Nombre, Tamaño, FechaCreacion ,Extension, Documento, IDUsuario, Materia, Carrera) VALUES ('" + nombre+ "','" + tamaño + "', GETDATE(),'" + extension +"', @file ,'" + IDUsuario + "','" + Materia + "','" +Carrera + "')";
                    command.Parameters.AddWithValue("@file", file);
                    command.CommandType = CommandType.Text;
                    int r = command.ExecuteNonQuery();

                    if (r > 0)
                    {
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
        public DataTable FiltroArchivo(string texto)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();

                    command.CommandText = "select IDArchivo, Archivo.Nombre, extension ,Tamaño, Materia, Carrera, FechaCreacion, Archivo.IDUsuario, Usuarios.Nombre from Archivo JOIN Usuarios ON Archivo.IDUsuario = Usuarios.IDUsuario where Materia = '"+ texto+"' OR Carrera = '"+ texto+"'";
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
        public DataTable ListarDocs()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select IDArchivo, Archivo.Nombre, extension ,Tamaño, Materia, Carrera, FechaCreacion, Archivo.IDUsuario, Usuarios.Nombre from Archivo JOIN Usuarios ON Archivo.IDUsuario = Usuarios.IDUsuario";
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

        public DataTable ArchivoPorId(int id)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Select * from Archivo where IDArchivo = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader lector = command.ExecuteReader();
                    table.Load(lector);
                    lector.Close();
                }
                connection.Close();
                return table;
            }
        }

        public List<Archivo> Filtrodocumentos(int id)
        {
            var tabla = ArchivoPorId(id);
            var infoDocumento = new List<Archivo>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new Archivo()
                {
                    Idarchivo = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Tamaño = Convert.ToInt32(item[2]),
                    FechaCreacion = Convert.ToDateTime(item[3]),
                    Materia = item[4].ToString(),
                    Carrera = item[5].ToString(),
                    Idusuario = Convert.ToInt32(item[6]),
                    Doc = (byte[])item[7],
                    Extension = item[8].ToString()
                });
            }
            return infoDocumento;
         }

        public bool BorrarArchivo(int id)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "delete from Archivo where IDArchivo = @id";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                connection.Close();
                return true;
            }
        }
    }
}
