using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string Inputsentence, FirstCharaters, MakeUpperCase;
            Console.Write("Pls enter a sentence: ");
            Inputsentence = Console.ReadLine();
            MakeUpperCase = Inputsentence.Substring(0, 1);
            MakeUpperCase = MakeUpperCase.ToUpper();
            char[] EachCharacters = new char[Inputsentence.Length];
            EachCharacters[0] = Convert.ToChar(MakeUpperCase);
            for (int i = 0; i < Inputsentence.Length; i++)
            {
                FirstCharaters = Inputsentence.Substring(i, 1);
                if (i == Inputsentence.Length - 1)
                {
                    MakeUpperCase = FirstCharaters;
                }
                else
                    MakeUpperCase = Inputsentence.Substring(i + 1, 1);
                EachCharacters[i] = Convert.ToChar(MakeUpperCase);
                if (MakeUpperCase == "" && FirstCharaters != "")
                {
                    MakeUpperCase = MakeUpperCase.ToUpper();
                    EachCharacters[i + 1] = Convert.ToChar(MakeUpperCase);
                    i++;
                }
            }

            for (int i = 0; i < Inputsentence.Length; i++)
            {
                Console.Write(EachCharacters[i]);
            }

        }
    }
}
