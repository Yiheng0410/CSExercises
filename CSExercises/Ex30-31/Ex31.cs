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
            int num, i;
            for (num = 1; num <= 1000; num++)
            {
                for (i = 5; i <= num / i; i++)
                {
                    if (num % i == 0)
                    {
                       num = num + i;
                        Console.WriteLine("{ 0}", num);
                    }
                
               }
            
           }
       }
    }
}
