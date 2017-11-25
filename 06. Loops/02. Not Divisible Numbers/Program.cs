using System;


class Program
{
    static void Main()
    {
        bool numBool;
        int num=0;
        int t = 1;
        do
        {
            Console.WriteLine("Enter integer in the range [1,1500]");
            numBool = int.TryParse(Console.ReadLine(), out t);
            if (numBool == true)
            {
                num = t;
            }
        } while (!((num >= 1 && num <= 1500) && numBool));



        for (int i = 1; i <= num; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}

