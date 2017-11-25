using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Magical_number
{
    class Program
    {
        static void Main()
        {
            float result;
            Console.Write("enter 3 digits: ");
            string input = Console.ReadLine();
            float firstDig = Convert.ToInt32(input[0] - 48);
            int secondDig = Convert.ToInt32(input[1] - 48);
            int thirdDig = Convert.ToInt32(input[2] - 48);
            if (secondDig % 2 == 0)
            {
                result = (firstDig + secondDig) * thirdDig;
            }
            else
            {
                result = (firstDig * secondDig) / thirdDig;
            }

            Console.WriteLine("{0:f2}",result);
        }
    }
}
