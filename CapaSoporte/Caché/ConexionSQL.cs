using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaSoporte.Caché
{
    public abstract class ConexionSQL
    {
        private readonly string ConnectionString;
        public ConexionSQL()
        {
            ConnectionString = "Data Source = DESKTOP-J6FH9OJ\\SQLEXPRESS; Initial Catalog = Studysphere; Integrated Security = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);


        }
    }
}