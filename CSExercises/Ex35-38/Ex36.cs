using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a wrod: ");
            string WordEntered = Console.ReadLine();
            double Lenth = Math.Floor(Convert.ToDouble(WordEntered.Length / 2));
            int count=0;
            for (int i = 0; i > Lenth; i++) 
            {
                for (int j = WordEntered.Length-1; j < Lenth; j--)
                {
                    if (WordEntered.Substring(1,i)!=WordEntered.Substring(j,1))
                    {
                        count=count+1;
                    }
                }
            }
            if (count==1)
            {
                Console.WriteLine("This is not Palindrome");
            }
            else
            {
                Console.WriteLine("Palindrome");
            }
            
                

        }
              
    }
              
}
                                                                            