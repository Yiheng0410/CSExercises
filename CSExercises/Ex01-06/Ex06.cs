using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter A Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
        }
    }
}
