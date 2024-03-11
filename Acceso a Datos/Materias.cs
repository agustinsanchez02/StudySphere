using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class Materias
    {
        #region Atributos
        public int Idmateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        #endregion

        public string AgregarMateria(string Nombre, string Descripcion)
        {
            string mensaje = "";
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Insert into Materia (Nombre, Descripcion) values (@Nombre, @Descripcion)";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        mensaje = "Materia agregada correctamente";
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al agregar la materia: " + ex.Message;
                    }
                }
                connection.Close();
            }
            return mensaje;
        }
        public string ModificarMateria(string Nombre, string Descripcion, string Idmateria)
        {
            string mensaje = "";
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Update Materia set Nombre = @Nombre, Descripcion = @Descripcion where Idmateria = @Idmateria";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@Idmateria", Idmateria);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        mensaje = "Materia modificada correctamente";
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al modificar la materia: " + ex.Message;
                    }
                }
                connection.Close();
            }
            return mensaje;
        }
        public string EliminarMateria(string Idmateria)
        {
            string mensaje = "";
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Delete from Materia where Idmateria = @Idmateria";
                    command.Parameters.AddWithValue("@Idmateria", Idmateria);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        mensaje = "Materia eliminada correctamente";
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al eliminar la materia: " + ex.Message;
                    }
                }
                connection.Close();
            }
            return mensaje;
        }
        public List<Materias> materias()
        {
            var tabla = ListarMateria();
            var infoDocumento = new List<Materias>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new Materias()
                {
                    Idmateria = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Descripcion = item[2].ToString()
                });
            }
            return infoDocumento;
        }
        public DataTable ListarMateria()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Select * from Materia";
                    command.CommandType = CommandType.Text;
                    SqlDataReader lector = command.ExecuteReader();
                    table.Load(lector);
                    lector.Close();
                }
                connection.Close();
                return table;
            }
        }
    }
}
