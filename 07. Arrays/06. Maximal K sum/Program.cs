using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int inputK = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)                     // initializing the 'numbers' list
            {                                               // w/ input fm the console
                numbers.Add(int.Parse(Console.ReadLine()))  ;
            }
            int maxValue = numbers[0];
            int sumMaxValues = 0;

            for (int k = 0; k < inputK; k++)
            {
                for (int i = 0, j = 1; j < n;)
                {
                    
                    if (numbers[i] < numbers[j] && numbers[j] > maxValue)
                    {
                        maxValue = numbers[j];
                        i = j;
                        j++;

                    }
                    else if (numbers[i] >= numbers[j])
                    {
                        j++;
                    }

                }
                numbers.Remove(maxValue);
                n--;
                sumMaxValues += maxValue;
                maxValue = 0;
            }
            Console.WriteLine("\n\n the sum of the 'k' numbers is  {0}", sumMaxValues);


        }
    }
}
