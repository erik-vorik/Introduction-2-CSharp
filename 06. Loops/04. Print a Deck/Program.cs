using System;


class Program
{
    static void Main()
    {
        while (true)
        {


            string input;
            do
            {
                Console.WriteLine("Please enter a valid play card sign");
                input = Console.ReadLine();
            } while (!(input != "2" ||
                                input != "3" ||
                                input != "4" ||
                                input != "5" ||
                                input != "6" ||
                                input != "7" ||
                                input != "8" ||
                                input != "9" ||
                                input != "10" ||
                                input != "j" ||
                                input != "q" ||
                                input != "k" ||
                                input != "a"));


            switch (input)
            {
                case "2": Console.WriteLine("2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds"); break;
                case "3": Console.WriteLine("3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds"); break;
                case "4": Console.WriteLine("4 of spades, 4 of clubs, 4 of hearts, 4 of diamonds"); break;
                case "5": Console.WriteLine("5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds"); break;
                case "6": Console.WriteLine("6 of spades, 6 of clubs, 6 of hearts, 6 of diamonds"); break;
                case "7": Console.WriteLine("7 of spades, 7 of clubs, 7 of hearts, 7 of diamonds"); break;
                case "8": Console.WriteLine("8 of spades, 8 of clubs, 8 of hearts, 8 of diamonds"); break;
                case "9": Console.WriteLine("9 of spades, 9 of clubs, 9 of hearts, 9 of diamonds"); break;
                case "10": Console.WriteLine("10  of spades, 10  of clubs, 10  of hearts, 10 of diamonds"); break;
                case "j": Console.WriteLine("Jack of spades, Jack of clubs, Jack of hearts, Jack of diamonds"); break;
                case "q": Console.WriteLine("Queen of spades, Queen of clubs, Queen of hearts, Queen of diamonds"); break;
                case "k": Console.WriteLine("King of spades, King of clubs, King of hearts, King of diamonds"); break;
                case "a": Console.WriteLine("Ace of spades, Ace of clubs, Ace of hearts, Ace of diamonds"); break;



                default:


                    break;
            }


        }
    }
}

