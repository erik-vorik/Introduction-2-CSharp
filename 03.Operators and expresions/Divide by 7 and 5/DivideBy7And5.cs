using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_7_and_5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(i % 35 == 0 ? "ДА, числото се дели на 5 и на 7 без остатък" : "НЕ, числото не се дели на 5 и на 7 без остатък");
            Console.WriteLine(i % 5 == 0 && i % 7 == 0);
        }
    }
}
