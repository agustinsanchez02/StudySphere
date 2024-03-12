using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MODELO;

namespace Acceso_a_Datos
{
    public class Grupos
    {
        #region Atributos
        public int IdGrupo { get; set; }
        public bool Usuarios { get; set; }
        public bool Archivos { get; set; }
        public bool Materias { get; set; }
        public bool Carreras { get; set; }
        public bool BaseDatos { get; set; }
        public bool reportesAuditoria { get; set; }
        public bool ReportesArchivos { get; set; }
        public bool Grupo { get; set; }
        public int IdUsuario { get; set; }
        #endregion

        public void ObtenerPermisos(int id)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "SELECT * FROM Grupos WHERE IdUsuario = " + id;
                    command.CommandType = System.Data.CommandType.Text;
                    var dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        CacheGrupos.IdGrupo = dr.GetInt32(0);
                        CacheGrupos.Usuarios = dr.GetBoolean(1);
                        CacheGrupos.Archivos = dr.GetBoolean(2);
                        CacheGrupos.Materias = dr.GetBoolean(3);
                        CacheGrupos.Carreras = dr.GetBoolean(4);
                        CacheGrupos.BaseDatos = dr.GetBoolean(5);
                        CacheGrupos.reportesAuditoria = dr.GetBoolean(6);
                        CacheGrupos.ReportesArchivos = dr.GetBoolean(7);
                        CacheGrupos.Grupo = dr.GetBoolean(8);
                        CacheGrupos.IdUsuario = dr.GetInt32(9);
                    }
                    connection.Close(); 

                }
            }
        }

        public DataTable ObtenerAdmins()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    connection.Open();
                    command.CommandText = "select IDusuario, Usuario, Nombre, Apellido, Email from Usuarios where Permisos = 0";
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

        public string ModificarGrupo(int id, int usuarios, int archivos, int materias, int carreras, int baseDatos, int reportesAuditoria, int reportesArchivos, int grupo)
        {
            using (SqlConnection connection = new SqlConnection(SQL.Instance.Conexion))
            {
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.CommandText = "update Grupos set Usuarios=" + usuarios + ", Archivos=" + archivos + ", Materias=" + materias + ", Carreras=" + carreras + ", BaseDatos=" + baseDatos + ", ReportesAuditoria=" + reportesAuditoria + ", ReportesArchivos=" + reportesArchivos + ", Grupos=" + grupo + " where IDusuario=" + id + "";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        connection.Close();
                        return "Permisos modificados con exito";
                    }
                    catch(Exception ex)
                    {
                        return "Error al modificar permisos" + ex;
                    }
                   
                }
            }
        }
        public bool obtenerUsuarios()
        {
            return CacheGrupos.Usuarios;
        }
        public bool obtenerArchivos()
        {
            return CacheGrupos.Archivos;
        }
        public bool obtenerMaterias()
        {
            return CacheGrupos.Materias;
        }
        public bool obtenerCarreras()
        {
            return CacheGrupos.Carreras;
        }
        public bool obtenerBaseDatos()
        {
            return CacheGrupos.BaseDatos;
        }
        public bool obtenerReportesAuditoria()
        {
            return CacheGrupos.reportesAuditoria;
        }
        public bool obtenerReportesArchivos()
        {
            return CacheGrupos.ReportesArchivos;
        }
        public bool obtenerGrupo()
        {
            return CacheGrupos.Grupo;
        }

    }
}
