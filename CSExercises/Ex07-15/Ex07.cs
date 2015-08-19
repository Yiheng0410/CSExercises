using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            int Salary;
            int House;
            int Transport;
            Console.WriteLine("Eneter the Amount of Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            House = (Salary / 100) * 10;
            Transport = (Salary / 100) * 3;
            Console.WriteLine(Salary + House + Transport);
        }
    }
}
