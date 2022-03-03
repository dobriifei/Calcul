using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
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

namespace Calcul
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string V = "CE";
        int first;
        int second;
        char operation;
        public MainWindow()
        {
            InitializeComponent();
         
        }
        private void Button_Click(object sender, RoutedEventArgs e)
            {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();
            second = Int32.Parse(TxtResult.Text);
            }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            operation = '/';
            TxtResult.Clear();

        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            operation = '*';
            TxtResult.Clear();

        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            operation = '-';
            TxtResult.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TxtResult.Text);
            operation = '+';
            TxtResult.Clear();
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(TxtResult.Text);
            operation = 'V';
            TxtResult.Clear();
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            second=Int32.Parse(TxtResult.Text);
            int result = 0;
            if (operation == '+')
            {
                result = first + second;
            }
            else
             if (operation == '-')
            {
                result = first - second;
            }
            else
             if (operation == '*')
            {
                result = first * second;
            }
            else
             if (operation == '/')
            {
                result = first / second;

            }

            else
             if (operation == 'V')
            {
                TxtResult.Clear();
            }
        
            
    TxtResult.Text = result.ToString();
        }

        
    }
}