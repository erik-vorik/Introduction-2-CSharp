using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatingNumbers
{
    class FormatingNumbers
    {
        static void Main()
        {
            //----------------Букви--------------
            string aLetter = "a".PadLeft(5);
            string bLetter = "b".PadLeft(5);
            string cLetter = "c".PadLeft(5);
            string resultWord = "result".PadLeft(5);
            int a;
            float b;
            float c;
            string aPrint;
            string bPrint;
            string cPrint;
            string aPrintHex;



            Console.Write("Please enter integer 'a' between 0 and 500:\t");
            do
            {
                a = int.Parse(Console.ReadLine());
                aPrint = Convert.ToString(a);
            } while (!(a >= 0 && a <= 500));
            aPrintHex = Convert.ToString(a, 16);
            Console.WriteLine(aPrintHex);

            Console.Write("Please enter real number 'b':\t");
            b = float.Parse(Console.ReadLine());
            bPrint = Convert.ToString(b).PadLeft(10, '0');


            Console.Write("Please enter real number 'c':\t");
            c = float.Parse(Console.ReadLine());
            cPrint = Convert.ToString(c);

            Console.WriteLine("{0,-10} |{1,-10} | {2,-10} | {3,-10}", aLetter, bLetter, cLetter, resultWord);
            Console.WriteLine("{0,-10} |{1,-10} | {2,-10} | {3,-10}", aPrintHex, bPrint, cPrint, a + b + c);
            Console.WriteLine("{0,-10:x} |{1,-10:2} | {2,-10:0.00} | {3,-10:8}", a, bPrint, c, a + b + c);

        }
    }
}