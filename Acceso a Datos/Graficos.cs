using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class Graficos
    {

        SqlDataReader dr;
        ArrayList Materia = new ArrayList();
        ArrayList Cantidad = new ArrayList();
        ArrayList Carrera = new ArrayList();
        ArrayList CantidadCarrera = new ArrayList();
        ArrayList MovimientoUsuarioLogIn = new ArrayList();
        ArrayList Extension = new ArrayList();
        ArrayList CantidadExtension = new ArrayList();

        public ArrayList GraficoExtension()
        {
            Extension.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Extension, COUNT(Extension) as Cantidad from StudySphereAPP.dbo.Archivo group by Extension order by count (2)";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Extension.Add(dr.GetString(0));
                    }
                    connection.Close();
                    return Extension;
                }
            }
        }
        public ArrayList GraficoCantidadExtension()
        {
            CantidadExtension.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Extension, COUNT(Extension) as Cantidad from StudySphereAPP.dbo.Archivo group by Extension order by count (2)";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        CantidadExtension.Add(dr.GetInt32(1));
                    }
                    connection.Close();
                    return CantidadExtension;
                }
            }
        }
        public DataTable GraficoMovimientoArchivo()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Movimiento, COUNT(Movimiento) as Cantidad from StudySphereAPP.dbo.Archivo_Auditoria group by Movimiento order by count(2)\r\n";
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
        
        public DataTable GraficoMovimientoUsuarioLogIn()
        {
            DataTable dataTable = new DataTable();
            MovimientoUsuarioLogIn.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Movimiento, COUNT(Movimiento) as Cantidad from StudySphereAPP.dbo.login_Auditoria  group by Movimiento order by count (2) \r\n";
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

    
        public ArrayList GraficoMateria()
        {
            Materia.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Materia, COUNT(Materia) as Cantidad from StudySphereAPP.dbo.Archivo group by Materia order by count (2)";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader(); 
                    while (dr.Read())
                    {
                        Materia.Add(dr.GetString(0));
                    }
                    connection.Close();
                    return Materia;
                }
            }
        }
        public ArrayList GraficoCantidad()
        {
            Cantidad.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Materia, COUNT(Materia) as Cantidad from StudySphereAPP.dbo.Archivo group by Materia order by count (2)";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Cantidad.Add(dr.GetInt32(1));
                    }
                    connection.Close();
                    return Cantidad;
                }
            }
        }
        public ArrayList GraficoCarrera()
        {
            Carrera.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Carrera, COUNT(Carrera) as Cantidad from StudySphereAPP.dbo.Archivo group by Carrera order by count (2)";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        Carrera.Add(dr.GetString(0));
                    }
                    connection.Close();
                    return Carrera;
                }
            }
        }
        public ArrayList GraficoCantidadCarrera()
        {
            CantidadCarrera.Clear();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select Carrera, COUNT(Carrera) as Cantidad from StudySphereAPP.dbo.Archivo group by Carrera order by count (2)";
                    command.CommandType = CommandType.Text;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        CantidadCarrera.Add(dr.GetInt32(1));
                    }
                    connection.Close();
                    return CantidadCarrera;
                }
            }
        }
    }
}
