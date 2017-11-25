using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of array's elements: ");
            int n = int.Parse(Console.ReadLine());


            //declaring a list and array
            int[] array = new int[n];
            List<int> list = new List<int>();
            List<int> result = new List<int>();
            //initializing the array and the list 
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} element:  ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                list.Add(array[i]);
            }
            int r = n;
            int subsequence = 0;

            //finding the smallest element but bigger than the most left one in the array and move it to the right-end  
            for (int k = 0; k < n; k++)
            {
                result.Add(array[k]);
                int count = 0;
                for (int i = n - r; i < n; i++)
                {
                    result.Add(array[i]);
                    int j = i;
                    while (j + 1 < n)
                    {
                        if (list[j] < list[j + 1] && array[i] < list[j])
                        {
                            int temp = list[j + 1];
                            list[j + 1] = list[j];
                            list[j] = temp;
                            count++;
                        }
                        j++;
                    }
                    if (count != 0)
                    {
                        result.Add(list[r - 1]);
                        if (list[r - 1] != array[r - 1]) 
                        {
                            list.RemoveAt(r - 1);
                        }
                        //if (list[r - 1] < list[r - 2] && array[k] < list[r - 2])
                        //{
                        //}

                        
                        r--;
                    }
                    if (subsequence < result.Count && i == n - 1)
                    {
                        subsequence = result.Count;
                    }
                }
                // result.Clear();

            }

            Console.WriteLine("\n\n\t\t{0}\n\n", result.Count);
        }
    }
}
