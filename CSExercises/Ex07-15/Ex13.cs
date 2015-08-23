using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double DistanceTraveld;
            double TotalCharge;
            double RoundUpTotalCharge;
            Console.Write("Pls enter the distance you've traveled: ");
            DistanceTraveld = Convert.ToDouble(Console.ReadLine());
            TotalCharge = 2.4 + DistanceTraveld * 0.4;
            RoundUpTotalCharge = Math.Ceiling(TotalCharge);
            Console.WriteLine("The total Charge is: ${0:0.00}", RoundUpTotalCharge);
        }
    }
}
