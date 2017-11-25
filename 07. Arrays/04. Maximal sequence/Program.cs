using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());

            //declaring the input array and the result arrays
            int[] numbers = new int[arrayLenght];
            int[] result = new int[arrayLenght];

            //initializing the input array
            for (int i = 0; i < arrayLenght; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayLenght; i++)
            {
                for (int j = i + 1, timesOccured = 1; j < arrayLenght; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        result[i] = ++timesOccured;
                    }
                }
            }

            int bigger = 0;
            for (int i = 0; i < arrayLenght; i++)
            {
                if (bigger < result[i])
                {
                    bigger = result[i];
                }
            }

            Console.WriteLine("\n\n{0}", bigger );
        }
    }
}
