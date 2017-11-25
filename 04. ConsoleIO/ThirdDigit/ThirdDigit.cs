using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {


            Console.Write("Enter a valid intger number:\t");
            int number = int.Parse(Console.ReadLine());
            int quotient = number / 100;
            int thirdDigit = quotient % 10;

            if (thirdDigit==7)

            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False {0}" , thirdDigit);
            }
        



        }
    }
}
