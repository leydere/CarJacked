using System;
using System.Collections.Generic;
using System.IO;
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
        public int year = 2019;
        public int creditScores = 750;
        public int carPrice = -1;
        public int carMileage = -1;

        

        public MainWindow()
        {
            InitializeComponent();


        }


        void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                choiceTitle.Content = "Choose A " + this.Content;
            }
        }

        /*
       private void TabControlExt_SelectionChanged(object sender, RoutedEventArgs e)
       {

            if (ActivityCalc_Tab.IsSelected == true)
           {
               Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\Dash.jpg")));
            }
            else
            {
                Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ParkingGarage.jpg")));

            }
            
        }
        */
        readonly string imagePath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\images\\";
        private void Button_Toyota(object sender, RoutedEventArgs e)
        {
            brand = "Toyota";
            firstMake.Content = "\n\nCorolla";
            //firstMake.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
            firstMake.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
            HatchBack.Visibility = System.Windows.Visibility.Visible;
        }
        private void Button_Dodge(object sender, RoutedEventArgs e)
        {
            brand = "Dodge";
            firstMake.Content = "\n\nCharger";

            //Changes brush image for make first button background

            firstMake.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "DodgeChargerWhite.png")));
            HatchBack.Visibility = System.Windows.Visibility.Hidden;

        }
        private void Button_firstMake(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota")
            {
                switch (year)
                {
                    case 2005:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 4776;
                        carMileage = 146181;
                        break;
                    case 2006:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 5676;
                        carMileage = 141664;
                        break;
                    case 2007:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 5826;
                        carMileage = 136393;
                        break;
                    case 2008:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 6311;
                        carMileage = 130381;
                        break;
                    case 2009:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 6712;
                        carMileage = 123490;
                        break;
                    case 2010:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 7612;
                        carMileage = 116004;
                        break;
                    case 2011:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 8465;
                        carMileage = 107756;
                        break;
                    case 2012:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 8761;
                        carMileage = 98767;
                        break;
                    case 2013:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 9171;
                        carMileage = 89036;
                        break;
                    case 2014:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 10711;
                        carMileage = 78385;
                        break;
                    case 2015:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 10849;
                        carMileage = 67160;
                        break;
                    case 2016:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 12867;
                        carMileage = 55193;
                        break;
                    case 2017:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 13664;
                        carMileage = 42485;
                        break;
                    case 2018:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 15785;
                        carMileage = 29075;
                        break;
                    case 2019:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));
                        carPrice = 17305;
                        carMileage = 14886;
                        break;
                    default:
                        break;
                }
                make = "Corolla";
                Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png")));
                HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png")));

            }
            if (brand == "Dodge")
            {
                make = "Charger";
                Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@imagePath + "DodgeChargerWhite.png")));

            }
        }

        private void Button_Sedan(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota" && make == "Corolla")
            {
                carView.Source = new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhite.png"));
            }
            else
            if (brand == "Dodge" && make == "Charger")
            {
                carView.Source = new BitmapImage(new Uri(@imagePath + "DodgeChargerWhite.png"));
            }
        }

        private void Button_HatchBack(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota" && make == "Corolla")
            {
                carView.Source = new BitmapImage(new Uri(@imagePath + "ToyotaCorollaWhiteHatch.png"));
            }
        }


        #region Calc and Save button and all of its supporting functions
        /// <summary>
        /// Clicking the calc & save button does all the appropriate multiplication and addition.
        /// The resulting values are saved into a .txt document in the application file structure.
        /// "\activity_profiles\0.txt" (will need updated once there are multiple user activity profiles)
        /// There have since been numerous checks that have been added as well.
        /// Tried to separate different features into regions within the click function.
        /// </summary>
        private void Calc_Save_Click(object sender, RoutedEventArgs e)
        {
            #region Repaint All Text Black
            TripMiles1.Foreground = Brushes.Black;
            TripMiles2.Foreground = Brushes.Black;
            TripMiles3.Foreground = Brushes.Black;
            TripMiles4.Foreground = Brushes.Black;
            TripMiles5.Foreground = Brushes.Black;
            TripMiles6.Foreground = Brushes.Black;
            TripMiles7.Foreground = Brushes.Black;
            TripMiles8.Foreground = Brushes.Black;
            TripMiles9.Foreground = Brushes.Black;
            TripsPerWeek1.Foreground = Brushes.Black;
            TripsPerWeek2.Foreground = Brushes.Black;
            TripsPerWeek3.Foreground = Brushes.Black;
            TripsPerWeek4.Foreground = Brushes.Black;
            TripsPerWeek5.Foreground = Brushes.Black;
            TripsPerWeek6.Foreground = Brushes.Black;
            TripsPerWeek7.Foreground = Brushes.Black;
            TripsPerWeek8.Foreground = Brushes.Black;
            TripsPerWeek9.Foreground = Brushes.Black;
            WeeksPerYear1.Foreground = Brushes.Black;
            WeeksPerYear2.Foreground = Brushes.Black;
            WeeksPerYear3.Foreground = Brushes.Black;
            WeeksPerYear4.Foreground = Brushes.Black;
            WeeksPerYear5.Foreground = Brushes.Black;
            WeeksPerYear6.Foreground = Brushes.Black;
            WeeksPerYear7.Foreground = Brushes.Black;
            WeeksPerYear8.Foreground = Brushes.Black;
            WeeksPerYear9.Foreground = Brushes.Black;
            #endregion

            #region Check For and Remove Semicolons
            bool foundSemiColonCheck = false;
            if (CheckForSemiColons(TripDescript1.Text)) { TripDescript1.Text = TrimSemiColons(TripDescript1.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript2.Text)) { TripDescript2.Text = TrimSemiColons(TripDescript2.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript3.Text)) { TripDescript3.Text = TrimSemiColons(TripDescript3.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript4.Text)) { TripDescript4.Text = TrimSemiColons(TripDescript4.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript5.Text)) { TripDescript5.Text = TrimSemiColons(TripDescript5.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript6.Text)) { TripDescript6.Text = TrimSemiColons(TripDescript6.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript7.Text)) { TripDescript7.Text = TrimSemiColons(TripDescript7.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript8.Text)) { TripDescript8.Text = TrimSemiColons(TripDescript8.Text); foundSemiColonCheck = true; }
            if (CheckForSemiColons(TripDescript9.Text)) { TripDescript9.Text = TrimSemiColons(TripDescript9.Text); foundSemiColonCheck = true; }
            if (foundSemiColonCheck) { MessageBox.Show("One or more semicolons were detected and removed.", "Semicolon Detected"); }
            #endregion

            #region Check For Blank Boxes
            bool foundBlankBoxes = false;
            if (CheckForBlankBoxes(TripMiles1.Text)) { foundBlankBoxes = true; TripMiles1.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles2.Text)) { foundBlankBoxes = true; TripMiles2.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles3.Text)) { foundBlankBoxes = true; TripMiles3.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles4.Text)) { foundBlankBoxes = true; TripMiles4.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles5.Text)) { foundBlankBoxes = true; TripMiles5.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles6.Text)) { foundBlankBoxes = true; TripMiles6.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles7.Text)) { foundBlankBoxes = true; TripMiles7.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles8.Text)) { foundBlankBoxes = true; TripMiles8.Text = "0"; }
            if (CheckForBlankBoxes(TripMiles9.Text)) { foundBlankBoxes = true; TripMiles9.Text = "0"; }

            if (CheckForBlankBoxes(TripsPerWeek1.Text)) { foundBlankBoxes = true; TripsPerWeek1.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek2.Text)) { foundBlankBoxes = true; TripsPerWeek2.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek3.Text)) { foundBlankBoxes = true; TripsPerWeek3.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek4.Text)) { foundBlankBoxes = true; TripsPerWeek4.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek5.Text)) { foundBlankBoxes = true; TripsPerWeek5.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek6.Text)) { foundBlankBoxes = true; TripsPerWeek6.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek7.Text)) { foundBlankBoxes = true; TripsPerWeek7.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek8.Text)) { foundBlankBoxes = true; TripsPerWeek8.Text = "0"; }
            if (CheckForBlankBoxes(TripsPerWeek9.Text)) { foundBlankBoxes = true; TripsPerWeek9.Text = "0"; }

            if (CheckForBlankBoxes(WeeksPerYear1.Text)) { foundBlankBoxes = true; WeeksPerYear1.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear2.Text)) { foundBlankBoxes = true; WeeksPerYear2.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear3.Text)) { foundBlankBoxes = true; WeeksPerYear3.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear4.Text)) { foundBlankBoxes = true; WeeksPerYear4.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear5.Text)) { foundBlankBoxes = true; WeeksPerYear5.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear6.Text)) { foundBlankBoxes = true; WeeksPerYear6.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear7.Text)) { foundBlankBoxes = true; WeeksPerYear7.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear8.Text)) { foundBlankBoxes = true; WeeksPerYear8.Text = "0"; }
            if (CheckForBlankBoxes(WeeksPerYear9.Text)) { foundBlankBoxes = true; WeeksPerYear9.Text = "0"; }
            if (foundBlankBoxes) { MessageBox.Show("One or more empty boxes was detected in the numberic columns. A value of '0' was entered into the field(s).", "Empty Box Detected"); }
            #endregion

            #region Whole Number Check
            bool foundNonWholeTripMiles = false;
            if (CheckForWholeNumbers(TripMiles1.Text)) { foundNonWholeTripMiles = true; TripMiles1.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles2.Text)) { foundNonWholeTripMiles = true; TripMiles2.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles3.Text)) { foundNonWholeTripMiles = true; TripMiles3.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles4.Text)) { foundNonWholeTripMiles = true; TripMiles4.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles5.Text)) { foundNonWholeTripMiles = true; TripMiles5.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles6.Text)) { foundNonWholeTripMiles = true; TripMiles6.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles7.Text)) { foundNonWholeTripMiles = true; TripMiles7.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles8.Text)) { foundNonWholeTripMiles = true; TripMiles8.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripMiles9.Text)) { foundNonWholeTripMiles = true; TripMiles9.Foreground = Brushes.Red; }
            if (foundNonWholeTripMiles) { MessageBox.Show("One or more non whole numbers was detected in the 'Trip Miles' column.  Whole positive numbers are the expected input for these fields.  Please correct.", "Non-Whole Number Value Detected"); }
            bool foundNonWholeTripsPerWeek = false;
            if (CheckForWholeNumbers(TripsPerWeek1.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek1.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek2.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek2.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek3.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek3.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek4.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek4.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek5.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek5.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek6.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek6.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek7.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek7.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek8.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek8.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(TripsPerWeek9.Text)) { foundNonWholeTripsPerWeek = true; TripsPerWeek9.Foreground = Brushes.Red; }
            if (foundNonWholeTripsPerWeek) { MessageBox.Show("One or more non whole numbers was detected in the 'Trips per Week' column.  Whole positive numbers are the expected input for these fields.  Please correct.", "Non-Whole Number Value Detected"); }
            bool foundNonWholeWeeksPerYear = false;
            if (CheckForWholeNumbers(WeeksPerYear1.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear1.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear2.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear2.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear3.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear3.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear4.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear4.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear5.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear5.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear6.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear6.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear7.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear7.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear8.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear8.Foreground = Brushes.Red; }
            if (CheckForWholeNumbers(WeeksPerYear9.Text)) { foundNonWholeWeeksPerYear = true; WeeksPerYear9.Foreground = Brushes.Red; }
            if (foundNonWholeWeeksPerYear) { MessageBox.Show("One or more non whole numbers was detected in the 'Weeks per Year' column.  Whole positive numbers are the expected input for these fields.  Please correct.", "Non-Whole Number Value Detected"); }
            #endregion

            #region Negative Value Check
            bool foundNegativeTripMiles = false;
            if (!foundNonWholeTripMiles)
            {
                if (CheckForNegativeValues(TripMiles1.Text)) { foundNegativeTripMiles = true; TripMiles1.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles2.Text)) { foundNegativeTripMiles = true; TripMiles2.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles3.Text)) { foundNegativeTripMiles = true; TripMiles3.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles4.Text)) { foundNegativeTripMiles = true; TripMiles4.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles5.Text)) { foundNegativeTripMiles = true; TripMiles5.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles6.Text)) { foundNegativeTripMiles = true; TripMiles6.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles7.Text)) { foundNegativeTripMiles = true; TripMiles7.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles8.Text)) { foundNegativeTripMiles = true; TripMiles8.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripMiles9.Text)) { foundNegativeTripMiles = true; TripMiles9.Foreground = Brushes.Red; }
            }
            if (foundNegativeTripMiles) { MessageBox.Show("One or more negative numbers was detected in the 'Trip Miles' column.  Whole positive numbers are the expected input for these fields.  Please correct.", "Negative Value Detected"); }
            bool foundNegativeTripsPerWeek = false;
            if (!foundNonWholeTripsPerWeek)
            {
                if (CheckForNegativeValues(TripsPerWeek1.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek1.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek2.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek2.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek3.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek3.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek4.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek4.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek5.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek5.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek6.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek6.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek7.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek7.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek8.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek8.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(TripsPerWeek9.Text)) { foundNegativeTripsPerWeek = true; TripsPerWeek9.Foreground = Brushes.Red; }
            }
            if (foundNegativeTripsPerWeek) { MessageBox.Show("One or more negative numbers was detected in the 'Trips per Week' column.  Whole positive numbers are the expected input for these fields.  Please correct.", "Negative Value Detected"); }
            bool foundNegativeWeeksPerYear = false;
            if (!foundNonWholeWeeksPerYear)
            {
                if (CheckForNegativeValues(WeeksPerYear1.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear1.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear2.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear2.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear3.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear3.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear4.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear4.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear5.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear5.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear6.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear6.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear7.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear7.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear8.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear8.Foreground = Brushes.Red; }
                if (CheckForNegativeValues(WeeksPerYear9.Text)) { foundNegativeWeeksPerYear = true; WeeksPerYear9.Foreground = Brushes.Red; }
            }
            if (foundNegativeWeeksPerYear) { MessageBox.Show("One or more negative numbers was detected in the 'Weeks per Year' column.  Whole positive numbers are the expected input for these fields.  Please correct.", "Negative Value Detected"); }
            #endregion

            #region Check Trip Miles Column For Large Numbers
            bool greaterThan100 = false;
            bool greaterThan1000 = false;
            if (!foundNonWholeTripMiles)
            {
                if (CheckForUnreasonablyLargeValue(TripMiles1.Text)) { greaterThan1000 = true; TripMiles1.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles1.Text)) { greaterThan100 = true; TripMiles1.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles2.Text)) { greaterThan1000 = true; TripMiles2.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles2.Text)) { greaterThan100 = true; TripMiles2.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles3.Text)) { greaterThan1000 = true; TripMiles3.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles3.Text)) { greaterThan100 = true; TripMiles3.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles4.Text)) { greaterThan1000 = true; TripMiles4.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles4.Text)) { greaterThan100 = true; TripMiles4.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles5.Text)) { greaterThan1000 = true; TripMiles5.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles5.Text)) { greaterThan100 = true; TripMiles5.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles6.Text)) { greaterThan1000 = true; TripMiles6.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles6.Text)) { greaterThan100 = true; TripMiles6.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles7.Text)) { greaterThan1000 = true; TripMiles7.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles7.Text)) { greaterThan100 = true; TripMiles7.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles8.Text)) { greaterThan1000 = true; TripMiles8.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles8.Text)) { greaterThan100 = true; TripMiles8.Foreground = Brushes.LightBlue; }
                if (CheckForUnreasonablyLargeValue(TripMiles9.Text)) { greaterThan1000 = true; TripMiles9.Foreground = Brushes.LightBlue; } else if (CheckForLargeValue(TripMiles9.Text)) { greaterThan100 = true; TripMiles9.Foreground = Brushes.LightBlue; }

            }
            if (greaterThan100) { MessageBox.Show("A value >= 100 was detected in the 'Trip Miles' column.  Results were saved, but if this was not intended please correct.", "Large Value Detected"); }
            if (greaterThan1000) { MessageBox.Show("A value >= 1000 was detected in the 'Trip Miles' column.  Results were saved, but if this was not intended please correct.", "Large Value Detected"); }
            #endregion

            #region Check Weeks per Year Column For 0 - 52
            bool unreasonableYears = false;
            if (!foundNonWholeWeeksPerYear)
            {
                if (CheckForZeroThrough52(WeeksPerYear1.Text)) { unreasonableYears = true; WeeksPerYear1.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear2.Text)) { unreasonableYears = true; WeeksPerYear2.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear3.Text)) { unreasonableYears = true; WeeksPerYear3.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear4.Text)) { unreasonableYears = true; WeeksPerYear4.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear5.Text)) { unreasonableYears = true; WeeksPerYear5.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear6.Text)) { unreasonableYears = true; WeeksPerYear6.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear7.Text)) { unreasonableYears = true; WeeksPerYear7.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear8.Text)) { unreasonableYears = true; WeeksPerYear8.Foreground = Brushes.Red; }
                if (CheckForZeroThrough52(WeeksPerYear9.Text)) { unreasonableYears = true; WeeksPerYear9.Foreground = Brushes.Red; }
            }
            if (unreasonableYears) { MessageBox.Show("A value outside the range of 0 - 52 was detected in the 'Weeks per Year' column.  Value between 0 and 52 expected.  Please correct.", "Illogical Year Value Detected"); }
            #endregion

            #region Math Stuff
            // following nine lines maths the user inputs -ERL
            subtotal1.Text = MultiplyActivityBoxes(TripMiles1.Text, TripsPerWeek1.Text, WeeksPerYear1.Text).ToString();
            subtotal2.Text = MultiplyActivityBoxes(TripMiles2.Text, TripsPerWeek2.Text, WeeksPerYear2.Text).ToString();
            subtotal3.Text = MultiplyActivityBoxes(TripMiles3.Text, TripsPerWeek3.Text, WeeksPerYear3.Text).ToString();
            subtotal4.Text = MultiplyActivityBoxes(TripMiles4.Text, TripsPerWeek4.Text, WeeksPerYear4.Text).ToString();
            subtotal5.Text = MultiplyActivityBoxes(TripMiles5.Text, TripsPerWeek5.Text, WeeksPerYear5.Text).ToString();
            subtotal6.Text = MultiplyActivityBoxes(TripMiles6.Text, TripsPerWeek6.Text, WeeksPerYear6.Text).ToString();
            subtotal7.Text = MultiplyActivityBoxes(TripMiles7.Text, TripsPerWeek7.Text, WeeksPerYear7.Text).ToString();
            subtotal8.Text = MultiplyActivityBoxes(TripMiles8.Text, TripsPerWeek8.Text, WeeksPerYear8.Text).ToString();
            subtotal9.Text = MultiplyActivityBoxes(TripMiles9.Text, TripsPerWeek9.Text, WeeksPerYear9.Text).ToString();
            // following line adds the nine subtotals together -ERL
            TotalBlock.Text = (Int32.Parse(subtotal1.Text) + Int32.Parse(subtotal2.Text) + Int32.Parse(subtotal3.Text) + Int32.Parse(subtotal4.Text) + Int32.Parse(subtotal5.Text) + Int32.Parse(subtotal6.Text) + Int32.Parse(subtotal7.Text) + Int32.Parse(subtotal8.Text) + Int32.Parse(subtotal9.Text)).ToString();
            #endregion

            #region Save to Text File
            // only saves if the various issues above are not detected -ERL
            if (!foundNonWholeTripMiles && !foundNonWholeTripsPerWeek && !foundNonWholeWeeksPerYear && !foundNegativeTripMiles && !foundNegativeTripsPerWeek && !foundNegativeWeeksPerYear && !unreasonableYears)
            {
                // path the to txt file where data is saved; will need altering once there are more that one user activity profiles -ERL
                string txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\activity_profiles\\0.txt";

                string activityData = "";
                string insTab = ";\t";
                string insRet = ";\r";

                // adds description. miles, trips, weeks, and subtotals to a string
                // all separated by semi-colons and tabs
                // each row in the window is a line in the string, ending with semicolon and carriage return
                // final line is the total miles value -ERL
                activityData = activityData + TripDescript1.Text + insTab + TripMiles1.Text + insTab + TripsPerWeek1.Text + insTab + WeeksPerYear1.Text + insTab + subtotal1.Text + insRet;
                activityData = activityData + TripDescript2.Text + insTab + TripMiles2.Text + insTab + TripsPerWeek2.Text + insTab + WeeksPerYear2.Text + insTab + subtotal2.Text + insRet;
                activityData = activityData + TripDescript3.Text + insTab + TripMiles3.Text + insTab + TripsPerWeek3.Text + insTab + WeeksPerYear3.Text + insTab + subtotal3.Text + insRet;
                activityData = activityData + TripDescript4.Text + insTab + TripMiles4.Text + insTab + TripsPerWeek4.Text + insTab + WeeksPerYear4.Text + insTab + subtotal4.Text + insRet;
                activityData = activityData + TripDescript5.Text + insTab + TripMiles5.Text + insTab + TripsPerWeek5.Text + insTab + WeeksPerYear5.Text + insTab + subtotal5.Text + insRet;
                activityData = activityData + TripDescript6.Text + insTab + TripMiles6.Text + insTab + TripsPerWeek6.Text + insTab + WeeksPerYear6.Text + insTab + subtotal6.Text + insRet;
                activityData = activityData + TripDescript7.Text + insTab + TripMiles7.Text + insTab + TripsPerWeek7.Text + insTab + WeeksPerYear7.Text + insTab + subtotal7.Text + insRet;
                activityData = activityData + TripDescript8.Text + insTab + TripMiles8.Text + insTab + TripsPerWeek8.Text + insTab + WeeksPerYear8.Text + insTab + subtotal8.Text + insRet;
                activityData = activityData + TripDescript9.Text + insTab + TripMiles9.Text + insTab + TripsPerWeek9.Text + insTab + WeeksPerYear9.Text + insTab + subtotal9.Text + insRet;
                activityData = activityData + TotalBlock.Text + insRet;

                System.IO.File.WriteAllText(txtPath, activityData);
            }
            else { MessageBox.Show("Due to one or more detected issues the calculated activity was not saved.", "Not Saved"); }
            #endregion

        }

        private static bool CheckForBlankBoxes(string inputText)
        {
            if (inputText == "") return true;
            return false;
        }

        /// <summary>
        /// Checks for values outside the range of 0 - 52.  Does this as the input is expected to represent a number of weeks in one year.
        /// </summary>
        /// <param name="inputText">Input to be checked.  From weeks per year column.</param>
        /// <returns>Returns true if found, false if not.</returns>
        private static bool CheckForZeroThrough52(string inputText)
        {
            if (Int32.Parse(inputText) < 0 || Int32.Parse(inputText) > 52) return true;
            return false;
        }
        /// <summary>
        /// Checks for values greater than or equal to 1000.  Does this as large trips of this length are out of the ordinary.
        /// </summary>
        /// <param name="inputText">Input to be checked.  From the trip miles column.</param>
        /// <returns>Returns true if found, false if not.</returns>
        private static bool CheckForUnreasonablyLargeValue(string inputText)
        {
            if (Int32.Parse(inputText) >= 1000) return true;
            return false;
        }
        /// <summary>
        /// Checks for values greater than or equal to 100.  Does this as large trips of this length are out of the ordinary.
        /// </summary>
        /// <param name="inputText">Input to be checked.  From the trip miles column.</param>
        /// <returns>Returns true if found, false if not.</returns>
        private static bool CheckForLargeValue(string inputText)
        {
            if (Int32.Parse(inputText) >= 100) return true;
            return false;
        }
        /// <summary>
        /// Checks if an input is a negative number.  Checks for since a negative number would be an illogical input.
        /// </summary>
        /// <param name="inputText">Input to be checked for negative. From one of the three numeric columns on the activity calculator tab.</param>
        /// <returns>Returns true if negative value found.  Returns false otherwise.</returns>
        private static bool CheckForNegativeValues(string inputText)
        {
            if (Int32.Parse(inputText) < 0) return true;
            return false;
        }
        /// <summary>
        /// Checks if a string can be parsed as a whole number.  Used to ensure input is of the correct type for further use.
        /// </summary>
        /// <param name="inputText">String that will parse attempt will be made on. From one of the three numeric columns on the activity calculator tab.</param>
        /// <returns>Returns true a string cannot be parsed to int.  Returns false otherwise.</returns>
        private static bool CheckForWholeNumbers(string inputText)
        {
            try { Int32.Parse(inputText); }
            catch { return true; }
            return false;
        }

        /// <summary>
        /// Checks strings for semicolons.  If found trims out and notifies user with a popup window.  Used to ensure user does 
        /// not break txt file reader that separates data with semi colons. -ERL
        /// </summary>
        /// <param name="inputText">String that is to be checked for semicolons.</param>
        /// <returns>Original input string, with semicolons removed if found.</returns>
        private static string TrimSemiColons(string inputText)
        {
            inputText = inputText.Replace(";", "");
            return inputText;
        }

        /// <summary>
        /// Checks string for semicolons.  Return boolean value used to determine if popup window and trim function should be called.
        /// </summary>
        /// <param name="inputText">String to check for semicolons.</param>
        /// <returns>True if found. False if not found.</returns>
        private static bool CheckForSemiColons(string inputText)
        {
            if (inputText.Contains(';')) { return true; }
            return false;
        }

        /// <summary>
        /// Multiplies the user string inputs and returns result as an int.  Used in calculation of annual years driven.
        /// Checks for empty string and ignores rows with them.
        /// Tries to convert to int.  If fails should return zero.
        /// </summary>
        /// <param name="miles">User supplied miles per trip value.</param>
        /// <param name="trips">User supplied trips per week value.</param>
        /// <param name="weeks">User supplied weeks per year value.</param>
        /// <returns>Value returned signifies miles driven for that particular trip in a given year.</returns>
        private static int MultiplyActivityBoxes(string miles, string trips, string weeks)
        {
            int numMiles = 0;
            int numTrips = 0;
            int numWeeks = 0;

            if (miles != "" && trips != "" && weeks != "")
            {
                try
                {
                    numMiles = Int32.Parse(miles);
                    numTrips = Int32.Parse(trips);
                    numWeeks = Int32.Parse(weeks);
                }
                catch { }
            }

            int total = numMiles * numTrips * numWeeks;
            return total;
        }
        #endregion

        /// <summary>
        /// When the activity calculator tab is intialized the info from the txt file is loaded into the fields.
        /// (Potential to leave as is once multiple activity profiles are implemented, may need to change.)
        /// (At the very least can reuse this when selecting an alternate activity profile.)
        /// </summary>
        private void ActivityCalc_Tab_Initialized(object sender, EventArgs e)
        {
            // find txt file and load contents into a string -ERL
            string txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\activity_profiles\\0.txt";
            string readFromTextFile = System.IO.File.ReadAllText(txtPath);

            // trims out the tabs, new lines and carriage returns, then splits by semicolons into an array -ERL
            readFromTextFile = readFromTextFile.Replace("\t", "");
            readFromTextFile = readFromTextFile.Replace("\n", "");
            readFromTextFile = readFromTextFile.Replace("\r", "");
            string[] splitActivityInfo = readFromTextFile.Split(';');

            // assigns the contents of the array to the appropriate fields in the activity calculator screen -ERL
            #region Too much repeated text assignments
            TripDescript1.Text = splitActivityInfo[0];
            TripMiles1.Text = splitActivityInfo[1];
            TripsPerWeek1.Text = splitActivityInfo[2];
            WeeksPerYear1.Text = splitActivityInfo[3];
            subtotal1.Text = splitActivityInfo[4];
            TripDescript2.Text = splitActivityInfo[5];
            TripMiles2.Text = splitActivityInfo[6];
            TripsPerWeek2.Text = splitActivityInfo[7];
            WeeksPerYear2.Text = splitActivityInfo[8];
            subtotal2.Text = splitActivityInfo[9];
            TripDescript3.Text = splitActivityInfo[10];
            TripMiles3.Text = splitActivityInfo[11];
            TripsPerWeek3.Text = splitActivityInfo[12];
            WeeksPerYear3.Text = splitActivityInfo[13];
            subtotal3.Text = splitActivityInfo[14];
            TripDescript4.Text = splitActivityInfo[15];
            TripMiles4.Text = splitActivityInfo[16];
            TripsPerWeek4.Text = splitActivityInfo[17];
            WeeksPerYear4.Text = splitActivityInfo[18];
            subtotal4.Text = splitActivityInfo[19];
            TripDescript5.Text = splitActivityInfo[20];
            TripMiles5.Text = splitActivityInfo[21];
            TripsPerWeek5.Text = splitActivityInfo[22];
            WeeksPerYear5.Text = splitActivityInfo[23];
            subtotal5.Text = splitActivityInfo[24];
            TripDescript6.Text = splitActivityInfo[25];
            TripMiles6.Text = splitActivityInfo[26];
            TripsPerWeek6.Text = splitActivityInfo[27];
            WeeksPerYear6.Text = splitActivityInfo[28];
            subtotal6.Text = splitActivityInfo[29];
            TripDescript7.Text = splitActivityInfo[30];
            TripMiles7.Text = splitActivityInfo[31];
            TripsPerWeek7.Text = splitActivityInfo[32];
            WeeksPerYear7.Text = splitActivityInfo[33];
            subtotal7.Text = splitActivityInfo[34];
            TripDescript8.Text = splitActivityInfo[35];
            TripMiles8.Text = splitActivityInfo[36];
            TripsPerWeek8.Text = splitActivityInfo[37];
            WeeksPerYear8.Text = splitActivityInfo[38];
            subtotal8.Text = splitActivityInfo[39];
            TripDescript9.Text = splitActivityInfo[40];
            TripMiles9.Text = splitActivityInfo[41];
            TripsPerWeek9.Text = splitActivityInfo[42];
            WeeksPerYear9.Text = splitActivityInfo[43];
            subtotal9.Text = splitActivityInfo[44];
            TotalBlock.Text = splitActivityInfo[45];
            #endregion

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        #region Year Buttons Click Properties

        
        private void Y2005_Click(object sender, RoutedEventArgs e)
        {
            year = 2005;
        }
        private void Y2006_Click(object sender, RoutedEventArgs e)
        {
            year = 2006;
        }
        private void Y2007_Click(object sender, RoutedEventArgs e)
        {
            year = 2007;
        }
        private void Y2008_Click(object sender, RoutedEventArgs e)
        {
            year = 2008;
        }
        private void Y2009_Click(object sender, RoutedEventArgs e)
        {
            year = 2009;
        }
        private void Y2010_Click(object sender, RoutedEventArgs e)
        {
            year = 2010;
        }
        private void Y2011_Click(object sender, RoutedEventArgs e)
        {
            year = 2011;
        }
        private void Y2012_Click(object sender, RoutedEventArgs e)
        {
            year = 2012;
        }
        private void Y2013_Click(object sender, RoutedEventArgs e)
        {
            year = 2013;
        }
        private void Y2014_Click(object sender, RoutedEventArgs e)
        {
            year = 2014;
        }
        private void Y2015_Click(object sender, RoutedEventArgs e)
        {
            year = 2015;
        }
        private void Y2016_Click(object sender, RoutedEventArgs e)
        {
            year = 2016;
        }
        private void Y2017_Click(object sender, RoutedEventArgs e)
        {
            year = 2017;
        }
        private void Y2018_Click(object sender, RoutedEventArgs e)
        {
            year = 2018;
        }
        private void Y2019_Click(object sender, RoutedEventArgs e)
        {
            year = 2019;
        }
        #endregion
        private void InterestCalc_Click(object sender, RoutedEventArgs e)
        {
            if (carSelectionGrid.Visibility == Visibility.Visible)
            {
                carSelectionGrid.Visibility = Visibility.Hidden;
                interestGrid.Visibility = Visibility.Visible;
            }
            else
            {
                carSelectionGrid.Visibility = Visibility.Visible;
                interestGrid.Visibility = Visibility.Hidden;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IntCalc_Click(object sender, RoutedEventArgs e)
        {
            string input = creditScore.Text;
            if (!(creditScore.Text == null))
            {
                creditScores = Convert.ToInt32(input);
            }
            else
            {
                MessageBox.Show("Please Insert a numerical value into the credit score box");
            }
            if (!(carAmount.Text == null))
            {
                creditScores = Convert.ToInt32(input);
            }
            else
            {
                MessageBox.Show("Please Insert a numerical value into the credit score box");
            }
        }

        private void LongevityButton_Click(object sender, RoutedEventArgs e)
        {
            if (carPrice != -1 && carMileage != -1 && TotalBlock.Text != "")
            {
                try
                {
                    float remainingMiles = 250000 - Convert.ToSingle(carMileage);
                    float yearsLongevity = remainingMiles / Convert.ToSingle(TotalBlock.Text);
                    float annualCostValue = Convert.ToSingle(carPrice) / yearsLongevity;
                    string printLongevity = Math.Round(yearsLongevity, 1).ToString();
                    string printCostValue = Math.Round(annualCostValue, 2).ToString();
                    MessageBox.Show("With an assumed maximum mileage of 250,000:\r\rThis vehicle will last " + printLongevity + " years.\r\rThe annual cost:value is $" + printCostValue + ".", "Longevity/Cost Projections");
                }
                catch { MessageBox.Show("One or more issues prevented the expected calculation from taking place.  Actual issue not identified.", "Action Failed"); }
            }
            else MessageBox.Show("The calculation cannot complete without a vehicle selected and the activity calculator filled in and saved.  Please correct and try again.", "Unable to Calculate");
        }
    }
}