using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Check
{
    class Program
    {
        static void Main()
        {
            bool isPrime = true;
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                Console.WriteLine("\n\nРезултат при i=" + i);
                if (n % i != 0)
                {
                    Console.WriteLine("числото е с остатък");
                    Console.WriteLine("Вероятно е ПРОСТО ЧИСЛО  " + isPrime + "\n");
                }

                else
                {
                    Console.WriteLine("числото е без остатък. НЕ Е ПРОСТО ЧИСЛО !");
                    isPrime = false;
                }
            }

           // Console.WriteLine("\n" + "Накрая isPrime e:  " + isPrime);
            if (isPrime == true)
                Console.WriteLine(n + " " + "числото е ПРОСТО");
            else
                Console.WriteLine(n + " " + "НЕ Е ПРОСТО");
        }
    }
}
