using System;
namespace CSExercises
{
    public class Ex42
    {

        public static void Main(string[] args)
        {
            string Enter1, Enter2;
            Console.Write("Pls enter the first word: ");
            Enter1 = Convert.ToString(Console.ReadLine());
            Console.Write("Pls enter the second word: ");
            Enter2 = Convert.ToString(Console.ReadLine());
            if (FindWord(Enter1, Enter2) == -1)
            {
                Console.WriteLine("-1"); 
            }
            else
            {
                Console.WriteLine("Occurrence Started at No. " + FindWord(Enter1, Enter2) + "  position in the first word.");
            }
        }

        public static int FindWord(string s1, string s2)
        {
            int indicator;
            if (s1.Length < s2.Length)
            {
                indicator = -1;
                return indicator;
            }
            else
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)
                    if (s1.Substring(i, s2.Length) == s2)
                    {
                        indicator = i + 1;
                        return indicator;
                    }
            }
            return -1;
        }

    }
}
