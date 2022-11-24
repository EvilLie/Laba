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
        private MySqlConnection conn;
        private string server;
        private string user;
        private string pass;
        private string db;      
        public DB()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            db = "storage";
            user = "root";
            pass = "TypicalDatabasePassword";
            string connectionString;
            connectionString = "Data Source=" + server + ";Database=" + db + ";User Id=" + user + ";Password=" + pass + ";SSL Mode=0";
            conn = new MySqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try 
            {
                conn.Open();
                return true;
            }
            catch(MySqlException e)
            {
                    switch (e.Number)
                {
                    case 0:
                        MessageBoxResult result =  MessageBox.Show("Can't connect to the server");
                        break;
                    case 1045:
                        MessageBoxResult result1 = MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        public void CloseConnection()
        {
            conn.Close();
        }
        public MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}