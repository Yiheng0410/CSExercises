using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int integer;
            Console.Write("Enter a Number: ");
            integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(integer*integer);
        }
    }
}
