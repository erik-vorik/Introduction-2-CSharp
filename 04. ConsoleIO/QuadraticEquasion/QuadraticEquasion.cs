using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquasion
{
    class QuadraticEquasion
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x;

            if (a == 0)
            {
                Console.WriteLine("коефициента 'а' не може да е 0");
            }
            else
            {
                double d = (b * b) - (4 * a * c);
                if (d < 0)
                    Console.WriteLine("Няма реални корени");
                else
                {
                    if (d > 0)
                    {
                        Console.WriteLine("Има 2 реални корена");
                        Console.WriteLine("x1={0}", ((-b + Math.Sqrt(d)) / (2 * a)));
                        Console.WriteLine("x2={0}", ((-b - Math.Sqrt(d)) / (2 * a)));
                    }
                    else
                        Console.WriteLine("x={0}", -b / 2 * a);



                }
                Console.Read();
            }

            // ax*x + b*x + c = 0
            // d = b*b -4*a*c
            // x1 = ((-b - math.sqrt(d))/2)
            // x2 = (-(-b - math.sqrt(d))/2)

        }
    }
}
