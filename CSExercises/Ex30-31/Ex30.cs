using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int num,i;
            Console.WriteLine("The prime number from 5 to 1000 are: ");
            for (num= 5; num<= 1000; num++)
            {
                for ( i = 2; i < num; i++)
			{
                if (num % i == 0)
                {
                    break;
                }
			}
            if (i>=num)
            {
                Console.WriteLine(num);
            }
            }  
        }
    }
}
