using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Please enter your gender(M/F): ");
            string Gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Gender == "M" && Age>= 40)
                Console.WriteLine("Good monring Uncle.{0}", Name);
            else if (Gender == "M" && Age < 40)
                Console.WriteLine("Good monring Mr.{0}", Name);
            else if (Gender == "F" && Age >= 40)
                Console.WriteLine("Good monring Aunty.{0}", Name);
            else if (Gender == "F" && Age < 40)
                Console.WriteLine("Good monring Ms.{0}", Name);
            else
                Console.WriteLine("Please enter the correct gende");
        }
    }
}