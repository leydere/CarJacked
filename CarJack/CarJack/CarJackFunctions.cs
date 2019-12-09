using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CarJack;

namespace CarJack
{
    public class CarJackFunctions
    {

        public string CreditValue(int x)
        {
            
            string creditRating = "good";

            if (x >= 720)
            {
                creditRating = "great";
            }
            else if ((x >= 690) && (x <= 719))
            {
                creditRating = "good";
            }
            else if ((x >= 660) && (x <= 689))
            {
                creditRating = "fair";
            }
            else if ((x >= 620) && (x <= 659))
            {
                creditRating = "okay";
            }
            else if ((x >= 590) && (x <= 619))
            {
                creditRating = "belowAverage";
            }
            else if ((x >= 500) && (x <= 589))
            {
                creditRating = "bad";
            }
            
            return creditRating;
        }
        /// <summary>
        /// <returns>Value returned signifies miles driven for that particular trip in a given year.</returns>
        public static double CalculateInterest(string x, int carPrice)
        {
            double interestRateN = 0.00;
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
            double paymentsPerMonth = ((carPrice / 120) + ((carPrice / 120)*(interestRateN / 100)));
            return paymentsPerMonth;
        }


        public static bool CheckIfFree(int x)
        {
            bool isFree = false;
            string test;

            //Set up readable files
            string v1txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle1.txt";
            string v2txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle2.txt";
            string v3txtPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Vehicle_profiles\\vehicle3.txt";
            switch (x)
            {
                case 1:

                    var carLogFile_1 = new List<string>(File.ReadAllLines(v1txtPath));
                    try
                    {
                        test = carLogFile_1[0];
                    }
                    catch
                    {
                        isFree = true;
                        return isFree;
                    }

                    if (test == "")
                    {
                        isFree = true;

                    }
                    else
                    {
                        isFree = false;
                    }
                    break;
                case 2:
                    var carLogFile_2 = new List<string>(File.ReadAllLines(v2txtPath));
                    try
                    {
                        test = carLogFile_2[0];
                    }
                    catch
                    {
                        isFree = true;
                        return isFree;
                    }
                    if (test == "")
                    {
                        isFree = true;

                    }
                    else
                    {
                        isFree = false;
                    }
                    break;

                case 3:
                    var carLogFile_3 = new List<string>(File.ReadAllLines(v3txtPath));
                    try
                    {
                        test = carLogFile_3[0];
                    }
                    catch
                    {
                        isFree = true;

                        return isFree;
                    }

                    if (test == "")
                    {
                        isFree = true;

                    }
                    else
                    {
                        isFree = false;
                    }

                    return isFree;
            }
            return isFree;
        }
    }
}
