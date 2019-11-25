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
        public string prevMake;
        public string body;
        public string prevBody;
        public string engine;
        public string color = "white";
        public string firstMakeImg = null;
        public int year = 2019;
        public int mileage;
        public int milesPerGallon;
        public int activityMileage;
        public string vPicture;

        public Vehicle savVehicle1 = new Vehicle();
        public Vehicle savVehicle2 = new Vehicle();
        public Vehicle savVehicle3 = new Vehicle();

        public string v1txtPath;
        public string v2txtPath;
        public string v3txtPath;
        public List<string> vehicleData_1 = new List<string>();
        public List<string> vehicleData_2 = new List<string>();
        public List<string> vehicleData_3 = new List<string>();


        //interest and payment values
        public int creditScores = 750;
        public double interestRateN = 7.5;
        public int carPrice = -1;
        public double payments;
        public int carMileage = -1;

        public MainWindow()
        {
            InitializeComponent();
            LoadVehicles();

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
            UpdateCarDetails();
        }
        private void Button_firstMake(object sender, RoutedEventArgs e)
        {
            if (brand == "Toyota")
            {
                make = "Corolla";
                prevMake = brand;
                Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                UpdateCarDetails();
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
                switch (year)
                {
                    case 2005:
                        make = "Corolla";
                        body = "Sedan";
                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 4813;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2006:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 5000;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2007:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 6000;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2008:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 6500;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2009:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 8000;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2010:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 8500;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2011:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 9000;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2012:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 10700;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2013:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 11500;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2014:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 12500;   //needsActualPrice
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 32448;
                        milesPerGallon = 30;
                        break;
                    case 2015:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 13025;   //needsActualPrice
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2016:
                        make = "Corolla";
                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 14130;
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2017:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 14843;   //needsActualPrice
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2018:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 15525;   //needsActualPrice
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    case 2019:
                        make = "Corolla";
                        body = "Sedan";

                        carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhite.png"));
                        vPicture = "\\images\\ToyotaCorollaWhite.png";
                        carPrice = 19000;   //needsActualPrice
                        carAmount.Text = Convert.ToString(carPrice);
                        mileage = 100;
                        milesPerGallon = 30;
                        break;
                    default:
                        break;
                }

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

                Engine.IsEnabled = false;
                Color.IsEnabled = false;
                carView.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\images\ToyotaCorollaWhiteHatch.png"));
                vPicture = "\\images\\ToyotaCorollaWhiteHatch.png";
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

        private void Y2005_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2005;

        }

        private void InterestCalc_Click(object sender, RoutedEventArgs e)
        {
            if (carSelectionGrid.Visibility == Visibility.Visible)
            {
                carSelectionGrid.Visibility = Visibility.Hidden;
                interestGrid.Visibility = Visibility.Visible;
                carAmount.Text = Convert.ToString(carPrice);
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

            string creditRating = "good";

            //applies textbox info to creditScore integer to be used with the payment calculation 
            if (creditScore.Text != "")
            {
                string input = creditScore.Text;
                creditScores = Convert.ToInt32(input);

                creditRating = CreditValue(creditScores);
            }
            else
            {
                MessageBox.Show("Please Insert a numerical value into the credit score box");
            }
            //applies textbox info to carPrice integer to be used with the payment calculation
            if (!(carAmount.Text == null))
            {
                string input = carAmount.Text;
                carPrice = Convert.ToInt32(input);
            }
            else
            {
                MessageBox.Show("Please Insert a numerical value into the credit score box");
            }
            //applies textbox info to interestRate float to be used with the payment calculation
            if (!(interestRate.Text == null))
            {
                string input = interestRate.Text;

                interestRateN = Convert.ToDouble(input);
                CalculateInterest(creditRating, carPrice, interestRateN);
            }
            else
            {
                MessageBox.Show("Please Insert a numerical value into the credit score box");
            }


        }

        string CreditValue(int x)
        {
            string creditRating = "good";

            if (creditScores >= 720)
            {
                creditRating = "great";
            }
            else if ((creditScores >= 690) && (creditScores <= 719))
            {
                creditRating = "good";
            }
            else if ((creditScores >= 660) && (creditScores <= 689))
            {
                creditRating = "fair";
            }
            else if ((creditScores >= 620) && (creditScores <= 659))
            {
                creditRating = "okay";
            }
            else if ((creditScores >= 590) && (creditScores <= 619))
            {
                creditRating = "belowAverage";
            }
            else if ((creditScores >= 500) && (creditScores <= 589))
            {
                creditRating = "bad";
            }
            else if (creditScores >= 500)
            {
                creditRating = "Denied";
            }
            return creditRating;
        }


        void CalculateInterest(string x, int y, double j)
        {
            switch (x)
            {
                case "great":
                    interestRateN = 6.52;
                    break;
                case "good":
                    interestRateN = 7.36;
                    break;
                case "fair":
                    interestRateN = 8.52;

                    break;
                case "okay":
                    interestRateN = 9.75;

                    break;
                case "belowAverage":
                    interestRateN = 10.35;
                    break;
                case "bad":
                    interestRateN = 12.75;
                    break;
            }

            //calculate payments based off of a 30 month plan
            payments = ((carPrice / 60) + (interestRateN / 100));


            carAmount.Text = Convert.ToString(carPrice);
            //  interestRate.Text = Convert.ToString(interestRateN.ToString("P", CultureInfo.InvariantCulture));  
            interestRate.Text = Convert.ToString(interestRateN);

            paymentBox.Text = Convert.ToString(payments);
        }


        //Hides and unhides the details for the cars in the garage
        private void MyVehicle1_MouseEnter(object sender, MouseEventArgs e)
        {

            switch (Stats1.Visibility)
            {
                case Visibility.Visible:
                    Stats1.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    Stats1.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void MyVehicle1_MouseLeave(object sender, MouseEventArgs e)
        {
            switch (Stats1.Visibility)
            {
                case Visibility.Visible:
                    Stats1.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    Stats1.Visibility = Visibility.Visible;
                    break;
            }
        }


        private void MyVehicle2_MouseEnter(object sender, MouseEventArgs e)
        {
            switch (Stats2.Visibility)
            {
                case Visibility.Visible:
                    Stats2.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    Stats2.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void MyVehicle2_MouseLeave(object sender, MouseEventArgs e)
        {
            switch (Stats2.Visibility)
            {
                case Visibility.Visible:
                    Stats2.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    Stats2.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void MyVehicle3_MouseEnter(object sender, MouseEventArgs e)
        {
            switch (Stats3.Visibility)
            {
                case Visibility.Visible:
                    Stats3.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    Stats3.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void MyVehicle3_MouseLeave(object sender, MouseEventArgs e)
        {
            switch (Stats3.Visibility)
            {
                case Visibility.Visible:
                    Stats3.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    Stats3.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void SaveCar_Click(object sender, RoutedEventArgs e)
        {
            #region Save Vehicle to Text File
            // path the to txt file where data is saved; will need altering once there are more that one user activity profiles -ERL
            v1txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle1.txt";
            v2txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle2.txt";
            v3txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle3.txt";

            #region Convert data to strings
            string savMake = Convert.ToString(brand);
            string savModel = Convert.ToString(make);
            string savBody = Convert.ToString(body);
            string savEngine = Convert.ToString(engine);
            string savColor = Convert.ToString(color);
            string savYear = Convert.ToString(year);
            string savPrice = Convert.ToString(carPrice);
            string savPayments = Convert.ToString(payments);
            string savMilesGal = Convert.ToString(milesPerGallon);
            string savMileage = Convert.ToString(mileage);
            string savPicture = Convert.ToString(carView.Source);
            #endregion



            var vehicleData1 = new List<string>();
            var vehicleData2 = new List<string>();
            var vehicleData3 = new List<string>();

            if ((savVehicle1.Make == "") || (savVehicle1.Make == null))
            {
                CreateVehicle();
                vehicleData1.Add(savMake);
                vehicleData1.Add(savModel);
                vehicleData1.Add(savBody);
                vehicleData1.Add(savEngine);
                vehicleData1.Add(savColor);
                vehicleData1.Add(savYear);
                vehicleData1.Add(savPrice);
                vehicleData1.Add(savPayments);
                vehicleData1.Add(savMilesGal);
                vehicleData1.Add(savMileage);
                vehicleData1.Add(savPicture);
                System.IO.File.WriteAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle1.txt", vehicleData1);

            }
            else if (savVehicle2.Make == "")
            {
                CreateVehicle();
                vehicleData2.Add(savMake);
                vehicleData2.Add(savModel);
                vehicleData2.Add(savBody);
                vehicleData2.Add(savEngine);
                vehicleData2.Add(savColor);
                vehicleData2.Add(savYear);
                vehicleData2.Add(savPrice);
                vehicleData2.Add(savPayments);
                vehicleData2.Add(savMilesGal);
                vehicleData2.Add(savMileage);
                vehicleData2.Add(savPicture);
                System.IO.File.WriteAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle2.txt", vehicleData1);

            }
            else if (savVehicle3.Make == "")
            {
                CreateVehicle();
                vehicleData3.Add(savMake);
                vehicleData3.Add(savModel);
                vehicleData3.Add(savBody);
                vehicleData3.Add(savEngine);
                vehicleData3.Add(savColor);
                vehicleData3.Add(savYear);
                vehicleData3.Add(savPrice);
                vehicleData3.Add(savPayments);
                vehicleData3.Add(savMilesGal);
                vehicleData3.Add(savMileage);
                vehicleData3.Add(savPicture);
                System.IO.File.WriteAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle3.txt", vehicleData1);

            }
            else
            {
                MessageBox.Show(savMake);
                //   MessageBox.Show("Please Remove a Vehicle From Your Garage");
            }

            // still needs to add a way to save
            // all separated by semi-colons and tabs
            // each row in the window is a line in the string, ending with semicolon and carriage return
            // final line is the total miles value -ERL


            #endregion
        }

        /* private void InterestRate_TextChanged(object sender, TextChangedEventArgs e)
         {
             double valTemp = Convert.ToDouble(interestRate.Text);
             interestRate.Text = (valTemp.ToString("P", CultureInfo.InvariantCulture));
         }*/


        public void LoadVehicles()
        {
            v1txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle1.txt";
            v2txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle2.txt";
            v3txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle3.txt";


            vehicleData_1.Clear();
            var carLogFile_1 = File.ReadAllLines(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle1.txt");
            vehicleData_1 = new List<string>(carLogFile_1);


            vehicleData_2.Clear();
            var carLogFile_2 = File.ReadAllLines(v1txtPath);
            vehicleData_2 = new List<string>(carLogFile_2);

            vehicleData_3.Clear();
            var carLogFile_3 = File.ReadAllLines(v1txtPath);
            vehicleData_3 = new List<string>(carLogFile_3);




            //merge loaded data into objects
            int i = -1;
            foreach (string line in vehicleData_1)
            {
                i++;
                MergeCarInfo(line, i, 1);
            }

            i = -1;
            foreach (string line in vehicleData_2)
            {
                i++;
                MergeCarInfo(line, i, 2);
            }
            i = -1;
            foreach (string line in vehicleData_3)
            {
                i++;
                MergeCarInfo(line, i, 3);
            }
        }

        public string tempName;

        private void MergeCarInfo(string x, int y, int car)
        {

            //vehicle1 data merged


            if ((y == 0) && (car == 1))
            {
                savVehicle1.Make = x;
                tempName = x;
            }
            else if ((y == 1) && (car == 1))
            {
                savVehicle1.Model = x;

                tempName = tempName + " " + x;
            }
            else if ((y == 2) && (car == 1))
            {
                savVehicle1.Body = x;
            }
            else if ((y == 3) && (car == 1))
            {
                savVehicle1.Engine = x;
                carPricing1.Content = x;
            }
            else if ((y == 4) && (car == 1))
            {
                savVehicle1.Color = x;
            }
            else if ((y == 5) && (car == 1))
            {
                savVehicle1.Year = Convert.ToInt32(x);
                Car1Info.Content = x + " " + tempName;
            }
            else if ((y == 6) && (car == 1))
            {
                savVehicle1.Price = Convert.ToInt32(x);
                carPricing1.Content = x;
            }
            else if ((y == 7) && (car == 1))
            {
                savVehicle1.Payments = Convert.ToDouble(x);
                carPayment1.Content = x;
            }
            else if ((y == 8) && (car == 1))
            {
                savVehicle1.MilesGal = Convert.ToInt32(x);
                MilesPerGal1.Content = x;
            }
            else if ((y == 9) && (car == 1))
            {
                savVehicle1.Mileage = Convert.ToInt32(x);
                carMileage1.Content = x;
            }
            else if ((y == 10) && (car == 1))
            {
                MyVehicle1.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + x));
                MyVehicle1.Visibility = Visibility.Visible;
            }


            //vehicle2 data merged


            if ((y == 0) && (car == 1))
            {
                savVehicle2.Make = x;
                tempName = x;
            }
            else if ((y == 1) && (car == 1))
            {
                savVehicle2.Model = x;

                tempName = tempName + " " + x;
            }
            else if ((y == 2) && (car == 1))
            {
                savVehicle2.Body = x;
            }
            else if ((y == 3) && (car == 1))
            {
                savVehicle2.Engine = x;
                carPricing2.Content = x;
            }
            else if ((y == 4) && (car == 1))
            {
                savVehicle2.Color = x;
            }
            else if ((y == 5) && (car == 1))
            {
                savVehicle2.Year = Convert.ToInt32(x);
                Car2Info.Content = x + " " + tempName;
            }
            else if ((y == 6) && (car == 1))
            {
                savVehicle2.Price = Convert.ToInt32(x);
                carPricing2.Content = x;
            }
            else if ((y == 7) && (car == 1))
            {
                savVehicle2.Payments = Convert.ToDouble(x);
                carPayment2.Content = x;
            }
            else if ((y == 8) && (car == 1))
            {
                savVehicle2.MilesGal = Convert.ToInt32(x);
                MilesPerGal2.Content = x;
            }
            else if ((y == 9) && (car == 1))
            {
                savVehicle2.Mileage = Convert.ToInt32(x);
                carMileage2.Content = x;
            }
            else if ((y == 10) && (car == 1))
            {
                MyVehicle2.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + x));
                MyVehicle2.Visibility = Visibility.Visible;
            }


            //vehicle3 data merged


            if ((y == 0) && (car == 1))
            {
                savVehicle3.Make = x;
                tempName = x;
            }
            else if ((y == 1) && (car == 1))
            {
                savVehicle3.Model = x;

                tempName = tempName + " " + x;
            }
            else if ((y == 2) && (car == 1))
            {
                savVehicle3.Body = x;
            }
            else if ((y == 3) && (car == 1))
            {
                savVehicle3.Engine = x;
                carPricing3.Content = x;
            }
            else if ((y == 4) && (car == 1))
            {
                savVehicle3.Color = x;
            }
            else if ((y == 5) && (car == 1))
            {
                savVehicle3.Year = Convert.ToInt32(x);
                Car3Info.Content = x + " " + tempName;
            }
            else if ((y == 6) && (car == 1))
            {
                savVehicle3.Price = Convert.ToInt32(x);
                carPricing3.Content = x;
            }
            else if ((y == 7) && (car == 1))
            {
                savVehicle3.Payments = Convert.ToDouble(x);
                carPayment3.Content = x;
            }
            else if ((y == 8) && (car == 1))
            {
                savVehicle3.MilesGal = Convert.ToInt32(x);
                MilesPerGal3.Content = x;
            }
            else if ((y == 9) && (car == 1))
            {
                savVehicle3.Mileage = Convert.ToInt32(x);
                carMileage3.Content = x;
            }
            else if ((y == 10) && (car == 1))
            {
                MyVehicle3.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + x));
                MyVehicle3.Visibility = Visibility.Visible;
            }
        }

        private void UpdateCarDetails()
        {
            switch (year)
            {
                case 2005:
                    carYear.Content = Convert.ToString(year);
                    if(prevMake != make)
                    {
                        vPicture = null;
                    }
                    carPrice =4813;
                    break;
                case 2006:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }

                    break;
                case 2007:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2008:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2009:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2010:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2011:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2012:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2013:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2014:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2015:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2016:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2017:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                case 2018:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    if (brand == "Toyota")
                    {
                        if (make == "Corolla")
                        {
                            
                        }
                    }
                    else if(brand=="Dodge")
                    {

                    }

                    break;
                case 2019:
                    carYear.Content = Convert.ToString(year);
                    if (prevMake != make)
                    {
                        vPicture = null;
                    }
                    break;
                default:

                break;
            }
        }
        
        private void UpdateCarList()
        {

        }

        private void DeleteVehicle(int x)
        {


            switch (x)
            {
                case 1:
                    File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle1.txt", String.Empty); break;

                case 2:
                    File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle2.txt", String.Empty);
                    break;

                case 3:
                    File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle3.txt", String.Empty);
                    break;
                default:
                    break;
            }


        }


        public void CreateVehicle()
        {

            if (savVehicle1.Make == null)
            {

                savVehicle1.Make = brand;
                savVehicle1.Model = make;
                savVehicle1.Body = body;
                savVehicle1.Engine = engine;
                savVehicle1.Color = color;
                savVehicle1.Year = year;
                savVehicle1.Price = carPrice;
                savVehicle1.Payments = Convert.ToDouble(paymentBox.Text);
                savVehicle1.MilesGal = milesPerGallon;
                savVehicle1.Mileage = mileage;
                savVehicle1.Picture = vPicture;
            }
            else if (savVehicle2.Make == null)
            {
                savVehicle2.Make = brand;
                savVehicle2.Model = make;
                savVehicle2.Body = body;
                savVehicle2.Engine = engine;
                savVehicle2.Color = color;
                savVehicle2.Year = year;
                savVehicle2.Price = carPrice;
                savVehicle2.Payments = Convert.ToDouble(paymentBox.Text);
                savVehicle2.MilesGal = milesPerGallon;
                savVehicle2.Mileage = mileage;
                savVehicle2.Picture = vPicture;
            }
            else if (savVehicle3.Make == null)
            {
                savVehicle3.Make = brand;
                savVehicle3.Model = make;
                savVehicle3.Body = body;
                savVehicle3.Engine = engine;
                savVehicle3.Color = color;
                savVehicle3.Year = year;
                savVehicle3.Price = carPrice;
                savVehicle3.Payments = Convert.ToDouble(paymentBox.Text);
                savVehicle3.MilesGal = milesPerGallon;
                savVehicle3.Mileage = mileage;
                savVehicle3.Picture = vPicture;
            }
            else
            {
                MessageBox.Show("Please Remove a Vehicle From Your Garage");
            }
        }

        private void Tab1_Initialized(object sender, EventArgs e)
        {
            //check if vehicle 1 has a saved value, if true then print values, if false then hide

            if (savVehicle1.Make != null)
            {
                MyVehicle1.Visibility = Visibility.Visible;
                MilesPerGal1.Content = savVehicle1.MilesGal;
                carMileage1.Content = savVehicle1.Mileage;
                carEngine1.Content = savVehicle1.Engine;
                carColor1.Content = savVehicle1.Mileage;
                carPricing1.Content = savVehicle1.Price;
                carPayment1.Content = savVehicle1.Payments;

                MyVehicle1.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + savVehicle1.Picture));
            }
            else
            {
                MyVehicle1.Visibility = Visibility.Hidden;
            }

            //check if vehicle 2 has a saved value, if true then print values, if false then hide

            if (savVehicle2.Make != null)
            {
                MyVehicle2.Visibility = Visibility.Visible;


                MilesPerGal2.Content = savVehicle2.MilesGal;
                carMileage2.Content = savVehicle2.Mileage;
                carEngine2.Content = savVehicle2.Engine;
                carColor2.Content = savVehicle2.Mileage;
                carPricing2.Content = savVehicle2.Price;
                carPayment2.Content = savVehicle2.Payments;

                MyVehicle2.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + savVehicle1.Picture));
            }
            else
            {
                MyVehicle2.Visibility = Visibility.Hidden;
            }
            //check if vehicle 3 has a saved value, if true then print values, if false then hide
            if (savVehicle3.Make != null)
            {
                MyVehicle3.Visibility = Visibility.Visible;


                MilesPerGal3.Content = savVehicle3.MilesGal;
                carMileage3.Content = savVehicle3.Mileage;
                carEngine3.Content = savVehicle3.Engine;
                carColor3.Content = savVehicle3.Mileage;
                carPricing3.Content = savVehicle3.Price;
                carPayment3.Content = savVehicle3.Payments;

                MyVehicle3.Source = new BitmapImage(new Uri(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + savVehicle1.Picture));
            }
            else
            {
                MyVehicle3.Visibility = Visibility.Hidden;
            }
        }


        private void MyCarColor_Click(object sender, RoutedEventArgs e)
        {
            color = "blue";
        }
        #region Select Year
        private void Y2020_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = true;
            year = 2020;
            if (brand == "Corolla")
            {
                carPrice = 19000;
                carAmount.Text = Convert.ToString(19000);
            }

        }

        private void Y2010_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2010;


        }

        private void Y2007_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2007;

        }

        private void Y2006_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;
        }

        private void Y2009_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2011_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2012_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2013_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2014_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2015_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2016_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2017_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2018_Click(object sender, RoutedEventArgs e)
        {
            Color.IsEnabled = false;
            year = 2006;

        }

        private void Y2019_Click(object sender, RoutedEventArgs e)
        {
            if ((brand == "Toyota") && (make == "Corolla") && (body == "Sedan"))
            {
                Color.IsEnabled = true;
                carPrice = 19000;
                carAmount.Text = Convert.ToString(carPrice);
            }
            year = 2006;

        }
        #endregion

        #region Select Engine
        private void MyCarV2_Click(object sender, RoutedEventArgs e)
        {
            engine = "v2";
        }

        private void MyCarV4_Click(object sender, RoutedEventArgs e)
        {
            engine = "v4";

        }

        private void MyCarV8_Click(object sender, RoutedEventArgs e)
        {
            engine = "v8";


        }
        #endregion

        #region Remove vehicle from txt
        private void Remove1_Click(object sender, RoutedEventArgs e)
        {
            DeleteVehicle(1);
            LoadVehicles();
            ReInitialize(1);
        }
        private void Remove3_Click(object sender, RoutedEventArgs e)
        {
            DeleteVehicle(3);
            LoadVehicles();
            ReInitialize(3);
        }

        private void Remove2_Click(object sender, RoutedEventArgs e)
        {
            DeleteVehicle(2);
            LoadVehicles();
            ReInitialize(2);
        }
        #endregion

        private void ReInitialize(int x)
        {
            switch (x)
            {
                case 1:
                    MyVehicle1.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    MyVehicle2.Visibility = Visibility.Hidden;
                    break;
                case 3:
                    MyVehicle3.Visibility = Visibility.Hidden;
                    break;
            }
        }

        private void Tab1_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            LoadVehicles();
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
    public struct Vehicle
    {
        public string Make;
        public string Model;
        public string Body;
        public string Engine;
        public string Color;
        public int Year;
        public int Price;
        public double Payments;
        public int MilesGal;
        public int Mileage;
        public string Picture;

        public Vehicle(string vmake, string model, string body, string engine, string color, int year, int price, double payments, int milesGal, int mileage, string picture)
        {
            Make = vmake;
            Model = model;
            Body = body;
            Engine = engine;
            Color = color;
            Year = year;
            Price = price;
            Payments = payments;
            MilesGal = milesGal;
            Mileage = mileage;
            Picture = picture;

        }
    }
}