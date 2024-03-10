using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Acceso_a_Datos
{
    public class Auditoria
    {
        public void AuditorialogIn(string usuario, string mail, string descripcion)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO login_Auditoria (FechayHora, Usuario, Mail, Movimiento,Descripcion) VALUES ('"+ DateTime.Now +"','"+ usuario +"','"+mail+"','Inicio de sesion','"+descripcion+"')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void AuditoriaLogOut(string usuario, string mail, string descripcion)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO login_Auditoria (FechayHora, Usuario, Mail, Movimiento,Descripcion) VALUES ('" + DateTime.Now + "','" + usuario + "','" + mail + "','Cierre de sesion','" + descripcion + "')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void AuditoriaAltaArchivo(string modulo, string usuario, string descripcion, string nombre, string extension, int tamaño, DateTime fechacreacion ,string Materia, string Carrera)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Archivo_Auditoria (Fecha, Modulo, Movimiento, Usuario, Descripcion, Nombre, Extension, Tamaño, FechaCreacion, Materia, Carrera) VALUES ('" + DateTime.Now + "','" + modulo + "', 'Alta de archivo' ,'" + usuario + "','" + descripcion + "','" + nombre + "','" + extension + "','" + tamaño + "','" + fechacreacion + "','" + Materia + "','" + Carrera + "')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void AuditoriaBajaArchivo(string modulo, string usuario, string descripcion, string nombre, string extension, int tamaño, DateTime fechacreacion, string Materia, string Carrera)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Archivo_Auditoria (Fecha, Modulo, Movimiento, Usuario, Descripcion, Nombre, Extension, Tamaño, FechaCreacion, Materia, Carrera) VALUES ('" + DateTime.Now + "','" + modulo + "', 'Baja de archivo' ,'" + usuario + "','" + descripcion + "','" + nombre + "','" + extension + "','" + tamaño + "','" + fechacreacion + "','" + Materia + "','" + Carrera + "')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void AuditoriaVisualizacionArchivo(string modulo, string usuario, string descripcion, string nombre, string extension, int tamaño, DateTime fechacreacion, string Materia, string Carrera)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Archivo_Auditoria (Fecha, Modulo, Movimiento, Usuario, Descripcion, Nombre, Extension, Tamaño, FechaCreacion, Materia, Carrera) VALUES ('" + DateTime.Now + "','" + modulo + "', 'Visualizacion de archivo' ,'" + usuario + "','" + descripcion + "','" + nombre + "','" + extension + "','" + tamaño + "','" + fechacreacion + "','" + Materia + "','" + Carrera + "')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void AuditoriaDescargaArchivo(string modulo, string usuario, string descripcion, string nombre, string extension, int tamaño, DateTime fechacreacion, string Materia, string Carrera)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "INSERT INTO Archivo_Auditoria (Fecha, Modulo, Movimiento, Usuario, Descripcion, Nombre, Extension, Tamaño, FechaCreacion, Materia, Carrera) VALUES ('" + DateTime.Now + "','" + modulo + "', 'Descarga de archivo' ,'" + usuario + "','" + descripcion + "','" + nombre + "','" + extension + "','" + tamaño + "','" + fechacreacion + "','" + Materia + "','" + Carrera + "')";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
