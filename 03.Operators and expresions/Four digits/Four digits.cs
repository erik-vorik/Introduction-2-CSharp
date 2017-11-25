using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_digits
{
    class Program
    {
        static void Main()
        {
            int fourDigitNum = int.Parse(Console.ReadLine());
            int d = fourDigitNum % 10;
            int c = (fourDigitNum / 10) % 10;
            int b = (fourDigitNum / 100) % 10;
            int a = (fourDigitNum / 1000) % 10;
            Console.WriteLine("Сумата от четирите цифри" + " " + (a + b + c + d));
            Console.WriteLine("Обратен ред на отпечатване на цифрите" + " " + d + c + b + a);
            Console.WriteLine("Смяна на местата на 1-та с 4-та цифри" + " " + d + b + c + a);
            Console.WriteLine("Смяна на местата на 2-та с 3-та цифри " + " " + a + c + b + d);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine((a+b+c+d));
            //string strA = Convert.ToString(a);
            //string strB = Convert.ToString(b);
            //string strC = Convert.ToString(c);
            //string strD = Convert.ToString(d);
            //Console.WriteLine(strD+strC+strB+strA);
            //Console.WriteLine(strD+strB+strC+strA);
            //Console.WriteLine(strA+strC+strB+strD);
        }
    }
}
