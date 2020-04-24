using System;

namespace CarJack
{
    public class ActivityMath
    {
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
