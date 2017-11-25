using System;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.WriteLine("Enter 'n': ");
            n = int.Parse(Console.ReadLine());
        } while (n < 4 || n > 50);   /* (!(n>=4 && n<=50))*/

        int oddProduct = 1, evenProduct = 1;
        char ch;
        string stringChars = null;

        Console.WriteLine("please enter integers, each sperated by space: ");
        string str = Console.ReadLine();




        for (int i = 0, countSpace = 0; i < str.Length && countSpace < n; i++)
        {
            ch = str[i];
            if (ch != 32)
            {
                stringChars += ch;
            }
            else if (ch == 32)
            {
                ++countSpace;


                if (countSpace % 2 == 1)
                {
                    oddProduct *= int.Parse(stringChars);
                }
                else
                {
                    evenProduct *= int.Parse(stringChars);
                }
                stringChars = null;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("No {0} {1}", oddProduct, evenProduct);
        }


        // Console.WriteLine("Product of Odds: "+ oddProduct + "\nProduct of Evens: " + evenProduct);


    }
}

