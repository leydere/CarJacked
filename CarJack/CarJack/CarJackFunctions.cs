using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarJack
{
    public class CarJackFunctions
    {



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

        // functions copied from UnitTesting_MasterBranch

        public static bool CheckForBlankBoxes(string inputText)
        {
            if (inputText == "") return true;
            return false;
        }
        /// <summary>
        /// Checks for values outside the range of 0 - 52.  Does this as the input is expected to represent a number of weeks in one year.
        /// </summary>
        /// <param name="inputText">Input to be checked.  From weeks per year column.</param>
        /// <returns>Returns true if found, false if not.</returns>
        public static bool CheckForZeroThrough52(string inputText)
        {
            if (Int32.Parse(inputText) < 0 || Int32.Parse(inputText) > 52) return true;
            return false;
        }
        /// <summary>
        /// Checks for values greater than or equal to 1000.  Does this as large trips of this length are out of the ordinary.
        /// </summary>
        /// <param name="inputText">Input to be checked.  From the trip miles column.</param>
        /// <returns>Returns true if found, false if not.</returns>
        public static bool CheckForUnreasonablyLargeValue(string inputText)
        {
            if (Int32.Parse(inputText) >= 1000) return true;
            return false;
        }
        /// <summary>
        /// Checks for values greater than or equal to 100.  Does this as large trips of this length are out of the ordinary.
        /// </summary>
        /// <param name="inputText">Input to be checked.  From the trip miles column.</param>
        /// <returns>Returns true if found, false if not.</returns>
        public static bool CheckForLargeValue(string inputText)
        {
            if (Int32.Parse(inputText) >= 100) return true;
            return false;
        }
        /// <summary>
        /// Checks if an input is a negative number.  Checks for since a negative number would be an illogical input.
        /// </summary>
        /// <param name="inputText">Input to be checked for negative. From one of the three numeric columns on the activity calculator tab.</param>
        /// <returns>Returns true if negative value found.  Returns false otherwise.</returns>
        public static bool CheckForNegativeValues(string inputText)
        {
            if (Int32.Parse(inputText) < 0) return true;
            return false;
        }
        /// <summary>
        /// Checks if a string can be parsed as a whole number.  Used to ensure input is of the correct type for further use.
        /// </summary>
        /// <param name="inputText">String that will parse attempt will be made on. From one of the three numeric columns on the activity calculator tab.</param>
        /// <returns>Returns true a string cannot be parsed to int.  Returns false otherwise.</returns>
        public static bool CheckForWholeNumbers(string inputText)
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
        public static string TrimSemiColons(string inputText)
        {
            inputText = inputText.Replace(";", "");
            return inputText;
        }
        /// <summary>
        /// Checks string for semicolons.  Return boolean value used to determine if popup window and trim function should be called.
        /// </summary>
        /// <param name="inputText">String to check for semicolons.</param>
        /// <returns>True if found. False if not found.</returns>
        public static bool CheckForSemiColons(string inputText)
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
