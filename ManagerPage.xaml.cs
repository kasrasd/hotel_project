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
    public partial class ManagerPage : Page
    {
        List<DB.Employee> lstClerks = new List<DB.Employee>();
        public ManagerPage()
        {
            InitializeComponent();
            LoadClerk();
        }

        public void LoadClerk()
        {
            int row = 0;
            lstClerks = DB.staticClass.db.Employees.ToList();
            lVC.ItemsSource = from i in lstClerks
                              select new Clerck()
                              {
                                  ID = i.employee_id,
                                  Row = row += 1,
                                  Name = i.name,
                                  Salary = Convert.ToInt32(i.salary),
                                  Job = i.job,
                                  NationalCode = i.national_code,
                                  PassWord = i.password,
                                  UserName = i.user_name
                              };

                              
        }

        private void Search()
        {
            int row = 0;
            if (TxtSearch.Text != "")
            {
                var lstClerk = from i in lstClerks
                               where i.name.Contains(TxtSearch.Text) || i.job.Contains(TxtSearch.Text) || i.national_code.Contains(TxtSearch.Text) 
                               select new Clerck()
                               {
                                   ID = i.employee_id,
                                   Row = row += 1,
                                   Name = i.name,
                                   Salary = Convert.ToInt32(i.salary),
                                   Job = i.job,
                                   NationalCode = i.national_code,
                                   PassWord = i.password,
                                   UserName = i.user_name

                               };

                lVC.ItemsSource = lstClerk;
            }
            else
            {
                var lstClerk = from i in lstClerks
                               select new Clerck()
                               {
                                   ID = i.employee_id,
                                   Row = row += 1,
                                   Name = i.name,
                                   Salary = Convert.ToInt32(i.salary),
                                   Job = i.job,
                                   NationalCode = i.national_code,
                                   PassWord = i.password,
                                   UserName = i.user_name

                               };

                lVC.ItemsSource = lstClerk;
            }
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(lVC.SelectedItem != null)
            {
                int id = (lVC.SelectedItem as Clerck).ID;
                ClerkManageEdit cLME = new ClerkManageEdit(id);
                cLME.ShowDialog();

                LoadClerk();
            }
            
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Search();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ClerkManage cLM = new ClerkManage();
            cLM.ShowDialog();

            LoadClerk();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager main = new Manager();
            this.NavigationService.Navigate(main);
        }
    }
}
