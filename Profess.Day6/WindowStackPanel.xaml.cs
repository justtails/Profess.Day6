﻿using System;
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

namespace Profess.Day6
{
    /// <summary>
    /// Логика взаимодействия для WindowStackPanel.xaml
    /// </summary>
    public partial class WindowStackPanel : Window
    {
        public WindowStackPanel()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Добрый день, {tboxFIO.Text}!", "Приветствие", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
