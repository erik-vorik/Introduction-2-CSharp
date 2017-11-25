using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("first array of chars: ");
            string charArrayOne = Console.ReadLine();
            Console.Write("second array of chars: ");
            string charArrayTwo = Console.ReadLine();
            bool areLenghtsEqual = true;
            bool areCharsEqual = true;
            int lenght = 0;


            //lenght of arrays comparisson
            if (charArrayOne.Length != charArrayTwo.Length)
            {
                areLenghtsEqual = false;

            }
            else
            {
                lenght = charArrayOne.Length;
            }


            for (int i = 0; i < lenght && areLenghtsEqual == true; i++)
            {
                if (charArrayOne[i] != charArrayTwo[i])
                {
                    areCharsEqual = false;
                    break;
                }
            }


            if (areCharsEqual == true && areLenghtsEqual==true)
            {
                Console.WriteLine("\n=\n");
            }
            else if (areLenghtsEqual == false)
            {
                if (charArrayOne.Length > charArrayTwo.Length)
                {
                    Console.WriteLine("\n>\n");
                }
                else
                {
                    Console.WriteLine("\n<\n");
                }
            }
        }
    }
}

