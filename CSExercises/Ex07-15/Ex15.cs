using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a three digit integer numbers(from 100 to 999)");
            int e = int.Parse(Console.ReadLine());
            //for  (e = 100; e <= 999; e++) ;// What is "For" and what is "++"
            int a, b, c, d;
            a = e / 100;
            b = (e - a * 100)/10 ;
            c = (e  - a * 100- b * 10);
            d = a * a * a + b * b * b + c * c * c;
            if (d == e)
            {   Console.WriteLine("this is an amrstrong number");
                Console.ReadLine();
            }
            else
            {   Console.WriteLine("this is not an amrstrong number");
                Console.ReadLine();
            }
            Console.ReadLine(); 
        }
    }
}