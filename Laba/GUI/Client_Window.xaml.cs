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
    /// <summary>
    /// Interaction logic for Client_Window.xaml
    /// </summary>
    public partial class Client_Window : Window
    {
        public Client_Window()
        {
            InitializeComponent();
        }

        private void CreateOrder_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет логика создания заказа";           
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void OrderInfo_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет логика показа информации о заказе";
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void PayOrder_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет логика оплаты заказа";
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void ChangeOrder_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет логика изменения заказа";
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
