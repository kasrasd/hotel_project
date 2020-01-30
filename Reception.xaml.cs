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
using hotel_project1.Model;

namespace hotel_project1
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Reciption : Page
    {

        public Reciption()
        {
            InitializeComponent();

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage();
            this.NavigationService.Navigate(mp);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            ReciptionPageR mp = new ReciptionPageR();
            this.NavigationService.Navigate(mp);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            RoomPage mp = new RoomPage();
            this.NavigationService.Navigate(mp);
        }
    }



}
