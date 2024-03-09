using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos
{
    public class BKP: SQL
    {
        private readonly string ConnectionString;

        public string GenerarBKP()
        {
            string NombreBackup = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-StudySphereAPP.bak");
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = "BACKUP DATABASE [StudySphereAPP] TO  DISK = N'" +
                            "C:\\Program Files\\Microsoft SQL Server\\MSSQL16.SQLEXPRESS\\MSSQL\\Backup\\"+NombreBackup +
                            "' WITH NOFORMAT, NOINIT,  NAME = N'StudySphereAPP-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                        return "Backup realizado con exito";
                    }catch(Exception ex)
                    {
                        return ex.Message;
                    }
                    
                }
            }
        }
        public string RestaurarBKP(string path)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = connection;
                        command.CommandText = "USE [master] ALTER DATABASE[StudySphereAPP] SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                            " RESTORE DATABASE[StudySphereAPP] FROM DISK = N'"+path+"' WITH FILE = 1, NOUNLOAD, STATS = 5 \n " +
                            "ALTER DATABASE[StudySphereAPP] SET MULTI_USER";
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                        return "Restauracion realizada con exito";
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
            }
        }
    }
}
