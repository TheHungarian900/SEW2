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

            double amount, singlePrice, discountPercentage, salesLimit = 0;

            if (Double.TryParse(txtAmmount.Text, out amount) == true &&
               Double.TryParse(txtprice.Text, out singlePrice) == true)
            {
                double turnover = amount * singlePrice;

                var lboItem = lboSalesLimit.SelectedItem as ListBoxItem;
                if (lboItem != null)
                {
                    salesLimit = Convert.ToDouble(lboItem.Content);
                }

                if (turnover <= salesLimit)
                {
                    discountPercentage = 0;
                }
                else
                {
                    discountPercentage = 0.15;
                }

                double discount = turnover * discountPercentage;
                double endPrice = turnover - discount;

                // GUI Part
                lblDiscountPercent.Content = discountPercentage * 100 + "%";
                lblDiscount.Content = discount;
                lblEndPrice.Content = endPrice;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
