
using System.Windows;
using System.Windows.Input;


namespace CultureOfPakistan
{
    
    public partial class frm_CountryMap : System.Windows.Controls.UserControl
    {

        MainWindow mainWindow;

        public frm_CountryMap(MainWindow mainWindow)
        {

            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        private void Pth_balochistan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.callBalochitan();
        }

        private void Pth_sindh_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.callSindh();
        }

        private void Pth_punjab_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.callPunjab();
        }

        private void Pth_KPK_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.callKPK();
        }

        private void Pth_gilgitbaltistan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.callGilgitbaltistan();
        }

        private void pth_testing_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("it is that easy... don't tell somethong else!!!!");
        }
    }

    }
