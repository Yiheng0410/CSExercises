using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter A number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int sum = 1;
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;              
                    //break;
                }
            }
            //if (i >= num)
                //Console.WriteLine("Prime");
                if(sum == num) Console.WriteLine("Perfect Number");
                else Console.WriteLine("Not Perfect Number");

        }
    }
}
