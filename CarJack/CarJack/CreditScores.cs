using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarJack
{
    interface CreditScores_Interface
    {
        string CreditStandingByScore(int x);
        double CalculateInterest(string x);
    }


    class CreditScores : CreditScores_Interface
    {
        public string CreditStandingByScore(int x)
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

        public double CalculateInterest(string x)
        {
            switch (x)
            {
                case "great":
                    return 6.52;
                case "good":
                    return 7.36;
                case "fair":
                    return 8.52;
                case "okay":
                    return 9.75;
                case "belowAverage":
                    return 10.35;
                case "bad":
                    return 12.75;
                default:
                        return -1;
            }

        }

    }
}
