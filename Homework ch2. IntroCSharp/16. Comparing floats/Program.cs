using System;


class Program
{
    static void Main()
    {
        char input= (char)Console.Read();
        Console.WriteLine(input);
       
        float f = 1.23f;
      Console.WriteLine("{0:0.#8#}", f);
        Console.WriteLine(Convert.ToInt32("10000010",2));
        Console.WriteLine(Convert.ToString(16|3,2));

        int rem = 11 % -3;
        double d = 0.1 + 0.2;
        Console.WriteLine("{0:R}",d);
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Abs(a - b) + "<= 0.000001");
        if (Math.Abs(a - b) <= 0.000001)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        //string isEqual = Math.Abs(a - b) <= 0.000001 ? "true" : "false";
        //Console.WriteLine(isEqual);
    }
}

