using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Моля задайте стойността на основа 'a'");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Моля задайте стойността на основа 'b'");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Моля задайте стойността на височината 'h'");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на трапеца е :" + "" + (a + b) * h / 2);
        }
    }
}
