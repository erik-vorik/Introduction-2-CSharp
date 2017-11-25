using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.Write("enter a HEX number: ");
        string hexString = Console.ReadLine();
        int count = 0;
        foreach (var n in hexString)
        {
            count++;
        }
        long hexInt = 0;
        long pow = 1;
        for (int i = count - 1; i >= 0; i--)
        {

            if (i != count - 1)
            {
                pow *= 16;
            }

            switch (hexString[i])
            {
                case 'A':
                case 'a':
                    hexInt += pow * 10; break;
                case 'B':
                case 'b':
                    hexInt += pow * 11; break;
                case 'C':
                case 'c':
                    hexInt += pow * 12; break;
                case 'D':
                case 'd':
                    hexInt += pow * 13; break;
                case 'E':
                case 'e':
                    hexInt += pow * 14; break;
                case 'F':
                case 'f':
                    hexInt += pow * 15; break;


                default:
                    hexInt += pow * long.Parse(Convert.ToString(hexString[i])); break;
            }


        }
        Console.WriteLine("\n\n\nhex {1} is decimal {0}\n", hexInt, hexString);









    }
}

