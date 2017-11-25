using System;


class Program
{
    static void Main()
    {
        string typeVar = Console.ReadLine();

        switch (typeVar)
        {
            case "double":
            case "integer":
                double var = double.Parse(Console.ReadLine());
                Console.WriteLine("\n" + (++var));

                break;
            case "string":
                string str = Console.ReadLine();
                Console.WriteLine("\n" + str + "*");
                break;
            default:
                Console.WriteLine("invalid input");
                break;
        }























        //if ( typeVar == "double")
        //{
        //    double num = double.Parse(Console.ReadLine());
        //    num++;
        //    Console.WriteLine("\n" + num);
        //}
        //else if (typeVar == "integer")
        //{
        //    double num = double.Parse(Console.ReadLine());
        //    num++;
        //    Console.WriteLine("\n" + num);
        //}
        //else if (typeVar == "string")
        //{
        //    string str = Console.ReadLine();
        //    Console.WriteLine("\n" + str + "*");
        //}
        //else
        //{

        //}
    }

}

