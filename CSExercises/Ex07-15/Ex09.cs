using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Double X;
            Double Y;
            Console.WriteLine("Enter a value of X");
            X = Convert.ToDouble(Console.ReadLine());
            Y = X * X * 2 - 4 * X + 3;
            Console.WriteLine(Y);




        }
    }
}
