using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("enter decimal integer: ");
        long deciNum = long.Parse(Console.ReadLine());

        int count = 0;
        long countDeciNum = deciNum;
        do
        {
            countDeciNum /= 16;
            count++;
        } while (countDeciNum >= 1);


        string str = null;
        long quotient = deciNum;
        long remainder = 0;
        for (int i = 1; i <= count; i++)
        {

            if (quotient % 16 == 10)
            {
                quotient /= 16;
                str += 'A';
            }
            else if (quotient % 16 == 11)
            {
                quotient /= 16;
                str += 'B';
            }
            else if (quotient % 16 == 12)
            {
                quotient /= 16;
                str += 'C';
            }
            else if (quotient % 16 == 13)
            {
                quotient /= 16;
                str += 'D';
            }
            else if (quotient % 16 == 14)
            {
                quotient /= 16;
                str += 'E';
            }
            else if (quotient % 16 == 15)
            {
                quotient /= 16;
                str += 'F';
            }
            else if (quotient % 16 < 10)
            {
                
                str += quotient % 16;
                quotient /= 16;

            }
        }
        string trueResult = null;

        for (int i = count-1; i >= 0; i--)
        {
            trueResult += str[i];
        }

        Console.WriteLine("\nIn HEX: {0}\n",trueResult);
    }
}

