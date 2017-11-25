using System;


    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b + "\n \n \n");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }

