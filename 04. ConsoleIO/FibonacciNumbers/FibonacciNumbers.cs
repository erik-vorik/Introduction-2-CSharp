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
//using System;

//class Program
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        long a = 0;
//        long b = 1;
//        Console.Write(a);
//        long member = b;
//        for (int i = 0; i < n - 1; i++)
//        {
//            Console.Write(", ");
//            Console.Write(member);
//            member = a + b;
//            if (a < b)
//            {
//                a = member;
//            }
//            else if (a > b)
//            {
//                b = member;
//            }
//            else if (a == b)
//            {
//                a = member;
//            }
//        }
//    }
//}
