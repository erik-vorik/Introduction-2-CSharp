using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Going_to_a_party
{
    class Program
    {
        static void Main()
        {
            ///input
            Console.Write("the directions: ");
            string input = Console.ReadLine();
            ///body
            for (int i = 0; i < input.Length;)
            {
                if (Convert.ToInt32(input[i]) > 64 && Convert.ToInt32(input[i]) < 91)
                {
                    i -= Convert.ToInt32(input[i]) - 64;  ///// step backwards

                }
                else if (Convert.ToInt32(input[i]) > 96 && Convert.ToInt32(input[i]) < 123)
                {
                    i += Convert.ToInt32(input[i]) - 96;   ///// step forw'd
                }
                else if (input[i] == '^')
                {                                         ///// PARTY
                    Console.WriteLine("Djor i Djano are at the PARTY at {0}", i);
                    break;
                }
                if (i < 0 || i >= input.Length)
                {                                         ///// LOST
                    Console.WriteLine("They are LOST at {0}",i);
                    break;
                }
            }


        }
    }
}
