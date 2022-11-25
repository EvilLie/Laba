using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;

namespace Laba
{
    public partial class AddProducts : Window
    {
        private int prodCol ,prodPrice;
        private string prodName, sql;
        private DB conn = new DB();
        private MySqlCommand command;
        MySqlDataReader reader;
        DataTable dataTable = new DataTable();
 
        public AddProducts()
        {
            InitializeComponent();
            OpenProductList();
        }

        private void Update_DataTableButton_Click(object sender, RoutedEventArgs e)
        {
            dtGrid.ItemsSource = null;
            dtGrid.Items.Clear();   
            sql = "SELECT * FROM products";
            dataTable = new DataTable();
            command = new MySqlCommand(sql, conn.GetConnection());
            reader = command.ExecuteReader();
            dataTable.Load(reader);
            reader.Close();
            conn.CloseConnection();
            dtGrid.ItemsSource = dataTable.DefaultView;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager_Window manager_Window = new Manager_Window();
            manager_Window.Show();
            Close();
        }

        private void OpenProductList()
        {
                conn.OpenConnection();
                sql = "SELECT * FROM products";
                command = new MySqlCommand(sql,conn.GetConnection());
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                conn.CloseConnection();
                dtGrid.ItemsSource = dataTable.DefaultView;
                 
        }
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                prodName = ProductNameTextBox.Text;
                prodCol = Convert.ToInt32(ProductColTextBox.Text);
                prodPrice = Convert.ToInt32(ProductCostTextBox.Text);
                if (string.IsNullOrEmpty(prodName))
                {
                    MessageBoxResult result = MessageBox.Show("Product name is empty");
                }
                else
                {
                    sql = "INSERT INTO products (productName,productPrice,productCol) VALUES ('" + prodName + "','" + prodPrice + "','" + prodCol + "')";
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
                        }
                        catch (MySqlException x)
                        {
                            MessageBoxResult result = MessageBox.Show("" + x);
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBoxResult result = MessageBox.Show("There is letter in product number, or product cost please try again");
                return;
            }         
        }     
    }
}
