using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] Marks = new int[12, 4];
            Marks[0, 0] = 56; Marks[0, 1] = 84; Marks[0, 2] = 68; Marks[0, 3] = 29;
            Marks[1, 0] = 94; Marks[1, 1] = 71; Marks[1, 2] = 31; Marks[1, 3] = 89;
            Marks[2, 0] = 41; Marks[2, 1] = 63; Marks[2, 2] = 36; Marks[2, 3] = 90;
            Marks[3, 0] = 99; Marks[3, 1] = 9; Marks[3, 2] = 18; Marks[3, 3] = 17;
            Marks[4, 0] = 62; Marks[4, 1] = 3; Marks[4, 2] = 65; Marks[4, 3] = 75;
            Marks[5, 0] = 40; Marks[5, 1] = 96; Marks[5, 2] = 53; Marks[5, 3] = 23;
            Marks[6, 0] = 81; Marks[6, 1] = 15; Marks[6, 2] = 27; Marks[6, 3] = 30;
            Marks[7, 0] = 21; Marks[7, 1] = 70; Marks[7, 2] = 100; Marks[7, 3] = 22;
            Marks[8, 0] = 88; Marks[8, 1] = 50; Marks[8, 2] = 13; Marks[8, 3] = 12;
            Marks[9, 0] = 48; Marks[9, 1] = 54; Marks[9, 2] = 52; Marks[9, 3] = 78;
            Marks[10, 0] = 64; Marks[10, 1] = 71; Marks[10, 2] = 67; Marks[10, 3] = 25;
            Marks[11, 0] = 16; Marks[11, 1] = 93; Marks[11, 2] = 47; Marks[11, 3] = 72;
            for (int j= 0; j <=11; j++)     
            {
                int TotalMarks = 0;
                for (int i = 0; i <= 3; i++)
                {
                TotalMarks = TotalMarks + Marks[j, i];
                }
                Console.WriteLine("The Total Mark for student " + (j + 1) + " is:" + TotalMarks);
            }
            for (int j = 0; j <= 3; j++)
            {
                double ClassAverage = 1;
                for (int i = 0; i <= 11; i++)
                {
                    ClassAverage = ClassAverage + Marks[i,j];
                }
                Console.WriteLine("The Total Mark for subject " + (j + 1) + " is:" + ClassAverage/12);
            }
            double AverageTotalMarks = 0;
            for (int j = 0; j <= 11; j++)
            {
                for (int i = 0; i <= 3; i++)
                {
                     AverageTotalMarks = AverageTotalMarks + Marks[j, i]; 
                }
            }
            Console.WriteLine("The Total Mark for the class is:" + AverageTotalMarks/48);
			}      
  } 
}
    

