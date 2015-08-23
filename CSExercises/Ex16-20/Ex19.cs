using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double distance, charge1, charge2, charge3;
            Console.Write("Enter the distance you've traveled: ");
            distance = Convert.ToDouble(Console.ReadLine());
            distance = Math.Ceiling(distance * 10) / 10;
            charge1 = 2.40;
            charge2 = 8.5 * 0.4;
            charge3 = (distance - 9) * 0.5;

            if (distance <= 0.5)
                Console.WriteLine("The amount you need to pay is$ {0:0.00}", charge1);
            else if(distance >0.5 && distance<=9 )
                Console.WriteLine("The amount you need to pay is$ {0:0.00}", charge1+charge2);
            else if(distance >=9)
                Console.WriteLine("The amount you need to pay is$ {0:0.00}", charge1+charge2+charge3);
        }
    }
}