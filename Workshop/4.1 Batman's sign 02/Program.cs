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
        for (int row = 0; row < rowsA; row++)
        {
            for (int col = 0; col < 3 * s; col++)
            {
                if (col < row                  //left indent
                    || 3 * s - 1 - row < col   // right cut-out
                    || (row != rowsA - 1 && (s <= col && col < s * 2))
                    || (row == rowsA - 1 && (s <= col && col < s * 2) && col != s + rowsA - 1 && col != s + rowsA + 1)
                    )// mid gap
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(c);
                }
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

