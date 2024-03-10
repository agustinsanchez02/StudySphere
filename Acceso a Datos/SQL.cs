using System.Data.SqlClient;

namespace Acceso_a_Datos
{
    public class SQL
    {
        private static SQL _instance;
        private static readonly object _lock = new object();

        public string Conexion { get; private set; }

        private SQL()
        {
            Conexion = "Data Source = DESKTOP-I5B1LQK\\SQLEXPRESS; Initial Catalog = StudySphereAPP; Integrated Security = True";
        }

        public static SQL Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SQL();
                    }
                    return _instance;
                }
            }
        }

    }
}