using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Find_sum_in_array
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("sought sum: ");
            int s = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            List<int> indexesOfSequence = new List<int>();
            List<int> indexToRemove = new List<int>();

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //sorting the array
            {
                for (int i = 0; i < n - 1; i++)
                {
                    int indexValueMin = i;
                    int k = i;
                    for (int q = i + 1; q < n; q++)
                    {
                        if (array[k] > array[q])
                        {
                            indexValueMin = q;
                            k = q;
                        }
                        else if (array[k] < array[q])
                        {
                            indexValueMin = k;
                        }
                    }
                    int temp = array[i];
                    array[i] = array[indexValueMin];
                    array[indexValueMin] = temp;
                }
                //trying to find the sought sum of elemnts in the array
                int j = 0;
                do
                {
                    if (s - array[j] >= 0)
                    {
                        s -= array[j];
                        indexesOfSequence.Add(j);
                        j++;
                    }
                    else if (s - array[j] < 0)
                    {
                        int diff = array[j] - s;

                        for (int k = 0; k < n; k++)
                        {
                            if (array[k] == diff)
                            {
                                indexToRemove.Add(k);
                                break;
                            }
                            else if (array[k] < diff)
                            {
                                indexToRemove.Add(k);
                            }
                        }
                        if (indexToRemove.Count != 0)
                        {
                            for (int i = 0; i < indexToRemove.Count; i++)
                            {
                                s += array[indexToRemove[i]];
                                indexesOfSequence.Remove(indexToRemove[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n\nняма такава поредица!");
                            break;
                        }
                    }
                } while (s != 0);
                Console.WriteLine("\nresult\n");
                if (s == 0)
                {
                    for (int i = 0; i < indexesOfSequence.Count; i++)
                    {
                        Console.WriteLine(array[indexesOfSequence[i]]);
                    }
                }

            }
        }
    }
}
