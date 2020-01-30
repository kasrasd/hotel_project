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
    public partial class Manager : Page
    {

        public Manager()
        {
            InitializeComponent();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ManagerPage mp = new ManagerPage();
            this.NavigationService.Navigate(mp);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage();
            this.NavigationService.Navigate(mp);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ReciptionPage mp = new ReciptionPage();
            this.NavigationService.Navigate(mp);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            RoomPageM rpm = new RoomPageM();
            this.NavigationService.Navigate(rpm);
        }
    }



}
