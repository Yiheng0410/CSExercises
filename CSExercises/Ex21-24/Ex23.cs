using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            ////Part A
            //int RandomNum, NumEntered;
            //int NumofGuess=0;
            //Random i = new Random();
            //RandomNum = i.Next(0, 10);
            //Console.WriteLine("Welcome to Guess A Number Game");
            //do
            //{
            //Console.Write("Please enter a number(0 to 9): ");
            //NumEntered=Convert.ToInt32(Console.ReadLine());
            //NumofGuess = NumofGuess + 1;
            //   if (RandomNum != NumEntered)
            //    {
            //     Console.WriteLine("Wrong Number, Guess Again.");
            //    }
            //   else
            //   {
            //      Console.WriteLine("Congrates, you get the correct number by {0} time(s) of guessing",NumofGuess);
            //   } 
            //}
            //while (RandomNum != NumEntered);

            //Part B
            int RandomNum, NumEntered;
            int NumofGuess = 0;
            Random i = new Random();
            RandomNum = i.Next(0, 10);
            Console.WriteLine("Welcome to Guess A Number Game");
            do
            {
                Console.Write("Please enter a number(0 to 9): ");
                NumEntered = Convert.ToInt32(Console.ReadLine());
                NumofGuess = NumofGuess + 1;
                if (RandomNum != NumEntered)
                {
                    Console.WriteLine("Wrong Number, Guess Again.");
                }
                else if (NumofGuess <= 2)
                {
                    Console.WriteLine("You are a Wizard");
                }
                else if (NumofGuess > 2 && NumofGuess <= 5) 
                {
                    Console.WriteLine("You are a good guess");
                }
                else
                {
                    Console.WriteLine("You are lousy!");
                }
            }
            while (RandomNum != NumEntered);

        }
    }
}
