using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] Names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] Marks = new int[] { 63, 29, 75, 82, 55 };
            string TempNames;
            int Tempmarks = 0;

            for (int i = 0; i < Names.Length - 1; i++)
            {

                for (int j = i + 1; j < Names.Length; j++)
                {
                    if (Marks[i] < Marks[j])
                    {
                        //SWAP  process: 
                        Tempmarks = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = Tempmarks;

                        TempNames = Names[i];
                        Names[i] = Names[j];
                        Names[j] = TempNames;
                    }
                }
            }
            Console.WriteLine("Name\tMarks");
            Console.WriteLine("------------");

            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names[i] + "\t" + Marks[i]);
            }

            for (int i = 0; i < Names.Length - 1; i++)
            {
                for (int j = i + 1; j < Names.Length; j++)
                {
                    if (Names[i].CompareTo(Names[j]) == 1)
                    {
                        TempNames = Names[i];
                        Names[i] = Names[j];
                        Names[j] = TempNames;

                        Tempmarks = Marks[i];
                        Marks[i] = Marks[j];
                        Marks[j] = Tempmarks;
                    }
                }
            }

            Console.WriteLine("Name\tMarks");
            Console.WriteLine("------------");
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names[i] + "\t" + Marks[i]);
            }

        }
    }
}
