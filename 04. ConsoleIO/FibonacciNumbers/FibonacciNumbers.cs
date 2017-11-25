using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int i;
            int a = 0;
            int b = 1;
            int c = 0;
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write("{0} , ",c);
            }









            // int temp = a;
            // a = b;
            // b = temp + b;
            // Console.Write("{0},",i + (++i) );
            //}
            //Console.WriteLine("\n\n");
            //}
        }
    }
}
