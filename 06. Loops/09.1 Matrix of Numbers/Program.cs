using System;

class Program
{
    static void Main()
    {
        int n, j = 1;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (!(n > 1 && n < 20));

        for (int i = 1; i <= n; i++)
        {
            for (int count = 1; count <= n; j++, count++)
            {

                Console.Write(j);
                if (count == n)
                {
                    Console.WriteLine();
                }

            }
            j = i + 1;
        }
    }
}
