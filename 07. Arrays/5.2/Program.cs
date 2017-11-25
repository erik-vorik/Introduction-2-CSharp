using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main()
        {
            int subsequence = 0;
            // Console.Write("Enter number of array's elements: ");
            // int n = int.Parse(Console.ReadLine());
            int n = 8;
            //declaring a list and array
            int[] array = {5,6,7,0,5,1,4,0 };
            List<int> currSubseq = new List<int>();
            List<int> skipIndex = new List<int>();
            //initializing array
           // for (int r = 0; r < n; r++)
           // {
           //     Console.Write("element {0}: ", r);
           //     array[r] = int.Parse(Console.ReadLine());
           // }
            //////////////////////////////////////////////////////////////////////


            int i = 0, j = 0;
            while (i <= n - 1)
            {
                currSubseq.Clear();
                j = i + 1;
                do
                {
                    if (array[i] < array[j] && !skipIndex.Contains(i) && !skipIndex.Contains(j))
                    {
                        if (j + 1 == n || array[j] > array[j + 1])
                        {
                            currSubseq.Clear();
                            skipIndex.Clear();
                        }
                        currSubseq.Add(array[i]);
                        for (int k = j + 1; k < n; k++)
                        {
                            if (array[j] > array[k] && array[k] > array[i])
                            {
                                currSubseq.Add(array[j]);
                                skipIndex.Add(j);
                                break;
                            }
                        }
                        if (skipIndex.Count == 0)
                        {
                            i = j;
                        }
                        if (subsequence < currSubseq.Count)
                        {
                            subsequence = currSubseq.Count;
                        }
                        j++;
                    }
                    else if (array[i] > array[j])
                        j++;
                } while (j <= n - 1);
                i++;
            }




        }
    }
}
