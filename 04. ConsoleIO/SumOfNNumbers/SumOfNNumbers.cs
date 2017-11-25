using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int n;
            int k;
            int sumNNumbers = 0;

            Console.WriteLine("enter 'n' the number of members in the following range [1,200]");
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n <= 200 && n >= 1));
            Console.WriteLine("\n----------------\n");


            for (int i = 1; i <= n; i++)
            {

                k = int.Parse(Console.ReadLine());
                sumNNumbers += k;
            }
            Console.WriteLine("\nTotal sum:\t{0}",sumNNumbers);

        }
    }
}
