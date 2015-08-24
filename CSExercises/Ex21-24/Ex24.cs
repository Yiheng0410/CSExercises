using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter an number:");
            num = Convert.ToInt32(Console.ReadLine());

            Random i = new Random();
            double SqaureRoot = i.Next(1, num);
            while (SqaureRoot * SqaureRoot - num >= 0.0001 || num - SqaureRoot * SqaureRoot >= 0.0001)
            {
                SqaureRoot = (SqaureRoot + num / SqaureRoot) / 2;
            }
            Console.WriteLine("{0:0.00000}", SqaureRoot);

        }
    }
}
