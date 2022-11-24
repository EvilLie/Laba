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
using MySql.Data.MySqlClient;


namespace Laba
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private string username, password, sql;
        private DB conn = new DB();
        private MySqlCommand command;

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to exit?", "Exit" , MessageBoxButton.YesNo);
            switch(result)
            {
                case MessageBoxResult.Yes:
                    Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            username = LoginTextBox.Text;
            password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(username)||string.IsNullOrEmpty(password))
            {
                MessageBoxResult result = MessageBox.Show("Username/password is empty");
            }
            else
            {
                sql = "SELECT username FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
                if(conn.OpenConnection() == true)
                {
                    try
                    {
                        command = new MySqlCommand(sql, conn.GetConnection());
                        object a = command.ExecuteScalar();
                        if(a == null)
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
                    catch(MySqlException x)
                    {
                        MessageBoxResult result = MessageBox.Show("" + x);
                    }
                }
            }
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            conn.CloseConnection();
        }
    }
}
