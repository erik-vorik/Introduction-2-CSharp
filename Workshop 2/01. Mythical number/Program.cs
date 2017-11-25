using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Mythical_number
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter a 3 digit number: ");
            int n = int.Parse(Console.ReadLine());
            float thirdDigit = n % 10;
            float secondDigit = (n / 10)%10;
            float firstDigit = n/100;
            float result=0;
           
            if (thirdDigit == 0)
            {
                result = secondDigit * firstDigit;
            }
            else if (thirdDigit > 0 && thirdDigit <= 5)
            {
                result = firstDigit * secondDigit / thirdDigit;
            }
            else if (thirdDigit>5)
            {
                result = (firstDigit + secondDigit) * thirdDigit;
            }
            Console.WriteLine("\n\n{0:f2}",result);
        }
    }
}

