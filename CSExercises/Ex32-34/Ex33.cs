using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
           
            int[] Num = new int[20] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int[] NewNum = new int[] { };
        
            for (int i = 0; i <Num.Length; i++)
            {
                for (int j=i+1; j<Num.Length;j++)
                                 
                    if (Num[i] < Num[j])
                    {
                        int tempmax = Num[i];
                          Num[i] = Num[j];
                          Num[j] = tempmax;
                    }
             }
            for (int k = 0; k < Num.Length; k++)
            {
                Console.Write("{0} ", Num[k]);
            }
              
        }
    }
 }

