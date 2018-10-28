using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using SDLib.ReversePolishNotation;

namespace Lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> CalculationLog;
        private SDLib.ReversePolishNotation.ReversePolishNotation rpn;
        public MainWindow()
        {
            InitializeComponent();
            rpn = new ReversePolishNotation();
            CalculationLog = new ObservableCollection<string>();
            LogPanel.ItemsSource = CalculationLog;
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

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            double result;
            if (rpn.Calculate(CalculationWindow.Text, out result))
            {
                CalculationLog.Add(CalculationWindow.Text + " = " + ((decimal)result).ToString());
                CalculationWindow.Text = ((decimal)result).ToString();
            }
            else
            {
                CalculationLog.Add("Ошибка. Проверьте правильность ввода выражения.");
            }
        }
    }
}
