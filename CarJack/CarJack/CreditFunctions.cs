namespace CarJack
{
    public class CreditFunctions
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
            double paymentsPerMonth = ((carPrice / 120) + ((carPrice / 120) * (interestRateN / 100)));
            return paymentsPerMonth;
        }
    }
}
