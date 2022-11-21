using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Laba
{
    internal class DB
    {
        private static MySqlConnection connection;
        private static MySqlDataReader reader = null;
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
                MessageBoxResult messageBoxResult = MessageBox.Show(message, "Connection", MessageBoxButton.OK);
            }
            catch (Exception)
            {
                string message = "Connection failed";
                MessageBoxResult result = MessageBox.Show(message);
            }
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch(Exception)
            {
                string message = "Can't open connection";
                MessageBoxResult result = MessageBox.Show(message);
                return false;
            }
        }
        private bool CloseConnection()
        {
            try 
            {
                connection.Close();
                return true;
            }
            catch
            {
                string message = "Can't close connection";
                MessageBoxResult result = MessageBox.Show(message);
                return false;
            }
        }
        public void Insert(int id)
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void Insert(string id)
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void Update(int id)
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}