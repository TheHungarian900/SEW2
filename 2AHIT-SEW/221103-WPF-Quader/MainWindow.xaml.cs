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

namespace _221103_WPF_Quader
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
            double height, width, length, Volume, Surface;
            bool isOk1, isOk2, isOk3;

            isOk1 = double.TryParse(txtheight.Text, out height);    //string -> double
            isOk2 = double.TryParse(txtwidth.Text, out width);      //string -> double
            isOk3 = double.TryParse(txtlength.Text, out length);    //string -> double

            if(isOk1 == true && isOk2 == true && isOk3 == true)
            {

                Volume = QuaderCalculation.calcVolume(length, width, height);
                Surface = QuaderCalculation.calcSurface(length, width, height);

                lblVolumen.Content = Volume;
                lblOberflaeche.Content = Surface;

            }
            else
            {
                lblOberflaeche.Content = "Fehlerhafte Eingabe!";
                lblVolumen.Content = "Fehlerhafte Eingabe!";
            }

        }
    }
}
