using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Laba
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClientButton_Click(object sender, RoutedEventArgs e)
        {
            Client_Window p = new Client_Window();
            p.Show();
            Close();
        }

        private void BuhButton_Click(object sender, RoutedEventArgs e)
        {
            Buh_Window p = new Buh_Window();
            p.Show();
            Close();
        }
        private void ManagerButton_Click(object sender, RoutedEventArgs e)
        {
            Manager_Window p = new Manager_Window();
            p.Show();
            Close();
        }
    }
}
