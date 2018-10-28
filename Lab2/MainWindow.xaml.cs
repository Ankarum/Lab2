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

namespace Lab2
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

        private void ButtonContentToWindow(object sender, RoutedEventArgs e)
        {
            CalculationWindow.Text += (sender as Button).Content;
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (CalculationWindow.Text.Length == 0) return;
            CalculationWindow.Text = CalculationWindow.Text.Remove(CalculationWindow.Text.Length - 1);
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            CalculationWindow.Text = "";
        }
    }
}
