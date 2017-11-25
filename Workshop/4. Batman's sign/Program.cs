using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        char c = (char)int.Parse(Console.ReadLine());
        //--------------A--------------
        int rowsA = 2;
        if (s > 5)
        {
            rowsA += (s - 5) / 2;
        }
        for (int i = 0; i < rowsA; i++)
        {
            for (int k = 0; k < i; k++) // indenting
            {
                Console.Write(' ');
            }
            for (int k = 0; k < s - i; k++)  // left wing
            {
                Console.Write(c);
            }
            if (i != rowsA - 1)
            {
                for (int k = 0; k < s; k++)  //mid part
                {
                    Console.Write(' ');
                }
            }
            else
            {
                for (int k = 0; k < rowsA - 1; k++)
                {
                    Console.Write(' ');
                }
                Console.Write("{0} {0}", c);
                for (int k = 0; k < rowsA - 1; k++)
                {
                    Console.Write(' ');
                }
            }
            for (int k = 0; k < s - i; k++)  // right wing
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        //----------------B--------------
        int rowsB = rowsA - 1;
        for (int i = 0; i < rowsB; i++)
        {
            for (int k = 0; k < rowsA; k++)
            {
                Console.Write(' ');
            }
            for (int k = 0; k < 2 * s + 1; k++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        //----------------C--------------
        int rowsC = rowsA;
        int colsC = s - 2;
        for (int i = 0; i < rowsC; i++)
        {
            for (int k = 0; k < s + 1 + i; k++) // indenting
            {
                Console.Write(' ');
            }
            for (int k = 0; k < colsC - (2 * i); k++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}

