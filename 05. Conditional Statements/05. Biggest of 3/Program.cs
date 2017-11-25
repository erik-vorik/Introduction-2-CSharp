using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a>=b && a>=c)
        {
            Console.WriteLine("biggest is 'a' = {0}", a);
        }
       else if (b>=a && b>=c)
        {
            Console.WriteLine("biggest is 'b' = {0}", b);

        }
        else if (c>=a && c>=b) 
        {
            Console.WriteLine("biggest is 'c' = {0}", c);

        }





    }
}

