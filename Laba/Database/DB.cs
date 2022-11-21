using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Laba
{
    internal class DB
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dataTable;
        private static MySqlDataAdapter dataAdapter;
        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "127.0.0.1";
                builder.UserID = "root";
                builder.Password = "TypicalDatabasePassword";
                builder.Database = "storage";
                builder.SslMode = MySqlSslMode.Disabled;
                connection = new MySqlConnection(builder.ToString());
                string message = "Database connection succesfull";
                MessageBoxResult messageBoxResult = MessageBox.Show(message, "Connectoin", MessageBoxButton.OK);
            }
            catch (Exception)
            {
                string message = "connection failed";
                MessageBoxResult result = MessageBox.Show(message);
            }
        }
    }
}