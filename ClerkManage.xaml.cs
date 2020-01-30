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
    public partial class ClerkManage : Window
    {
        public ClerkManage()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            new DB.Edition().SaveClerk(TxtName.Text, TxtSal.Text, TxtJob.Text, TxtNational.Text,TxtUserName.Text, TxtPass.Password);
            MessageBox.Show("ثبت شد");
            TxtName.Text = "";
            TxtSal.Text = "";
            TxtJob.Text = "";
            TxtNational.Text = "";
            TxtUserName.Text = "";
            TxtPass.Password = "";
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
