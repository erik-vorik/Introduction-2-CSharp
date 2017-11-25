using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("въведете 1то реално число: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("въведете 2то реално число: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("въведете 3то реално число: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("получава се следния израз :  {0} + {1} + {2} = {3}\t", a, b, c, a + b + c);



    }
}

