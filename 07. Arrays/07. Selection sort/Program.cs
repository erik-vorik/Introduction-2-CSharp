using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter the lenght of the array to be sorted:  ");
            int n = int.Parse(Console.ReadLine());
            //declaring two arrays
            int[] unsorted = new int[n];
            //initializing the Input array
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} element: ", i);
                unsorted[i] = int.Parse(Console.ReadLine());
            }
            //assume each time the first index is smallest
            for (int i = 0; i < n - 1; i++)
            {
                int indexValueMin = i;
                int k = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (unsorted[k] > unsorted[j])
                    {
                        indexValueMin = j;
                        k= j;
                    }
                    else if (unsorted[k] < unsorted[j])
                    {
                        indexValueMin = k;
                    }
                }
                int temp = unsorted[i];
                unsorted[i] = unsorted[indexValueMin];
                unsorted[indexValueMin] = temp;
            }
            //result
            Console.WriteLine();
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(unsorted[k]);
            }
        }
    }
}
