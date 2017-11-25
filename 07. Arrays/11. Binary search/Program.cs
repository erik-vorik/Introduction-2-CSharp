using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_search
{
    class Program
    {
        static void Main()
        {                       // initialization of the input array + input of sought element
            Console.Write("specify the lenght of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} element: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Search for: ");
            int wantedNum = int.Parse(Console.ReadLine());
            // sorting the array    
            for (int i = 0; i < n - 1; i++)
            {
                int indexOfValueMin = i;    //on each iteratio assume the smallest element  
                int k = i;                  // is located at [i]    
                for (int j = i + 1; j < n; j++)
                {
                    if (array[k] > array[j])
                    {
                        indexOfValueMin = j;
                        k = j;
                    }
                    else if (array[k] < array[j])
                    {
                        indexOfValueMin = k;
                    }
                }
                int temp = array[i];                 //swapping the places of element [i] 
                array[i] = array[indexOfValueMin];   // and the element holding the smallest
                array[indexOfValueMin] = temp;       //  value right of index i
            }
            //performing binary search in the sorted input array
            int mid;
            int L = 0;          // boundary on the LEFT
            int R = n - 1;      // boundary on the RIGHT

            do
            {
                mid = (L + R) / 2;
                if (wantedNum == array[mid])                                    // wanted number = middle element
                {
                    Console.WriteLine("the index of target is: {0}", mid);
                    break;
                }
                else if (wantedNum > array[mid])                                // wanted number > middle element
                {
                    L = mid + 1;
                }
                else if (wantedNum < array[mid])                                // wanted number < middle element
                {
                    R = mid - 1;
                }
                else if (L > R)                                                 //
                {                                                               //
                    break;                                                      //
                }                                                               //  wanted number DOES not
            } while (L <= R);                                                   //
                                                                                //
            if (L > R)                                                          //
            {                                                                   //
                Console.WriteLine(" {0} does NOT exist in the array", wantedNum);
            }



        }
    }
}
