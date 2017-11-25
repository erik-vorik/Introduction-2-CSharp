using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter the number of elements :  ");
            int n = int.Parse(Console.ReadLine());
            //declaring and initializng the array
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }



            int maxSumValue = 0;
            for (int i = 0, currSum = 0; i < n; i++)
            {
                if (currSum + array[i] > 0)
                {
                    currSum += array[i];
                    if (maxSumValue < currSum)
                    {
                        maxSumValue = currSum;
                    }
                }
                else
                {
                    if (maxSumValue < currSum)
                    {
                        maxSumValue = currSum;
                    }
                    currSum = 0;
                }
            }
            Console.WriteLine("The biggest sum of consequtive elements in the given array is: {0} ",maxSumValue);


        }
    }
}
