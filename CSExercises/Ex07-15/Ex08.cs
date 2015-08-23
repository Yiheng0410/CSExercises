using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Double TemperatureC;
            Double TemperatureF;
            Console.Write("Enter the Temp in Centigrade: ");
            TemperatureC = Convert.ToDouble(Console.ReadLine());
            TemperatureF = 1.8 * TemperatureC + 32;
            Console.WriteLine("The Temp in Fahrenheit is: "+TemperatureF);      
        }
    }
}
