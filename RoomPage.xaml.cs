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
    public partial class RoomPage : Page
    {
        List<DB.Room> lstRooms = new List<DB.Room>();
        public RoomPage()
        {
            InitializeComponent();
            LoadRoom();
        }

        public void LoadRoom()
        {
            int row = 0;
            lstRooms = DB.staticClass.db.Rooms.ToList();
            lVC.ItemsSource = from i in lstRooms
                              select new Room()
                              {
                                  ID = i.room_id,
                                  Row = row += 1,
                                  RoomNum = i.room_num,
                                  RDate = i.reserve_date,
                                  DReserve = i.days_reserve,
                                  IsEmpty = i.isEmpty,
                                  Status = i.Status
                              };

                              
        }

        private void Search()
        {
            int row = 0;
            if (TxtSearch.Text != "")
            {
                var lstRoom = from i in lstRooms
                               where i.room_num.Contains(TxtSearch.Text) || i.isEmpty.Contains(TxtSearch.Text)
                               select new Room()
                               {
                                   ID = i.room_id,
                                   Row = row += 1,
                                   RoomNum = i.room_num,
                                   RDate = i.reserve_date,
                                   DReserve = i.days_reserve,
                                   IsEmpty = i.isEmpty,
                                   Status = i.Status

                               };

                lVC.ItemsSource = lstRoom;
            }
            else
            {
                var lstRoom = from i in lstRooms
                              select new Room()
                              {
                                  ID = i.room_id,
                                  Row = row += 1,
                                  RoomNum = i.room_num,
                                  DReserve = i.days_reserve,
                                  RDate = i.reserve_date,
                                  IsEmpty = i.isEmpty,
                                  Status = i.Status

                               };

                lVC.ItemsSource = lstRoom;
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(lVC.SelectedItem != null)
            {
                int id = (lVC.SelectedItem as Room).ID;
                RoomManageEdit cLME = new RoomManageEdit(id);
                cLME.ShowDialog();

                LoadRoom();
            }
            
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Reciption rp = new Reciption();
            this.NavigationService.Navigate(rp);
        }
    }
}
