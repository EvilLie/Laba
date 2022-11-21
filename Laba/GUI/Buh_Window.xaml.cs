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
    /// Interaction logic for Buh_Window.xaml
    /// </summary>
    public partial class Buh_Window : Window
    {
        public Buh_Window()
        {
            InitializeComponent();
        }

        private void PaymentCheck_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет проверка оплаты заказа";          
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void CreatingAccount_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет логика создание счёта";
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void CreatingWaybill_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет логика создания накладной";
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
