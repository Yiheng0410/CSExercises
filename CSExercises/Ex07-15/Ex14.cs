using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double LengthA, LengthB, LengthC,Area,S;
            Console.WriteLine("Pls enter the lenths for the triangle: ");
            Console.WriteLine("The Lenth entered for side A is: {0} ", LengthA = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("The Lenth entered for side B is: {0} ", LengthB = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("The Lenth entered for side C is: {0} ", LengthC = Convert.ToDouble(Console.ReadLine()));
            S = (LengthA + LengthB + LengthC) / 2;
            Area= Math.Sqrt(S*(S - LengthA)*(S - LengthB)*(S - LengthC) );
            Console.WriteLine("the Area is: " + Area);
        }
    }
}