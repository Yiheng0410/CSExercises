using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {

            int A, B, a,b,HCF, LCM;
            Console.Write("Please enter A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter B: ");
            B = Convert.ToInt32(Console.ReadLine());
            a = A;
            b = B;
            do
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            while (a != b);
            HCF = a;
            LCM = (A * B) / a;
            Console.WriteLine("HCF{0}", HCF);
            Console.WriteLine("LCM{0}", LCM);
        }
    }
}
