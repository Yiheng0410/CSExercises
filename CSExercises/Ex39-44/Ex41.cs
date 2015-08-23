using System;
namespace CSExercises
{
    public class Ex41
    {

        public static void Main(string[] args)
        {
            string Enter1, Enter2;
            Console.Write("Pls enter the first word: " );
            Enter1 = Convert.ToString(Console.ReadLine());
            Console.Write("Pls enter the second word: " );
            Enter2 = Convert.ToString(Console.ReadLine());
            if (InString(Enter1,Enter2))
            {
                Console.WriteLine("Occur");
            }
            else
            {
                Console.WriteLine("Not Occur");
            }

        }
        public static bool InString(string s1, string s2)
        {
       
            if (s1.Length < s2.Length)//if s1 is shoter than s2, s2 won't be able to occur s1.
            {
                return false;
            }
            else 
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)// s1 is equal or longer than s2, then the exit point of the loop should be at the length of s2
                {
                    if (s1.Substring(i, s2.Length) == s2)// s1=wcabc s2=abc
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
