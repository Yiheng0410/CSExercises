using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Double Y;
            Console.WriteLine("X\t Y");
            Console.WriteLine("-----------------");
            for (int i = -5; i < 5; i++)
            {
                Y = i * i * 2 - 4 * i+ 3;
                Console.WriteLine("{0:0.0}\t{1:0.0}",i,Y);
            }

            for (int a = 1; a <=20; a++)
            {
                Y = a * a* 2 - 4 * a + 3;
                for (int b = 0; b < Y; b++) 
                    Console.Write("*");
                Console.WriteLine();
            }
        
        }
    }
}
