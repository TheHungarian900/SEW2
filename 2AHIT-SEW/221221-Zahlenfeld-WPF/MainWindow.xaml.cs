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

namespace _221221_Zahlenfeld_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        double[] f = new double[5];
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string input = txtDec.Text;
            bool isOk;

            if(i < f.Length)
            {
                isOk = double.TryParse(input, out f[i]);

                if (isOk == true)
                {
                    lblInfo.Content = "";

                    ListBox1.Items.Add(f[i]);

                    i++;
                }
                else
                {
                    lblInfo.Content = "Fehlerhafte Eingabe!";
                }
            }
            else
            {
                lblInfo.Content = "Keine weiteren Eingaben möglich!";
                btnAdd.IsEnabled = false;
            }

            
        }

        private void btnDelLast_Click(object sender, RoutedEventArgs e)
        {
            if(i > 0)
            {
                ListBox1.Items.RemoveAt(i - 1);
                btnAdd.IsEnabled = true;
                i--;
            }
            
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
            btnAdd.IsEnabled = true;
            i = 0;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMw_Click(object sender, RoutedEventArgs e)
        {
            int amount = 0;
            double mw;

            var cboItem = cboAmount.SelectedItem as ComboBoxItem;
            if(cboItem != null)
            {
                amount = Convert.ToInt32(cboItem.Content);
            }

            Mittelwert(f, amount, out mw);

            lblMw.Content = mw;
        }

        bool Mittelwert(double[] f, int n, out double mw)
        {
            mw = 0;
            if(0 <= n && n <= f.Length)
            {
                for(i = 0; i < f.Length; i++)
                {
                    mw += f[i];
                }
                mw = mw / n;
                return true;
            }

            return false;
        }
    }
}
