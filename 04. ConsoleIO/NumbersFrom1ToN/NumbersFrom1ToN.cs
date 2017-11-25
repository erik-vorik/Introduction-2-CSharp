using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (!(n <= 1000000 && n >= 1));

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("\n" + i);
            }
            Console.ReadLine();
        }
    }
}
