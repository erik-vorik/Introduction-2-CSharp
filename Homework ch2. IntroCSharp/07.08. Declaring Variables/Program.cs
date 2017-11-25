using System;



class Program
{
    static void Main()
    {
        string hello = "hello";
        string world = "world";
        object concatenation = hello + " " + world;
        Console.WriteLine(concatenation);
        string castvane = (string)concatenation;
        Console.WriteLine(castvane);
    }
}

