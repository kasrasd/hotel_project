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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RoomManageEdit : Window
    {
        int _idRoom=0;
        public RoomManageEdit(int idRoom)
        {
            InitializeComponent();
            _idRoom = idRoom;
            LoadRoom();
        }


        private void LoadRoom()
        {
            var room = DB.staticClass.db.Rooms.Where(i => i.room_id == _idRoom).FirstOrDefault();
            if(room != null)
            {
                RoomNum.Text = room.room_num;

                DaysR.Text = Convert.ToString(room.days_reserve);
                
            }
        }
        

        private void cancelBtn_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("آیا مطمينید؟", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                new DB.Edition().RemoveRoom(_idRoom, RoomNum.Text);
                MessageBox.Show("حذف شد");
                this.Close();
            }
            else
                this.Close();
        }
    }
}
