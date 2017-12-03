using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int n, m, i, j = 0;
            int k = 0;
            do
            {
                Console.Write("Enter 'n' [0,2000]:\t");
                n = int.Parse(Console.ReadLine());
            } while (!(n <= 2000 & n >= 0));

            do
            {
                Console.Write("Enter 'm' [n,2000]:\t");
                m = int.Parse(Console.ReadLine());
            } while (!(m <= 2000 & m >= n));

            for (i = n; i <= m; i++)
            {
               
                if (i % 5 == 0)
                {
                    j = ++k;
                }
                else {
                    ;
                }
            }
            Console.WriteLine("Числата делими на '5' без остатък са : \t {0}",j);
        }
    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int m = int.Parse(Console.ReadLine());
//        int count = 0;
//        while (m - n > 1 && n >= 0 && m > 0)
//        {
//            n++;
//            if (n % 5 == 0)
//            {
//                count++;
//            }
//        }
//        Console.WriteLine(count);
//    }
//}

