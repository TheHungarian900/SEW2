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

namespace _221107_Lagebeziehung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            double r, y, x, p;
            bool isOk1, isOk2, isOk3;

            isOk1 = double.TryParse(txtRadius.Text, out r);
            isOk2 = double.TryParse(txtXCoord.Text, out x);
            isOk3 = double.TryParse(txtYCoord.Text, out y);

            if(isOk1 == true && isOk2 == true && isOk3 == true)
            {
                p = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                if(p == r)
                {
                    lblPosition.Content = "Ihr Punkt liegt auf dem Kreis!";
                }
                else if(p < r)
                {
                    lblPosition.Content = "Ihr Punkt liegt innerhalb des Kreises!";
                }
                else
                {
                    lblPosition.Content = "Ihr Punkt liegt außerhalb des Kreises!";
                }

            }
            else
            {
                lblPosition.Content = "Fehlerhafte Eingabe!";
            }

        }
    }
}
