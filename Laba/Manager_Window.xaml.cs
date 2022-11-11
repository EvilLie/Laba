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
    /// Interaction logic for Manager_Window.xaml
    /// </summary>
    public partial class Manager_Window : Window
    {
        public Manager_Window()
        {
            InitializeComponent();
        }

        private void CheckProduct_Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Здесь будет проверка наличия продукта на складе";
            MessageBoxResult result = MessageBox.Show(message);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "А здесь будет список продуктов на покупку, менеджер сможет менять заказ в случае его изменения";
            MessageBoxResult result = MessageBox.Show(message);
        }
    }
}
