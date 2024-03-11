using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class Carrera
    {
        #region Atributos
        public int Idcarrera { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        #endregion
        public string AgregarCarrera(string Nombre, string Descripcion)
        {
            string mensaje = "";
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Insert into Carrera (Nombre, Descripcion) values (@Nombre, @Descripcion)";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        mensaje = "Carrera agregada correctamente";
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al agregar la carrera: " + ex.Message;
                    }
                }
                connection.Close();
            }
            return mensaje;
        }
        public string ModificarCarrera(string Nombre, string Descripcion, string Idcarrera)
        {
            string mensaje = "";
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Update Carrera set Nombre = @Nombre, Descripcion = @Descripcion where Idcarrera = @Idcarrera";
                    command.Parameters.AddWithValue("@Nombre", Nombre);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@Idcarrera", Idcarrera);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        mensaje = "Carrera modificada correctamente";
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al modificar la carrera: " + ex.Message;
                    }
                }
                connection.Close();
            }
            return mensaje;
        }
        public string EliminarCarrera(string Idcarrera)
        {
            string mensaje = "";
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Delete from Carrera where Idcarrera = @Idcarrera";
                    command.Parameters.AddWithValue("@Idcarrera", Idcarrera);
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        mensaje = "Carrera eliminada correctamente";
                    }
                    catch (Exception ex)
                    {
                        mensaje = "Error al eliminar la carrera: " + ex.Message;
                    }
                }
                connection.Close();
            }
            return mensaje;
        }
        public List<Carrera> Carreras()
        {
            var tabla = ListarCarrera();
            var infoDocumento = new List<Carrera>();
            foreach (DataRow item in tabla.Rows)
            {
                infoDocumento.Add(new Carrera()
                {
                    Idcarrera = Convert.ToInt32(item[0]),
                    Nombre = item[1].ToString(),
                    Descripcion = item[2].ToString()
                });
            }
            return infoDocumento;
        }
        public DataTable ListarCarrera()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "Select * from Carrera";
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
