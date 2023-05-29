using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Food
{
    class Database
    {
        public MySqlConnection connection = new MySqlConnection("SERVER=localhost ;DATABASE=food ;UID=root ;PASSWORD=QkUC7bmE ;");
        public MySqlConnection connection2 = new MySqlConnection("SERVER=127.0.0.1 ;DATABASE=registration ;UID=root ;PASSWORD=QkUC7bmE ;");

        public void OpenConnection(MySqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection(MySqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection(MySqlConnection connection)
        {
            return connection;
        }
    }
}
