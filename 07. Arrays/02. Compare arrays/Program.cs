using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main()
        {

            Console.Write("enter the number of elements in each of the two compared arrays: \n");
            int n = int.Parse(Console.ReadLine());
            bool isEqual = true;

            //declaring and initializing both arrays
            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];


            Console.WriteLine("\nplease enter {0} elemtents of array ONE", n);
            for (int i = 0; i < n; i++)
            {
                arrayOne[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("\nplease enter {0} elemtents of array TWO", n);
            for (int i = 0; i < n; i++)
            {
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            //comparison 

            for (int i = 0; i < n; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    isEqual = false;
                    break;
                }

            }
            if (isEqual == false)
            {
                Console.WriteLine("\nNOT equal");
            }
            else
            {
                Console.WriteLine("\nEQUAL");
            }








        }
    }
}
