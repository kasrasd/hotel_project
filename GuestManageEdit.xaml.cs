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
    public partial class GuestManageEdit : Window
    {
        int _idGuest=0;
        public GuestManageEdit(int idGuest)
        {
            InitializeComponent();
            _idGuest = idGuest;
            LoadGuest();
        }


        private void LoadGuest()
        {
            var guest = DB.staticClass.db.Guests.Where(i => i.guest_id == _idGuest).FirstOrDefault();
            if(guest != null)
            {
                TxtName.Text = guest.name;
                TxtRoomNum.Text = guest.room_num;
                TxtUserLevel.Text = guest.isVip;
                TxtUserName.Text = guest.user_name;
                TxtPass.Password = guest.password;

            }
        }
        

        private void cancelBtn_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            new DB.Edition().EditGuest(_idGuest, TxtName.Text, TxtUserName.Text, TxtPass.Password, TxtRoomNum.Text, TxtUserLevel.Text);
            MessageBox.Show("ویرایش انجام شد");
            this.Close();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("آیا مطمينید؟", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                new DB.Edition().RemoveGuest(_idGuest, TxtName.Text, TxtUserName.Text, TxtPass.Password, TxtRoomNum.Text, TxtUserLevel.Text);
                MessageBox.Show("حذف شد");
                this.Close();
            }
            else
                this.Close();
        }
    }
}
