using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int luckynumber=88;
            bool shouldcontinue = true;
            while (shouldcontinue)
            {
                Console.Write("Please enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());              
                    if (num1 == luckynumber)
                {
                    Console.WriteLine("you lucky");
                    shouldcontinue = false;
                }
                     else     
                    Console.WriteLine("Enter Again");                
            }
        }
    }
}
