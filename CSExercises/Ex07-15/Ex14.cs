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
            Console.WriteLine("Pls enter the value for a b and c");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;
            Console.WriteLine("the value you've entered for a b and c is {0},{1},{2}", a, b, c);
            double area = Math.Sqrt(s*(s - a)*(s - b)*(s - c) );
            Console.WriteLine("the Area is" + area);
            Console.ReadLine();


        }
    }
}