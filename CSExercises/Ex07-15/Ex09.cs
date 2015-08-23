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
            Double Inputnum;
            Double Outputnum;
            Console.Write("Pls enter a number: ");
            Inputnum = Convert.ToDouble(Console.ReadLine());
            Outputnum = Inputnum * Inputnum * 2 - 4 * Inputnum + 3;
            Console.WriteLine(Outputnum);
        }
    }
}
