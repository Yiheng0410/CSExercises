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
            for (num= 5; num<= 1000; num++)

                for (i = 5; i <= num/i; i++)
            {
                    if (num % i == 0)
                    break;
                    if (i <2)
                    Console.Write("{0}", num);
            }
            Console.WriteLine();
        }
    }
}
