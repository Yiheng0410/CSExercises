using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string Gender = Console.ReadLine();
            if (Gender == "M")
                Console.WriteLine("Good monring Mr.{0}", Name);
            else if (Gender == "F")
                Console.WriteLine("Good monring Ms.{0}", Name);
            else
                Console.WriteLine("Please enter the correct gende");
        }
    }
}