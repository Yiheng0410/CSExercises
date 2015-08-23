using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pls enter numbers for X1,Y1,X2,Y2 : ");
            Double Distance;
            Double X1 = Convert.ToDouble(Console.ReadLine());
            Double Y1 = Convert.ToDouble(Console.ReadLine());
            Double X2 = Convert.ToDouble(Console.ReadLine());
            Double Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The two point you've entered are ({0},{1})  ({2},{3})", X1, Y1, X2, Y2);
            Double X = X2 - X1;
            Double Y = Y2 - Y1;
            Double A = Math.Pow(X, 2); //Math.Pow(X1,X2) means how many times(X2) times X1.
            Double B = Math.Pow(Y, 2);
            Console.WriteLine("Distance between this two point is: {0}",Distance = Math.Sqrt(A + B));
        }
    }
}
