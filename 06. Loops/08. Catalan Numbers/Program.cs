using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n;
        BigInteger factorial = 1;
        BigInteger BigFactorial = 1;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (!(n > 1 && n < 100));
        for (int i = 1, j = 1; j <= (2 * n); i++,j++)
        {
            BigFactorial *= j;
            if (i <= n)
            {
                factorial *= i;

            }

        }
      
       
        BigInteger result = BigFactorial / ((factorial * factorial)*(n+1));
        Console.WriteLine(result);
    }
}

