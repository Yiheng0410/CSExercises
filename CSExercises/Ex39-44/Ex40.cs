using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Number\tSquare Root");
            for ( int i = 1; i <= 25; i++)
            {
                Console.WriteLine(i +"      "+ SQT(i));
            }
        }

        public static double SQT(int num)
        {
            //SquareRoot = Math.Sqrt(num);

            Random numRand = new Random();
            double SquareRoot = numRand.Next(1, num);
            while (SquareRoot * SquareRoot - num >= 0.0001 || num - SquareRoot * SquareRoot >= 0.0001) 
            {
                SquareRoot = (SquareRoot + num / SquareRoot) / 2;
            }
            return SquareRoot;
        }
    }

}