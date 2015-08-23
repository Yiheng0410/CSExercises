using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your scores: ");
            int Score = Convert.ToInt32(Console.ReadLine());
            if (Score >= 80 && Score <=100)
                Console.WriteLine("Your Scored {0} marks which is an A grade", Score);
            else if (Score >= 60 && Score <= 79)
                Console.WriteLine("Your Scored {0} marks which is a B grade", Score);
            else if (Score >= 40 && Score <= 59)
                Console.WriteLine("Your Scored {0} marks which is a C grade", Score);
            else if (Score >= 0 && Score <= 39)
                Console.WriteLine("Your Scored {0} marks which is a F grade", Score);
            else
                Console.WriteLine("Error");



        }
    }
}