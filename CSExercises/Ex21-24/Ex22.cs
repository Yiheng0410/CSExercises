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

            int A, B,HCF,LCM;
            Console.Write("Please enter A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter B:");
            B = Convert.ToInt32(Console.ReadLine());
            while (A != B)
            {
                if (A > B)
                    A = A - B;
                else
                    B = B - A;
            }
            HCF = A;
            LCM = (A * B) / HCF;
            Console.WriteLine("HCF{0 }", HCF);
            Console.WriteLine("LCM{0 }", LCM);
        }
    }
}
