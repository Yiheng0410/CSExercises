using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The following numbers are the perfect numbers from 1 to 1000: ");
            int num;// nums from 1 to 1000
            int i;
            for (num =1; num <= 1000; num++) 
            {
                int Sumofactors = 1;
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Sumofactors = Sumofactors + i;
                    }
                }
                if (Sumofactors == num)
                {
                    Console.WriteLine(num);
                } 
            }
       }
    }
}
