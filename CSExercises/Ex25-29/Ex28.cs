using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter A number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i < num; i++)
            {        
                if (num % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    break; // Stop looping, break out of the loop.
                }       
            }
            if (i>=num)
            Console.WriteLine("Prime");
            }
    }
}
