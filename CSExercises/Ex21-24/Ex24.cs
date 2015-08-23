using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter an number:");
            n = Convert.ToInt32(Console.ReadLine());

            Random i = new Random();
            double G = i.Next(1, n);
            while (G * G - n > 0.0001)
            {
                 G = (G + n / G) / 2;
            }
            Console.WriteLine("{0:0.00000}",G);

        }
    }
}
