using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            //Part A
            int num, e, Factorial = 1;
            Console.Write("Please enter a number:");
            num = Convert.ToInt32(Console.ReadLine());
            for (e = 1; e <= num; e++)
            {
                Factorial = e * Factorial;
            }
            Console.WriteLine(Factorial);

            //Part B
            Factorial = 1;
            for ( e = num; e>=1; e--)
            {
                Factorial = e * Factorial;
            }
            Console.WriteLine(Factorial);
        }
    }
}
