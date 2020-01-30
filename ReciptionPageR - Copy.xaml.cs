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
    public partial class GuestPage : Page
    {
        List<DB.Guest> lstGuests = new List<DB.Guest>();
        public GuestPage()
        {
            InitializeComponent();
            LoadGuest();
        }

        public void LoadGuest()
        {
            int row = 0;
            lstGuests = DB.staticClass.db.Guests.ToList();
            lVCC.ItemsSource = from i in lstGuests
                               select new Guest()
                               {
                                   ID = i.guest_id,
                                   Row = row += 1,
                                   Name = i.name,
                                   RoomNum = i.room_num,
                                   PassWord = i.password,
                                   UserName = i.user_name,
                                   UserLevel = i.isVip
                              };

                              
        }

        private void Search()
        {
            int row = 0;
            if (TxtSearch.Text != "")
            {
                var lstGuest = from i in lstGuests
                               where i.name.Contains(TxtSearch.Text) || i.room_num.Contains(TxtSearch.Text) 
                               select new Guest()
                               {
                                   ID = i.guest_id,
                                   Row = row += 1,
                                   Name = i.name,
                                   RoomNum = i.room_num,
                                   PassWord = i.password,
                                   UserName = i.user_name,
                                   UserLevel = i.isVip

                               };

                lVCC.ItemsSource = lstGuest;
            }
            else
            {
                var lstGuest = from i in lstGuests
                               select new Guest()
                               {
                                   ID = i.guest_id,
                                   Row = row += 1,
                                   Name = i.name,
                                   RoomNum = i.room_num,
                                   PassWord = i.password,
                                   UserName = i.user_name,
                                   UserLevel = i.isVip

                               };

                lVCC.ItemsSource = lstGuest;
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(lVCC.SelectedItem != null)
            {
                int id = (lVCC.SelectedItem as Guest).ID;
                GuestManageEdit cLME = new GuestManageEdit(id);
                cLME.ShowDialog();

                LoadGuest();
            }
            
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage main = new MainPage();
            this.NavigationService.Navigate(main);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reciption main = new Reciption();
            this.NavigationService.Navigate(main);
        }
    }
}
