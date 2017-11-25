using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComprarer
{
    class NumberComprarer
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");
            Console.WriteLine (num1 > num2 ? num1 : num2);
        }
    }
}
