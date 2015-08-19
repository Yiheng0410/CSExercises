using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV, DVD, MP3;
            double Total1, Total2, Total3;

            Console.Write("Enter quantity for TV:");
            TV = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD:");
            DVD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3:");
            MP3 = Convert.ToInt32(Console.ReadLine());

            Total1 = TV * 900 + DVD * 500 ;
            Total2 = MP3 * 700;
            Total3 = Total1 + Total2;

            if (Total3 > 5000 && Total3 <=10000)
                Console.WriteLine("The price for this order is ${0}", Total1 * 0.9 +Total2);
            else if (Total3 >10000 )
                Console.WriteLine("The price for this order is ${0}", Total1 * 0.85 +Total2);
            else
                Console.WriteLine("The price for this order is ${0}", Total3);
        }
    }
}