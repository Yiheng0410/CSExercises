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
            int i, e, a = 1;
            Console.Write("Please enter a number:");
            i = Convert.ToInt32(Console.ReadLine());
            for (e = 1; e <= i; e++)
            {
                a = e * a;
            }
            Console.WriteLine(a);

            a = 1;
            for ( e = i; e>=1; e--)
            {
                a = e * a;
            }
            Console.WriteLine(a);
        }
    }
}
