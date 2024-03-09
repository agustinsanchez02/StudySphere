using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class SQL
    {
        private readonly string ConnectionString;
        public SQL()
        {
            ConnectionString = "Data Source = DESKTOP-I5B1LQK\\SQLEXPRESS; Initial Catalog = StudySphereAPP; Integrated Security = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);

        }



    }
}