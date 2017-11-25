using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class EvenOrOdd
    {
        static void Main()
        {
          int num = Convert.ToInt32(Console.ReadLine());
          string k = num % 2 == 0 ? "EVEN" : "ODD";
          Console.WriteLine(num + " is " + k);
           //вариант 2 
           // int i = int.Parse(Console.ReadLine());
           // Console.WriteLine (((i & 1) == 1) ? " Odd" : " Even");
        }
    }
}
