using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_digit
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            num = num / 100;
            int num1 = num % 10;

            Console.WriteLine(num1 == 7 ? "да, 3то число отдясно наляво числото е 7" : "Не,3то число отдясно наляво числото НЕ е 7 ");

        }
    }
}
