using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace MrGrill.Data
{
    public class Connection
    {
        private String server = "sql5.freesqldatabase.com";
        private String userId = "sql5793767";
        private String password = "55wHSbTfvK";

        private MySqlConnection connection;
        public Connection()
        {
            string connectionString = $"Server={server};User ID={userId};Password={password};Database={userId};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
