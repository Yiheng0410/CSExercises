using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i;
            double Min = 0, Max = 0, min1 = 0, max2 = 0,avg=0;
            double[] sales = new double[12];
            for (i = 0; i < sales.Length; i++)
            {
                Console.Write("enter sales for the month {0}:", i);
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }


            for (i = 0; i < sales.Length; i++)
            {
                if (Min == 0)
                {
                    Min = sales[0];
                }
                if (Min > sales[i])
                {
                    Min = sales[i];
                    min1 = i;
                }
                if (Max == 0)
                {
                    Max = sales[0];
                }
                if (Max < sales[i])
                {
                    Max = sales[i];
                    max2 = i;
                }
                avg = avg + sales[i] / sales.Length;

            }
            Console.WriteLine("Minimum sales:{0}", min1);
            Console.WriteLine("Maximum sales:{0}", max2);
            Console.WriteLine("Average Sales:{0}", avg);

            //--> 

            //int i;
            //double Min, Max, min1 = 0, max2 = 0, avg = 0;
            //double[] sales = new double[12];
            //for (i = 0; i < sales.Length; i++)
            //{
            //    Console.Write("enter sales for the month {0}:", i);
            //    sales[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //double Min = sales[0], Max = sales[0];
            //for (i = 0; i < sales.Length; i++)
            //{
            //    if (Min > sales[i])
            //    {
            //        Min = sales[i];
            //        min1 = i;
            //    }

            //    if (Max < sales[i])
            //    {
            //        Max = sales[i];
            //        max2 = i;
            //    }
            //    avg = avg + sales[i] / sales.Length;

            //}
            //Console.WriteLine("Minimum sales:{0}", min1);
            //Console.WriteLine("Maximum sales:{0}", max2);
            //Console.WriteLine("Average Sales:{0}", avg);
        }
    }

}

