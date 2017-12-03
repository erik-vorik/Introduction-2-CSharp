using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
                        Console.Write("Enter radius:\t");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = Math.PI * 2 * r;
            Console.WriteLine("Cirle area:\t{0:0.00}    Circle perimeter:\t{1:0.00}", area,perimeter);
        }
    }
}
//using System;

//    class Program
//{
//    static void Main()
//    {
//        float r = float.Parse(Console.ReadLine());
//        float circumference = (float)(2 * Math.PI * r);
//        float area = (float)Math.PI * r * r;
//        Console.WriteLine("{0:f2} {1:f2}", circumference, area);
//    }
//}

