using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merging_numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("number of 2-digit numbers: ");
            int n = int.Parse(Console.ReadLine());        // count of 2-digit numbers
            int[] twoDigitNum = new int[n];
            int[] merges = new int[n - 1];
            int[] sums = new int[n - 1];

            for (int i = 0; i < n; i++)                   // input array of 2-digit numbers
            {
                twoDigitNum[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0, j = 1; i < n - 1; i++, j++)
            {//merge
                int b = ((twoDigitNum[i] % 10) * 10);
                int c = twoDigitNum[j] / 10;
                merges[i] = b + c;
                //sum
                sums[i] = twoDigitNum[i] + twoDigitNum[j];
            }
            foreach (var item in merges)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            foreach (var item in sums)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            //    Console.WriteLine(String.Join(" ", merges));
            //    Console.WriteLine(String.Join(" ", sums));
        }
    }
}
