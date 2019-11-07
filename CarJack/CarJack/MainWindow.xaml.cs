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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace CarJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //intitialize values
        public string brand;
        public string make;
        public string body;
        public string engine;
        public string color;
        public string firstMakeImg = null;

        public MainWindow()
        {
            InitializeComponent();


        }
        private void TabControlExt_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Toyota(object sender, RoutedEventArgs e)
        {
            brand = "Toyota";
            firstMake.Content = "\n\nCorolla";
            firstMake.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
            HatchBack.Visibility = System.Windows.Visibility.Visible;
        }
        private void Button_Dodge(object sender, RoutedEventArgs e)
        {
            brand = "Dodge";
            firstMake.Content = "\n\nCharger";

            //Changes brush image for make first button background

            firstMake.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\DodgeChargerWhite.png")));
            HatchBack.Visibility = System.Windows.Visibility.Hidden;

        }
        private void Button_firstMake(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota")
            {
                make = "Corolla";
                Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));

            }
            if (brand == "Dodge")
            {
                make = "Charger";
                Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\DodgeChargerWhite.png")));

            }
        }

        private void Button_Sedan(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota" && make == "Corolla")
            {
                carView.Source = new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png"));
            }
            else
            if (brand == "Dodge" && make == "Charger")
            {
                carView.Source = new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\DodgeChargerWhite.png"));
            }
        }

        private void Button_HatchBack(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota" && make == "Corolla")
            {
                carView.Source = new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png"));
            }
        }



    }
}