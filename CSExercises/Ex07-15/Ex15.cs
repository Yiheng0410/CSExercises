using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int num, numA, numB, numC, numArmstrong;
            Console.WriteLine("Pls enter a three digit integer numbers(from 100 to 999): ");
            num = int.Parse(Console.ReadLine());
            numA = num / 100;
            numB = (num - numA * 100)/10 ;
            numC = (num  - numA * 100- numB * 10);
            numArmstrong = numA * numA * numA + numB * numB * numB + numC * numC * numC;
            if (numArmstrong == num)
            {  
                Console.WriteLine("{0} is an amrstrong number",num);
            }
            else
            {   
                Console.WriteLine("{0} is not an amrstrong number",num);
            }
        }
    }
}