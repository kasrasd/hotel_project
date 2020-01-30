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
    public partial class ClerkManageEdit : Window
    {
        int _idEmployee=0;
        public ClerkManageEdit(int idEmployee)
        {
            InitializeComponent();
            _idEmployee = idEmployee;
            LoadEmployee();
        }


        private void LoadEmployee()
        {
            var clerk = DB.staticClass.db.Employees.Where(i => i.employee_id == _idEmployee).FirstOrDefault();
            if(clerk != null)
            {
                TxtName.Text = clerk.name;
                TxtSal.Text = clerk.salary;
                TxtJob.Text = clerk.job;
                TxtNational.Text = clerk.national_code;
                TxtNational.Text = clerk.national_code;
                TxtUserName.Text = clerk.user_name;
                TxtPass.Password = clerk.password;
                
            }
        }
        

        private void cancelBtn_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            new DB.Edition().EditClerk(_idEmployee, TxtName.Text, TxtSal.Text, TxtJob.Text, TxtNational.Text, TxtUserName.Text, TxtPass.Password);
            MessageBox.Show("ویرایش انجام شد");
            this.Close();
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("آیا مطمينید؟", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                new DB.Edition().RemoveClerk(_idEmployee, TxtName.Text, TxtSal.Text, TxtJob.Text, TxtNational.Text, TxtUserName.Text, TxtPass.Password);
                MessageBox.Show("حذف شد");
                this.Close();
            }
            else
                this.Close();
        }
    }
}
