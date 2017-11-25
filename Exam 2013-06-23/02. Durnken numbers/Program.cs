using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _02.Durnken_numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("number of rounds: ");
            int rounds = int.Parse(Console.ReadLine());
            BigInteger[] drunkenNumber = new BigInteger[rounds];

            int mitko = 0;
            int vladko = 0;
            for (int i = 0; i < rounds; i++)
            {
                int digits = 0;
                BigInteger temp = 0;
                do
                {
                    digits = 0;
                    Console.Write("round {0}: ", (i + 1));
                    drunkenNumber[i] = BigInteger.Parse(Console.ReadLine());
                    temp = drunkenNumber[i];
                    while (temp != 0)
                    {
                        temp /= 10;
                        digits++;
                    }
                    if (digits>9)
                    {
                        Console.WriteLine("try again");
                    }
                } while (digits>9);
            }

            //processing each number from drunkenNummber array
            //
            List<int> beer = new List<int>();

            for (int j = 0; j < rounds; j++)
            {
                int remainder = 0;
                BigInteger tempDrunkNumb = drunkenNumber[j];
                do
                {
                    remainder =(int) tempDrunkNumb % 10;
                    beer.Add(remainder);
                    tempDrunkNumb /= 10;

                } while (tempDrunkNumb != 0);


                if (beer.Count % 2 != 0)                    //Odd count of digits
                {
                    int countOfIndexes = (beer.Count / 2) + 1;
                    for (int i = beer.Count - 1; i >= beer.Count - countOfIndexes; i--)
                    {
                        mitko += beer[i];
                    }
                    for (int i = 0; i < countOfIndexes; i++)
                    {
                        vladko += beer[i];
                    }
                }
                else                                        //Even count of digits
                {
                    int countOfIndexes = beer.Count / 2;
                    for (int i = beer.Count - 1; i >= beer.Count - countOfIndexes; i--)
                    {
                        mitko += beer[i];
                    }
                    for (int i = 0; i < countOfIndexes; i++)
                    {
                        vladko += beer[i];
                    }
                }
                beer.Clear();
            }

            //who is the drunk winner

            if (mitko > vladko)
            {
                Console.WriteLine(" M {0} beers", mitko);
            }
            else if (mitko < vladko)
            {
                Console.WriteLine(" V {0} beers", vladko);
            }
            else if (mitko == vladko)
            {
                Console.WriteLine("NO winner {0}", (mitko + vladko));
            }

        }

    }
}
