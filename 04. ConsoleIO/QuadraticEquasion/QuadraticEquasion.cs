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
//using System;

//    class Program
//{
//    static void Main()
//    {
//        double a = double.Parse(Console.ReadLine());
//        double b = double.Parse(Console.ReadLine());
//        double c = double.Parse(Console.ReadLine());
//        double D = (b * b) - 4 * a * c;
//        if (D < 0)
//        {
//            Console.WriteLine("no real roots");
//        }
//        else if (D == 0)
//        {
//            Console.WriteLine("{0:f2}", -b / (2 * a));
//        }
//        else if (D > 0)
//        {
//            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
//            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
//            if (x1 < x2)
//            {
//                Console.WriteLine("{0:f2}\n{1:f2}", x1, x2);
//            }
//            else
//            {
//                Console.WriteLine("{0:f2}\n{1:f2}", x2, x1);
//            }
//        }
//    }

//}


