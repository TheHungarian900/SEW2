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

namespace _230119_WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input1, input2;
        bool isOk1, isOk2;
        double result = 0;
        double num1, num2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            if(isOk1 == true && isOk2 == true)
            {
                result = num1 + num2;
                lblResult.Content = result;
            }
            else
            {
                lblResult.Content = "Fehlerhafte Eingabe!";
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            if (isOk1 == true && isOk2 == true)
            {
                result = num1 - num2;
                lblResult.Content = result;
            }
            else
            {
                lblResult.Content = "Fehlerhafte Eingabe!";
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            if (isOk1 == true && isOk2 == true)
            {
                result = num1 * num2;
                lblResult.Content = result;
            }
            else
            {
                lblResult.Content = "Fehlerhafte Eingabe!";
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            isOk(out isOk1, out isOk2);

            if (isOk1 == true && isOk2 == true)
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                    lblResult.Content = result;
                }
                else
                {
                    lblResult.Content = "Fehlerhafte Eingabe!";
                }
            }
            else
            {
                lblResult.Content = "Fehlerhafte Eingabe!";
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void isOk(out bool isOk1, out bool isOk2)
        {
            input(out input1, out input2);

            isOk1 = double.TryParse(input1, out num1);
            isOk2 = double.TryParse(input2, out num2);
        }
        private void input(out string input1, out string input2)
        {
            input1 = txtNumber1.Text;
            input2 = txtNumber2.Text;
        }
    }
}
