using System;



    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter number");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Convert.ToString(number1);
            Console.WriteLine("\n \n");
            Console.WriteLine(string.Format("{0:0.000000}", number1) + " това е търсеното число с точност 0.000001");
        }
    }

