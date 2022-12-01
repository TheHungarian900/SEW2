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

namespace _221124_HighLow_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int RandomNum, tries = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            double num;

            if(lblClue.Content != "Too big!" && lblClue.Content != "Too small!")
            {
                lblTries.Content = "";
                RandomNum = RandomNumber(1, 100);
            }
            if(lblClue.Content== "Right!")
            {
                txtNum.Text = "";
                lblClue.Content = "";
            }

            txtNum.IsReadOnly = false;
            btnCheck.Content = "Check";

            if(double.TryParse(txtNum.Text, out num) == true)
            {
                if(num < RandomNum)
                {
                    lblClue.Content = "Too small!";
                    tries++;
                }
                else if(num > RandomNum)
                {
                    lblClue.Content = "Too big!";
                    tries++;
                }
                else
                {
                    tries++;
                    lblClue.Content = "Right!";
                    lblTries.Content = tries + " Tries";
                    btnCheck.Content = "Restart";
                    txtNum.IsReadOnly = true;
                }
            }
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
