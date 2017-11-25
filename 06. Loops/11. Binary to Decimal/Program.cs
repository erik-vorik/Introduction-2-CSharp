using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        Console.Write("please enter binary integer : ");
        string strBinrary = Console.ReadLine();
        long result = 0;

        for (int i = strBinrary.Length - 1; i >= 0; i--)
        {
            if (strBinrary[i] == '1')
            {
                int power = 1;

                for (int j = 1; j <= strBinrary.Length - 1 - i; j++)
                {
                    power = power * 2;
                }
                result += power;
            }
            else if (strBinrary[i] == '0')
            {

            }
        }

        Console.WriteLine(result);








    }
}

