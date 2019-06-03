using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
//using System.Windows.Navigation;
//using System.Windows.Shapes;
//using System.IO;
//using System.Drawing;



namespace CultureOfPakistan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<string> list = new List<string>();
        //Button btnBack = new Button();
        public string selectedItem = "";
      public  string regionID = "";
        public MainWindow()
        {
            InitializeComponent();
                     
            list.Add("Festivals");
            list.Add("Cuisine");
            list.Add("Places to visit");
            list.Add("Traditional Dress");
            lbx_options.ItemsSource = list;
            lbx_options.SelectedIndex = 0;
            
        }

     
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
       public void picture(string selectedItem ,string regionID)
        {
            List<string> allImages = new List<string>();
            List<string> allImagesdscription = new List<string>();

            if (regionID == "1") 
            {
                
                allImages = (from culture in App._sindhStorage
                             where culture.ID == selectedItem & culture.regionID == regionID
                             select culture.Images).ToList();



                allImagesdscription = (from discription in App._sindhStorage
                                       where discription.ID == selectedItem & discription.regionID == regionID
                                       select discription.description).ToList();

            }
            else if (regionID == "2")
            {
                allImages = (from culture in App._balochistanStorage
                             where culture.ID == selectedItem & culture.regionID == regionID
                             select culture.Images).ToList();



                allImagesdscription = (from discription in App._balochistanStorage
                                       where discription.ID == selectedItem & discription.regionID == regionID
                                       select discription.description).ToList();

            }
            else if (regionID == "3")
            {
                allImages = (from culture in App._punjabStorage
                                          where culture.ID == selectedItem & culture.regionID == regionID
                                          select culture.Images).ToList();



                allImagesdscription = (from discription in App._punjabStorage
                                       where discription.ID == selectedItem & discription.regionID == regionID
                                       select discription.description).ToList();

            }
            else if (regionID == "4")
            {

                allImages = (from culture in App._kpkStorage
                             where culture.ID == selectedItem & culture.regionID == regionID
                             select culture.Images).ToList();



                allImagesdscription = (from discription in App._kpkStorage
                                       where discription.ID == selectedItem & discription.regionID == regionID
                                       select discription.description).ToList();
            }
            else 
            {
                allImages = (from culture in App._gilgitbaltistanStorage
                             where culture.ID == selectedItem & culture.regionID == regionID
                             select culture.Images).ToList();



                allImagesdscription = (from discription in App._gilgitbaltistanStorage
                                       where discription.ID == selectedItem & discription.regionID == regionID
                                       select discription.description).ToList();
            }



            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            PanelToDisplayImages.Visibility = Visibility.Visible;
            PanelToDisplayImages.Children.Clear();
            int count = 0;
            int i = 0;
            foreach (string img in allImages)
            {

                System.Windows.Controls.Image imgPakistan = new System.Windows.Controls.Image();
                string imgPath = "/CultureOfPakistan;component/Pictures/" + img;
                imgPakistan.Source = new BitmapImage(new Uri(imgPath, UriKind.Relative));
                

                Label labelText = new Label();
                labelText.Content="";
                labelText.Content = allImagesdscription[i];//"Hello From Pakistan. Welcome to Pakistan";
                labelText.IsEnabled = false;
                
                PanelToDisplayImages.Children.Add(imgPakistan);
                PanelToDisplayImages.Children.Add(labelText);
                imgPakistan.MouseDown += imgPakistan_MouseDown;
                Grid.SetRow(imgPakistan, 0);
                Grid.SetRow(labelText, 2);
                Grid.SetColumn(imgPakistan, count);
                Grid.SetColumn(labelText, count);
                count += 2;
                i++;
            }
            count = 0;
        }


        private void imgPakistan_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            PanelToDisplayImages.Visibility = Visibility.Collapsed;
            grdDisplayLargeImage.Visibility = Visibility.Visible;
            grdDisplayLargeImage.Children.Clear();
            string  imageName = System.IO.Path.GetFileName(((System.Windows.Controls.Image)sender).Source.ToString());
            System.Windows.Controls.Image imgPakistan = new System.Windows.Controls.Image();
            imgPakistan.Source = ((System.Windows.Controls.Image)sender).Source;
            imgPakistan.Height = 400;
            imgPakistan.Width = 700;
            TextBlock imageLabel = new TextBlock();
            imageLabel.TextWrapping = TextWrapping.Wrap;
            


            if (imageName == "sindhiCultureDay.JPG" || imageName == "sindhiCultureDay1.JPG" || imageName == "sindhiDewaliInKhi.jpg")
            {
                imageLabel.Text = (from culture in App._sindhStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "sindhiChanaPuri.jpg" || imageName == "sindhiBiryani.jpg" || imageName == "sindhiRabri.jpg")
            {
                imageLabel.Text = (from culture in App._sindhStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "sindhiMoenjoDaro.JPG" || imageName == "sindhiEmpressMarket.jpg" || imageName == "sindhiRanikotFort.jpg")
            {
                imageLabel.Text = (from culture in App._sindhStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "sindhiAjrakKoti.jpg" || imageName == "sindhiAjrak.JPG" || imageName == "sindhiShaziaKhushk.jpg")
            {
                imageLabel.Text = (from culture in App._sindhStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "balochistanBolanJeepRally.jpg" || imageName == "balochistanFolkFestivalSibi.jpg" || imageName == "balochistanSibiMela.jpg")
            {
                imageLabel.Text = (from culture in App._balochistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "balochistanTraditionalStyleBreakfast.jpg" || imageName == "balochistanSajji.jpg" || imageName == "balochistaKkhaddi.jpg")
            {
                imageLabel.Text = (from culture in App._balochistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "balochistanBolanPass.jpg" || imageName == "balochistanKundMalir.jpg" || imageName == "balochistanZiaratResidency.jpg")
            {
                imageLabel.Text = (from culture in App._balochistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "balochistanMensDress.jpg" || imageName == "balochistanMensDress1.jpg" || imageName == "balochistanWomenDress.jpg")
            {
                imageLabel.Text = (from culture in App._balochistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "punjabBasantLahore.jpg" || imageName == "punjabBasantKiteFlying.jpg" || imageName == "punjabBasant.jpg")
            {
                imageLabel.Text = (from culture in App._punjabStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "punjabCholeBhatura.jpg" || imageName == "punjabLahoriChickenTikka.jpg" || imageName == "punjabSohnHalwa.jpg")
            {
                imageLabel.Text = (from culture in App._punjabStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "punjabFaisalMosqueFaisal.jpg" || imageName == "punjabMinar-e-Pakistan.jpg" || imageName == "punjabShahiMasjid.jpg")
            {
                imageLabel.Text = (from culture in App._punjabStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "punjabiMenDress.jpeg" || imageName == "punjabiWomenDress.jpg" || imageName == "punjabiWomenDress1.jpg")
            {
                imageLabel.Text = (from culture in App._punjabStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "kpkAttanDance.jpg" || imageName == "kpkAttanDance1.jpg" || imageName == "kpkAttanDanceWomens.jpg")
            {
                imageLabel.Text = (from culture in App._kpkStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "kpkNihari.jpg" || imageName == "kpkChapliKabab.jpg" || imageName == "kpkKabuliPuloa.jpg")
            {
                imageLabel.Text = (from culture in App._kpkStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "kpkKhyberPass.jpg" || imageName == "kpkJheelSaifulMulook.jpg" || imageName == "kpkSawatValley.jpg")
            {
                imageLabel.Text = (from culture in App._kpkStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "kpkWomenDress.jpg" || imageName == "kpkWomenDress1.jpg" || imageName == "kpkMensDress.jpg")
            {
                imageLabel.Text = (from culture in App._kpkStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }



            else if (imageName == "gilgitSilkRoadFestival1.jpg" || imageName == "gilgitSilkRoadFestival2.jpg" || imageName == "gilgitSilkRoadFestival3.jpg")
            {
                imageLabel.Text = (from culture in App._gilgitbaltistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "gilgitGyal.jpg" || imageName == "gilgitMamtu.jpg" || imageName == "gilgitApricot.jpg")
            {
                imageLabel.Text = (from culture in App._gilgitbaltistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "gilgitAttabadLake.jpg" || imageName == "gilgitOldSilkRoad.jpg" || imageName == "gilgitK2Mountain.jpg")
            {
                imageLabel.Text = (from culture in App._gilgitbaltistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }

            else if (imageName == "gilgitDress.jpg" || imageName == "gilgitMensDress.jpg" ||                   imageName == "gilgitWomenDress.jpg" )
            { 
                imageLabel.Text = (from culture in App._gilgitbaltistanStorage
                                      where culture.Images == imageName
                                      select culture.largeDescription).FirstOrDefault();
            }
            
           

            btnBack.Visibility = Visibility.Visible;
            grdDisplayLargeImage.Children.Add(imgPakistan);
            Grid.SetRow(imgPakistan, 0);
            imageLabel.VerticalAlignment = VerticalAlignment.Bottom;
            imageLabel.HorizontalAlignment = HorizontalAlignment.Center;
            imageLabel.TextAlignment = TextAlignment.Justify;
            grdDisplayLargeImage.Children.Add(imageLabel);
            Grid.SetRow(imageLabel, 2);
            



        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PanelToDisplayImages.Visibility = Visibility.Visible;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            btnBack.Visibility = Visibility.Collapsed;
        }

       

        private void lbx_options_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            selectedItem = e.AddedItems[0].ToString();
            picture(selectedItem, regionID);
            PanelToDisplayImages.Visibility = Visibility.Visible;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            btnBack.Visibility = Visibility.Collapsed;

        }

        private void Pth_Sindh_MouseUp(object sender, MouseButtonEventArgs e)
        {
            regionID = "1";
            picture("Festivals", regionID);
            province_name.Content = "Province Sindh";
            DisplayRegion.Visibility = Visibility.Visible;
            MapOfPakistan.Visibility = Visibility.Collapsed;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            PanelToDisplayImages.Visibility = Visibility.Visible;
           


        }

        private void Pth_Balochitan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            regionID = "2";
            picture("Festivals", regionID);
            province_name.Content = "Province Balochistan";
            DisplayRegion.Visibility = Visibility.Visible;
            MapOfPakistan.Visibility = Visibility.Collapsed;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            PanelToDisplayImages.Visibility = Visibility.Visible;


        }

        private void Pth_punjab_MouseUp(object sender, MouseButtonEventArgs e)
        {
            regionID = "3";
            picture("Festivals", regionID);
            province_name.Content = "Province Punjab";
            DisplayRegion.Visibility = Visibility.Visible;
            MapOfPakistan.Visibility = Visibility.Collapsed;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            PanelToDisplayImages.Visibility = Visibility.Visible;

        }

        private void Pth_KPK_MouseUp(object sender, MouseButtonEventArgs e)
        {
            regionID = "4";
            picture("Festivals", regionID);
            province_name.Content = "Province KPK";
            DisplayRegion.Visibility = Visibility.Visible;
            MapOfPakistan.Visibility = Visibility.Collapsed;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            PanelToDisplayImages.Visibility = Visibility.Visible;
           
        }

        private void Pth_Gilgitbaltistan_MouseUp(object sender, MouseButtonEventArgs e)
        {
            regionID = "5";
            picture("Festivals", regionID);
            province_name.Content = "Province Gilgit-Baltistan";
            DisplayRegion.Visibility = Visibility.Visible;
            MapOfPakistan.Visibility = Visibility.Collapsed;
            grdDisplayLargeImage.Visibility = Visibility.Collapsed;
            PanelToDisplayImages.Visibility = Visibility.Visible;
            //string selectedItem = e.AddedItems[0].ToString();
            //picture(selectedItem);

        }

        private void btn_Map_Click(object sender, RoutedEventArgs e)
        {
            PanelToDisplayImages.Children.Clear();
            DisplayRegion.Visibility = Visibility.Hidden;
            MapOfPakistan.Visibility = Visibility.Visible;

           
        }


        
    }
}
