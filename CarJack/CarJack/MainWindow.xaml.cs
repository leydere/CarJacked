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
        public int year=2019;
        public int creditScores = 750;
        public int carPrice;

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
                switch (year)
                {
                    case 2005:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 8000;
                        break;
                    case 2006:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 7000;
                        break;
                    case 2007:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 6000;
                        break;
                    case 2008:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 5500;
                        break;
                    case 2009:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 8000;
                        break;
                    case 2010:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 9000;
                        break;
                    case 2011:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 9000;
                        break;
                    case 2012:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 10700;
                        break;
                    case 2013:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 11500;
                        break;
                    case 2014:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 11500;   //needsActualPrice
                        break;
                    case 2015:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 11500;   //needsActualPrice

                        break;
                    case 2016:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 15000;
                        break;
                    case 2017:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 11500;   //needsActualPrice

                        break;
                    case 2018:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 11500;   //needsActualPrice

                        break;
                    case 2019:
                        make = "Corolla";
                        Sedan.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhite.png")));
                        HatchBack.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\crazy\source\repos\CarJack5\CarJack\CarJack\images\ToyotaCorollaWhiteHatch.png")));
                        carPrice = 11500;   //needsActualPrice

                        break;
                    default:
                        break;
                }
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

        /// <summary>
        /// Clicking the calc & save button does all the appropriate multiplication and addition.
        /// The resulting values are saved into a .txt document in the application file structure.
        /// "\activity_profiles\0.txt" (will need updated once there are multiple user activity profiles)
        /// </summary>
        private void Calc_Save_Click(object sender, RoutedEventArgs e)
        {
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
            // path the to txt file where data is saved; will need altering once there are more that one user activity profiles -ERL
            string txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\activity_profiles\\0.txt";

            string activityData = "";
            string insTab = ";\t";
            string insRet = ";\n";

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
            #endregion

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

            // trims out the tabs and carriage returns, then splits by semicolons into an array -ERL
            readFromTextFile = readFromTextFile.Replace("\t", "");
            readFromTextFile = readFromTextFile.Replace("\n", "");
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

        }

        private void InterestCalc_Click(object sender, RoutedEventArgs e)
        {
            if(carSelectionGrid.Visibility == Visibility.Visible)
            {
                carSelectionGrid.Visibility = Visibility.Hidden;
                interestGrid.Visibility = Visibility.Visible;
            }
            else {
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
    }
}