using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarJack
{
    public class CarJackFunctions
    {

        public static string CreditStandingByScore(int x)
        {
            
            if (x >= 720)
            {
                return "great";
            }
            else if ((x >= 690) && (x <= 719))
            {
                return "good";
            }
            else if ((x >= 660) && (x <= 689))
            {
                return "fair";
            }
            else if ((x >= 620) && (x <= 659))
            {
                return "okay";
            }
            else if ((x >= 590) && (x <= 619))
            {
                return "belowAverage";
            }
            else return "bad";
            
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


        /// <summary>
        /// Multiplies the user string inputs and returns result as an int.  Used in calculation of annual years driven.
        /// Checks for empty string and ignores rows with them.
        /// Tries to convert to int.  If fails should return zero.
        /// </summary>
        /// <param name="miles">User supplied miles per trip value.</param>
        /// <param name="trips">User supplied trips per week value.</param>
        /// <param name="weeks">User supplied weeks per year value.</param>
        /// <returns>Value returned signifies miles driven for that particular trip in a given year.</returns>
        public static int MultiplyActivityBoxes(string miles, string trips, string weeks)
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
    }
}
