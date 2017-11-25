using System;

class Program
{
    static void Main()
    {
        int n, k;
        int nFactorial = 1, kFactorial = 1;

        do
        {
            Console.WriteLine("enter 'n': ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 'k' smaller than 'n': ");
            k = int.Parse(Console.ReadLine());
           
        } while (!(k > 1 && k<n && n < 100));

       

        for (int i = 1; i <= n; i++)
        {

            nFactorial *= i;
        }
        for (int i = 1; i <= k; i++)
        {

            kFactorial *= i;
        }
        Console.WriteLine("result= " + (nFactorial / kFactorial));
    }
}