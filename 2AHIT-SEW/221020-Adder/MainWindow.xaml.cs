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

namespace _221020_Adder
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double nb1, nb2;
            bool isOk1, isOk2;

            isOk1 = double.TryParse(txtNb1.Text, out nb1);
            isOk2 = double.TryParse(txtNb2.Text, out nb2);

            if(isOk1 == true && isOk2 == true)
            {
                lblSum.Content = nb1 + nb2;
            }
            else
            {
                lblSum.Content = "Fehlerhafte Eingabe!";
            }
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
