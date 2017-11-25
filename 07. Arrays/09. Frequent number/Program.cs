using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int mostFreqNumber=0;
            int maxTimeSeenNumber = 0;
            for (int j = 0; j < n; j++)
            {
                int timeSeenNumber = 1;
                int number = array[j];
                for (int i = j + 1; i < n; i++)
                {
                    if (array[j] == array[i])
                    {
                        timeSeenNumber++;
                        if (timeSeenNumber>maxTimeSeenNumber)
                        {
                            maxTimeSeenNumber = timeSeenNumber;
                            mostFreqNumber = number;
                        }
                    }
                }
            }
            Console.WriteLine("\n\n{0}({1} times)",mostFreqNumber,maxTimeSeenNumber);

        }
    }
}
