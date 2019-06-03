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

namespace CultureOfPakistan
{
    /// <summary>
    /// Interaction logic for frm_Balochistan.xaml
    /// </summary>
    public partial class frm_Balochistan : UserControl
    {

        MainWindow mainWindow;

        public frm_Balochistan(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            balochistan_sports_festival.Visibility = Visibility.Visible;
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.callCountryMap();
        }

        private void Rd_Btn_festival_Checked(object sender, RoutedEventArgs e)
        {
            checkd();
            
        }

        private void Rd_Btn_big_city_Checked_1(object sender, RoutedEventArgs e)
        {
            checkd();
        }

        private void Rd_Btn_big_city_Checked(object sender, RoutedEventArgs e)
        {
            checkd();
        }

        private void Rd_Btn_traditional_food_Checked(object sender, RoutedEventArgs e)
        {
            checkd();
        }

        private void Rd_Btn_traditional_dress_Checked(object sender, RoutedEventArgs e)
        {
            checkd();
        }

        private void Rd_Btn_places_to_visit_Checked(object sender, RoutedEventArgs e)
        {
            checkd();
        }



        void checkd(){
            if (Rd_Btn_festival.IsChecked == true)
            {
                balochistan_sports_festival.Visibility = Visibility.Hidden;

            }
          
            else if (Rd_Btn_places_to_visit.IsChecked ==true)
            {
                balochistan_sports_festival.Visibility = Visibility.Visible;
            }
            else if (Rd_Btn_traditional_dress.IsChecked == true)
            {

            }
            else if (Rd_Btn_traditional_food.IsChecked == true)
            {

            }
            else if (Rd_Btn_big_city.IsChecked == true)
            {
                balochistan_sports_festival.Visibility = Visibility.Hidden;
            }
            


        }

        
    }
 
}
