using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            //Part A
            //string EnterAPhrase, Vowel;
            //int num = 0;
            //Console.Write("Please enter a phrase: ");   
            //EnterAPhrase=Console.ReadLine();
            //for (int i = 0; i < EnterAPhrase.Length; i++) 
            //{
            //    Vowel = EnterAPhrase.Substring(i, 1);
            //    if (Vowel == "a" || Vowel == "e" || Vowel == "i" || Vowel == "o" || Vowel == "u")
            //        num = num + 1;
            //}
            // Console.WriteLine("Total number of vowels:" + num);

            //Part B
            string EnterAPhrase, Vowela,Vowele,Voweli,Vowelo,Vowelu;
            int numa=0, nume=0,numi=0,numo=0,numu= 0;
            Console.Write("Please enter a phrase: ");   
            EnterAPhrase=Console.ReadLine();
            for (int i = 0; i < EnterAPhrase.Length; i++)
            {
               Vowela=EnterAPhrase.Substring(i,1);
               if (Vowela == "a")
                   numa = numa+1;
               Vowele = EnterAPhrase.Substring(i, 1);
               if (Vowele == "e")
                   nume = nume+1;
               Voweli = EnterAPhrase.Substring(i, 1);
               if (Voweli == "i")
                   numi = numi + 1;
               Vowelo = EnterAPhrase.Substring(i, 1);
               if (Vowelo == "o")
                   numo = numo + 1;
               Vowelu = EnterAPhrase.Substring(i, 1);
               if (Vowelu == "u")
                   numu = numu + 1;
            }
            Console.WriteLine("Total number of a:" + numa);
            Console.WriteLine("Total number of e:" + nume);
            Console.WriteLine("Total number of i:" + numi);
            Console.WriteLine("Total number of o:" + numo);
            Console.WriteLine("Total number of u:" + numu);
        }
    }
}
