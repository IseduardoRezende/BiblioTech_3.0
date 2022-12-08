using MySql.Data.MySqlClient;
using System.Configuration;

namespace BiblioTech_3._0.DAO
{
    public class ConnectionFactory
    {
        public static MySqlConnection GetConnection()
        {
            string conector = ConfigurationManager.ConnectionStrings["Bibliotech"].ConnectionString;

            return new MySqlConnection(conector);
        }
    }
}
