using MySql.Data.MySqlClient;
using System.Windows;

namespace Laba
{
    public partial class Registration : Window
    {
        int userrole = 1;
        private string username, password, role, sql;
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
            role = LicenseTextBox.Text;
            if (role.ToLower().Trim() == "buhgalter")
            {
                userrole = 2;
            }
            else if (role.ToLower().Trim() == "manager")
            {
                userrole = 3;
            }
            else
            {
                userrole = 1;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBoxResult result = MessageBox.Show("Username/password is empty");
            }
            else
            {
                sql = "INSERT INTO users (username, password, userrole) VALUES ('" + username + "','" + password + "','" + userrole + "')";
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
                                userrole = 1;
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
