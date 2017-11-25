using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (a >= b && a >= c)
        {
            Console.Write(a + " ");
            if (b >= c)
            {
                Console.Write("{0}" + " " + "{1}\n", b, c);
            }
            else
            {
                Console.Write("{0}" + " " + "{1}\n", c, b);
            }



        }
        else if (b >= a && b >= c)
        {
            Console.Write(b+ " ");
            if (a >= c)
            {
                Console.Write("{0}" + " " + "{1}\n", a, c);
            }
            else
            {
                Console.Write("{0}" + " " + "{1}\n", c, a);

            }
        }
        else if (c >= a && c >= b)
        {
            Console.Write(c+ " ");
            if (a >= b)
            {
                Console.Write("{0}" + " " + "{1}\n", a, b);
            }
            else
            {
                Console.Write("{0}" + " " + "{1}\n", b, a);
            }

        }
    }
}

