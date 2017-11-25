using System;



    class Program
    {
        static void Main()
    {
        Console.Write("Въведете A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Въведете B: ");
        double b = double.Parse(Console.ReadLine());


        if (a>b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("{0} e A", a);
        Console.WriteLine("{0} e B", b);

    }
}

