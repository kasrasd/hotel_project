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

namespace hotel_project1
{
    /// <summary>
    /// Interaction logic for PageReserve.xaml
    /// </summary>
    public partial class PageReserveV11 : Page
    {
        public PageReserveV11()
        {
            InitializeComponent();
        }

        public static string Price(double par)
        {
            string priceSt = Convert.ToString(par);
            int count = 0;
            string res = string.Empty;

            for (int i = 0; i < priceSt.Length; i++)
            {
                if (priceSt[i] != '0')
                    res += Convert.ToString(priceSt[i]);
            }


            for (int i = 0; i<priceSt.Length; i++)
            {
                if (priceSt[i] == '0')
                    count++;
            }
            
            int zeros = count / 3;
            int otherZ = count % 3;

            for (int i = 0; i < otherZ; i++)
            {
                res = res + "0";
            }

            for (int i = 0; i<zeros; i++)
            {
                res = res + ",000";
            }

            return res;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RoomsPage mainRoomPage = new RoomsPage();
            this.NavigationService.Navigate(mainRoomPage);
        }

        private void CSliderValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            totalP.Text = Price(CSlider.Value*400000)+" تومان";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
