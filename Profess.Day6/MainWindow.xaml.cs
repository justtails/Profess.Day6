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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Profess.Day6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Привет, мир!", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnStackPanelExample_Click(object sender, RoutedEventArgs e)
        {
            new WindowStackPanel().Show();
        }

        private void btnDockPanelExample_Click(object sender, RoutedEventArgs e)
        {
            new WindowDockPanel().Show();
        }

        private void btnWrapPanelExample_Click(object sender, RoutedEventArgs e)
        {
            new WindowWrapPanel().Show();
        }

        private void btnWeather_Click(object sender, RoutedEventArgs e)
        {
            new WindowWeather().Show();
        }
    }
}
