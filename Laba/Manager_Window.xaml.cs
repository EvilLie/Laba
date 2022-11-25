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
    public partial class Manager_Window : Window
    {
        public Manager_Window()
        {
            InitializeComponent();
        }  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "А здесь будет список продуктов на покупку, менеджер сможет менять заказ в случае его изменения";
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void AddNewProductsButton_Click(object sender, RoutedEventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.Show();
            Close();
        }
    }
}
