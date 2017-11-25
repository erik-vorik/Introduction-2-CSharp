using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main()
        {
            //initializing the input string
            Console.Write("enter single word with lowercases: ");
            string word = Console.ReadLine();
            //initializing alphabet array w/ lower cases + result array 
            int[] alphabet = new int[26];
            for (int i = 0; i < 26; i++)
            {
                alphabet[i] = 97 + i;
            }
            int[] result = new int[word.Length];

            // body
            for (int wordIndex = 0; wordIndex < word.Length; wordIndex++)
            {
                for (int alphabetIndex = 0; alphabetIndex < alphabet.Length; alphabetIndex++)
                {// comparing each letter of 'word' 
                 // against 'alphabet' elements
                    if (word[wordIndex]==alphabet[alphabetIndex])
                    {
                        result[wordIndex] = alphabetIndex;
                    }
                }
            }

            //printing the result

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(result[i]);
            }


        }
    }
}
