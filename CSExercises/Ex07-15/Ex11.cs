﻿using System;
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

            Console.WriteLine("Pls Enter the distance you've traveled");
            Double FixedCharge = 2.4;
            Double DistanceTraveld= 0.4 * Convert.ToDouble(Console.ReadLine());
            Double TotalChagrge = FixedCharge + DistanceTraveld;
            Console.WriteLine("The total Charge is:"+ TotalChagrge);
            Console.ReadLine();



        }
    }
}
