using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double C;
            Double F;
            Console.WriteLine("Enter the Temp in Centigrade");
            C = Convert.ToDouble(Console.ReadLine());
            F = 1.8 * C + 32;
            Console.WriteLine(F);      
        }
    }
}
