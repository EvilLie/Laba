using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Laba
{
    public partial class Registration : Window
    {
        private string username, password, sql;
        private DB conn = new DB();
        private MySqlCommand command;
        public Registration()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();           
            Close();
            login.Show();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            username = LoginRegistrationTextBox.Text;
            password = PasswordRegistrationTextBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBoxResult result = MessageBox.Show("Username/password is empty");
            }
            else
            {
                sql = "INSERT INTO users (username, password) VALUES ('" + username + "','" + password + "')";
            }
            if (conn.OpenConnection() == true)
            {
                try
                {
                    command = new MySqlCommand(sql, conn.GetConnection());
                    object b = command.ExecuteNonQuery();
                    if ((int)b == -1)
                    {
                        MessageBoxResult result = MessageBox.Show("Troubles with database");
                    }
                    else
                    {
                        sql = "SELECT username FROM users WHERE username = '" + username + "' AND password = '" + password + "'";                     
                            try
                            {
                                command = new MySqlCommand(sql, conn.GetConnection());
                                object a = command.ExecuteScalar();
                                if (a == null)
                                {
                                    MessageBoxResult result = MessageBox.Show("Invalid username/password");
                                }
                                else
                                {
                                    MainWindow mainWindow = new MainWindow();
                                    mainWindow.Show();
                                    Close();
                                }
                            }
                            catch (MySqlException x)
                            {
                                MessageBoxResult result = MessageBox.Show("" + x);
                            }
                    }
                }
                catch (MySqlException x)
                {
                    MessageBoxResult result = MessageBox.Show("" + x);
                }
            }
        }
    }
}
