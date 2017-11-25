using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {

            int a;
            int b;
            int c;
            int d;
            int e;

            do
            {
                Console.Write("Please enter a value of 'a' [-1000,1000]: \t");
                a = int.Parse(Console.ReadLine());
            } while (!(a <= 1000 && a >= -1000));


            do
            {
                Console.Write("Please enter a value of 'b' [-1000,1000]: \t");
                b = int.Parse(Console.ReadLine());
            } while (!(b <= 1000 && b >= -1000));


            do
            {
                Console.Write("Please enter a value of 'c' [-1000,1000]: \t");
                c = int.Parse(Console.ReadLine());
            } while (!(c <= 1000 && c >= -1000));


            do
            {
                Console.Write("Please enter a value of 'd' [-1000,1000]: \t");
                d = int.Parse(Console.ReadLine());
            } while (!(d <= 1000 && d >= -1000));


            do
            {
                Console.Write("Please enter a value of 'e' [-1000,1000]: \t");
                e = int.Parse(Console.ReadLine());
            } while (!(e <= 1000 && e >= -1000));
            Console.WriteLine("\n\n");
            int sum = a + b + c + d + e;
            Console.WriteLine("{0,50}",sum);


        }
    }
}
