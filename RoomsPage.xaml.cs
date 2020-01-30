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
    /// Interaction logic for RoomsPage.xaml
    /// </summary>
    public partial class RoomsPage : Page
    {
        public RoomsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void CSliderValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            Stk1.Children.Clear();
            Stk2.Children.Clear();

            if (CSlider.Value == 0)
            {
                Stk1.Children.Add(BtnV11);
                Stk2.Children.Add(BtnV21);
                Stk1.Children.Add(BtnV41);
                Stk2.Children.Add(BtnN11);
                Stk1.Children.Add(BtnN21);
                Stk2.Children.Add(BtnN41);
                Stk1.Children.Add(BtnV12);
                Stk2.Children.Add(BtnV22);
                Stk1.Children.Add(BtnV42);
                Stk2.Children.Add(BtnN12);
                Stk1.Children.Add(BtnN22);
                Stk2.Children.Add(BtnN42);
                Stk1.Children.Add(BtnR);
            }

            if (CSlider.Value == 1)
            {
                
                Stk1.Children.Add(BtnV11);
                Stk2.Children.Add(BtnV12);
                Stk1.Children.Add(BtnN11);
                Stk2.Children.Add(BtnN12);
            }

            if(CSlider.Value == 2)
            {
                Stk1.Children.Add(BtnV21);
                Stk2.Children.Add(BtnV22);
                Stk1.Children.Add(BtnN21);
                Stk2.Children.Add(BtnN22);
                Stk1.Children.Add(BtnR);
            }

            if (CSlider.Value == 3)
            {
                MessageBox.Show("اطلاعاتی برای نمایش موجود نیست");
            }

            if (CSlider.Value == 4)
            {
                Stk1.Children.Add(BtnV41);
                Stk2.Children.Add(BtnV42);
                Stk1.Children.Add(BtnN41);
                Stk2.Children.Add(BtnN42);
            }


        }

        private void PSliderValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Stk1.Children.Clear();
            Stk2.Children.Clear();

            if (PSlider.Value == 0)
            {
                Stk1.Children.Add(BtnV11);
                Stk2.Children.Add(BtnV21);
                Stk1.Children.Add(BtnV41);
                Stk2.Children.Add(BtnN11);
                Stk1.Children.Add(BtnN21);
                Stk2.Children.Add(BtnN41);
                Stk1.Children.Add(BtnV12);
                Stk2.Children.Add(BtnV22);
                Stk1.Children.Add(BtnV42);
                Stk2.Children.Add(BtnN12);
                Stk1.Children.Add(BtnN22);
                Stk2.Children.Add(BtnN42);
                Stk1.Children.Add(BtnR);
            }

            if (PSlider.Value == 500)
            {
                Stk1.Children.Add(BtnV11);
                Stk2.Children.Add(BtnV21);
                Stk1.Children.Add(BtnN11);
                Stk2.Children.Add(BtnN21);
                Stk1.Children.Add(BtnV12);
                Stk2.Children.Add(BtnV22);
                Stk1.Children.Add(BtnN12);
                Stk2.Children.Add(BtnN22);
            }

            if (PSlider.Value == 1000)
            {
                Stk1.Children.Add(BtnV41);
                Stk2.Children.Add(BtnN41);
                Stk1.Children.Add(BtnN42);
                Stk2.Children.Add(BtnV42);
            }

            if (PSlider.Value == 1500)
            {
                Stk1.Children.Add(BtnR);
            }



        }

        private void FSliderValue(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Stk1.Children.Clear();
            Stk2.Children.Clear();

            if (FSlider.Value == 0)
            {
                Stk1.Children.Add(BtnV11);
                Stk2.Children.Add(BtnV21);
                Stk1.Children.Add(BtnV41);
                Stk2.Children.Add(BtnN11);
                Stk1.Children.Add(BtnN21);
                Stk2.Children.Add(BtnN41);
                Stk1.Children.Add(BtnV12);
                Stk2.Children.Add(BtnV22);
                Stk1.Children.Add(BtnV42);
                Stk2.Children.Add(BtnN12);
                Stk1.Children.Add(BtnN22);
                Stk2.Children.Add(BtnN42);
                Stk1.Children.Add(BtnR);
            }

            if (FSlider.Value == 1)
            {
                Stk1.Children.Add(BtnV11);
                Stk2.Children.Add(BtnV21);
                Stk1.Children.Add(BtnV41);
                Stk2.Children.Add(BtnN11);
                Stk1.Children.Add(BtnN21);
                Stk2.Children.Add(BtnN41);
  
            }

            if (FSlider.Value == 2)
            {
                Stk1.Children.Add(BtnV12);
                Stk2.Children.Add(BtnV22);
                Stk1.Children.Add(BtnV42);
                Stk2.Children.Add(BtnN12);
                Stk1.Children.Add(BtnN22);
                Stk2.Children.Add(BtnN42);
            }

            if (FSlider.Value == 3)
            {
                Stk1.Children.Add(BtnR);
            }

        }

        private void BtnV12_Click(object sender, RoutedEventArgs e)
        {
            PageReserve pV12 = new PageReserve();
            this.NavigationService.Navigate(pV12);
        }

        private void NRadio_Checked(object sender, RoutedEventArgs e)
        {
            Stk1.Children.Clear();
            Stk2.Children.Clear();
            Stk1.Children.Add(BtnN11);
            Stk2.Children.Add(BtnN21);
            Stk1.Children.Add(BtnN41);
            Stk2.Children.Add(BtnN12);
            Stk1.Children.Add(BtnN22);
            Stk2.Children.Add(BtnN42);
        }

        private void VRadio_Checked(object sender, RoutedEventArgs e)
        {
            Stk1.Children.Clear();
            Stk2.Children.Clear();
            Stk1.Children.Add(BtnV11);
            Stk2.Children.Add(BtnV21);
            Stk1.Children.Add(BtnV41);
            Stk2.Children.Add(BtnV12);
            Stk1.Children.Add(BtnV22);
            Stk2.Children.Add(BtnV42);
        }

        private void RRadio_Checked(object sender, RoutedEventArgs e)
        {
            Stk1.Children.Clear();
            Stk2.Children.Clear();
            Stk1.Children.Add(BtnR);
        }

        private void BtnV11_Click(object sender, RoutedEventArgs e)
        {
            PageReserveV11 pageV11 = new PageReserveV11();
            this.NavigationService.Navigate(pageV11);
        }

        private void BtnR_Click(object sender, RoutedEventArgs e)
        {
            PageReserveR pageR = new PageReserveR();
            this.NavigationService.Navigate(pageR);
        }

        private void BtnV22_Click(object sender, RoutedEventArgs e)
        {
            PageReserveV22 V22 = new PageReserveV22();
            this.NavigationService.Navigate(V22);
        }

        private void BtnV42_Click(object sender, RoutedEventArgs e)
        {
            PageReserveV24 V24 = new PageReserveV24();
            this.NavigationService.Navigate(V24);
        }

        private void BtnN12_Click(object sender, RoutedEventArgs e)
        {
            PageReserveN21 V21 = new PageReserveN21();
            this.NavigationService.Navigate(V21);
        }

        private void BtnN22_Click(object sender, RoutedEventArgs e)
        {
            PageReserveN22 N22 = new PageReserveN22();
            this.NavigationService.Navigate(N22);
        }

        private void BtnN42_Click(object sender, RoutedEventArgs e)
        {
            PageReserveN24 N24 = new PageReserveN24();
            this.NavigationService.Navigate(N24);
        }

        private void BtnV21_Click(object sender, RoutedEventArgs e)
        {
            PageReserveV12 V24 = new PageReserveV12();
            this.NavigationService.Navigate(V24);
        }

        private void BtnV41_Click(object sender, RoutedEventArgs e)
        {
            PageReserveV14 V24 = new PageReserveV14();
            this.NavigationService.Navigate(V24);
        }

        private void BtnN11_Click(object sender, RoutedEventArgs e)
        {
            PageReserveN11 V24 = new PageReserveN11();
            this.NavigationService.Navigate(V24);
        }

        private void BtnN21_Click(object sender, RoutedEventArgs e)
        {
            PageReserveN12 V24 = new PageReserveN12();
            this.NavigationService.Navigate(V24);
        }

        private void BtnN41_Click(object sender, RoutedEventArgs e)
        {
            PageReserveN14 V24 = new PageReserveN14();
            this.NavigationService.Navigate(V24);
        }
    }






}
