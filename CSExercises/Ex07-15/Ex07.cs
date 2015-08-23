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
            int HouseAllowance;
            int TransportAllowance;
            double TotalIncome;
            Console.Write("Eneter the Amount of Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
            HouseAllowance = (Salary / 100) * 10;
            TransportAllowance = (Salary / 100) * 3;
            TotalIncome = Salary + HouseAllowance + TransportAllowance;
            Console.WriteLine("The total income is {0:C}",TotalIncome);
        }
    }
}
