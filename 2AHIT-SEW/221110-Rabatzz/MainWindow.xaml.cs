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

namespace _221110_Rabatzz
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

            double amount, singlePrice;

            if(Double.TryParse(txtAmmount.Text, out amount) == true &&
               Double.TryParse(txtprice.Text, out singlePrice) == true)
            {
                double turnover = amount * singlePrice;
                double discountPercentage = calcDiscountPercentage(turnover);

                double discount = turnover * discountPercentage;
                double endPrice = turnover - discount;

                // GUI Part
                lblDiscountPercent.Content = discountPercentage * 100 + "%";
                lblDiscount.Content = discount;
                lblEndPrice.Content = endPrice;
            }

            

        }

        private double calcDiscountPercentage(double turnover)
        {
            
            if(turnover < 1000)
            {
                return 0;
            }
            else if(turnover < 10000)
            {
                return 0.1;
            }
            return 0.2;

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
