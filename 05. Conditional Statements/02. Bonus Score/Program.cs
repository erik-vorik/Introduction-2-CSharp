using System;



class Program
{
    static void Main()
    {
        int scoreInitial = int.Parse(Console.ReadLine());


        if (scoreInitial >= 1 && scoreInitial <= 3)
        {
            Console.WriteLine("Your score is : " + scoreInitial * 10);
        }
        else if (scoreInitial >= 4 && scoreInitial <= 6)
        {
            Console.WriteLine("Your score is : " + scoreInitial * 100);
        }
        else if (scoreInitial >= 7 && scoreInitial <= 9)
        {
            Console.WriteLine("Your score is : " + scoreInitial * 1000);
        }
    }
}

