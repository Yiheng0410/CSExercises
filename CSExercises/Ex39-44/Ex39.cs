using System;
namespace CSExercises
{
    public class Ex39
    {
        static void Main(string[] args)
        {
            double num2;
            Console.Write("Pls Enter a number: ");
            num2=Convert.ToDouble(  Console.ReadLine());
            //Factorial(num2);
            Console.WriteLine("The factorial of the given number is " + Factorial(num2));
            

        }
        public static double Factorial(double num)
        {
            double Sum = num;
            for (int i = 0; i < num-1; i++)
            {
                Sum = Sum * (num - 1 - i);
            }
            return Sum;
        }
    }
}