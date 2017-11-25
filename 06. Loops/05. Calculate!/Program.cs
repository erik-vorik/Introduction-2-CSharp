using System;

class Program
{
    static void Main()
    {
        int farcorial = 1;
        float xPower = 1;
        float sum = 1;
        int N = int.Parse(Console.ReadLine());
        float x = float.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            farcorial *= (i);



            xPower *= x;

            sum += farcorial / xPower;


        }
        Console.WriteLine(sum);
    }

}

//S = 1 + 1!/x + 2!/x2 + … + N!/xN.