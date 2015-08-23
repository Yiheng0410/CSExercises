using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double FixedCharge = 2.4;
            double DistanceTraveld;
            double TotalCharge;
            Console.Write("Pls enter the distance you've traveled: ");
            DistanceTraveld= Convert.ToDouble(Console.ReadLine());
            TotalCharge = FixedCharge + DistanceTraveld*0.4;
            Console.WriteLine("The total Charge is $: "+ TotalCharge);
        }
    }
}
