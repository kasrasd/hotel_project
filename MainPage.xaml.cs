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
using hotel_project1.DB;

namespace hotel_project1
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Search()
        {
            
            if (TxtUsername.Text != "")
            {
                var manager = staticClass.db.Employees.Where(i => i.user_name == TxtUsername.Text && i.password == TxtPassword.Password && i.job=="مدیر").FirstOrDefault();
                var clerk = staticClass.db.Employees.Where(i => i.user_name == TxtUsername.Text && i.password == TxtPassword.Password && i.job == "پذیرش").FirstOrDefault();
                var guest = staticClass.db.Guests.Where(i => i.user_name == TxtUsername.Text && i.password == TxtPassword.Password).FirstOrDefault();
                if (manager != null)
                {
                    Manager reg = new Manager();
                    this.NavigationService.Navigate(reg);
                }
                
                else if (clerk != null)
                {
                    Reciption reg = new Reciption();
                    this.NavigationService.Navigate(reg);
                }

                else if (guest != null)
                {
                    GuestPage reg = new GuestPage();
                    this.NavigationService.Navigate(reg);
                }

            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MoreInfo moreInfo = new MoreInfo();
            this.NavigationService.Navigate(moreInfo);
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegisterPage reg = new RegisterPage();
            this.NavigationService.Navigate(reg);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RoomsPage roompage = new RoomsPage();
            this.NavigationService.Navigate(roompage);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Search();
        }
    }
}
