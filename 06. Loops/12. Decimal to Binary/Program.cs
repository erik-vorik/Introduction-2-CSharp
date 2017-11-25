using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




class Program
{
    static void Main()
    {
        int count = 1;
        Console.Write("enter decimal integer: ");
        long deciNum = long.Parse(Console.ReadLine());
        long countQuotient = deciNum / 2;
        string intermediateResult = null;
        do
        {
            countQuotient /= 2;
            count++;
        } while (countQuotient != 1);


        long tempQuot = deciNum;

        for (int i = 0; i <= count; i++)                       // може да се оптимизира като на мястото
                                                               // на условието поставим tempQuot >= 1
        {                                                      // в бодито поставяме count++
            if (tempQuot % 2 == 1)                             // и по този начин Do-while става ненужен
            {                                                 
                tempQuot /= 2;                                
                intermediateResult += 1;
            }
            else if (tempQuot % 2 == 0)
            {
                tempQuot /= 2;
                intermediateResult += 0;
            }
        }

        string resultFinal=null;

        for (int i = count; i >= 0; i--)
        {
            resultFinal += intermediateResult[i];
        }


        //Console.WriteLine(count);
        Console.WriteLine(resultFinal);
    }
}

