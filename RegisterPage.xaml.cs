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
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (TxtPassword.Password == TxtPasswordConfirm.Password)
            {
                new DB.Edition().SaveGuest(Txtname.Text, TxtUname.Text, TxtPassword.Password);
                MessageBox.Show("ثبت شد");
                Txtname.Text = "";
                TxtUname.Text = "";
                TxtPasswordConfirm.Password = "";
                TxtPassword.Password = "";

            }
        }


    }
}
