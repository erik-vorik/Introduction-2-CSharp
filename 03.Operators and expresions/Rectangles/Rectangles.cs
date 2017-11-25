using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Периметъра на правоъгълника е :  " + (a + b) * 2);
            Console.WriteLine("Лицето на правоъгълника е :  " + (a * b));
        }
    }
}
