using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Mixing_numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("count of 2-digit numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} of {1}: ", i + 1, n);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int[] mixedNumbers = new int[n - 1];
            int[] subtractedNumbers = new int[n - 1];
            for (int i = 0, j = 1; i < n - 1; i++, j++)
            {
                mixedNumbers[i] = (numbers[i] % 10) * (numbers[j] / 10);
                if (numbers[i] - numbers[j] > 0)
                {
                    subtractedNumbers[i] = numbers[i] - numbers[j];
                }
                else
                {
                    subtractedNumbers[i] = -1 * (numbers[i] - numbers[j]);
                }
            }


            foreach (var item in mixedNumbers)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            foreach (var item in subtractedNumbers)
            {
                Console.Write("{0} ", item);
            }

            //Console.WriteLine(String.Join(" ", mixedNumbers));

            //Console.WriteLine(String.Join(" ", subtractedNumbers));
        }
    }
}
