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
            Console.Write("Please enter a sentence or phrase: ");
            string sentence = Console.ReadLine();
            string newSentence = "";
            bool toUpper = true;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (toUpper)
                {
                    newSentence += char.ToUpper(sentence[i]);
                    toUpper = false;
                }
                else 
                {
                    newSentence += sentence[i];
                }
                if (sentence[i] == ' ')
                    toUpper = true;
            }
            Console.WriteLine(newSentence);
        }
    }
}
