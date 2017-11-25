using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_increasing_sequence
{
    class Program
    {
        static void Main()
        {


            Console.Write("Enter number of array's elements: ");    //
            int n = int.Parse(Console.ReadLine());                  //
            int[] array = new int[n];                               //declaring an input array 
                                                                    //with 'n' elements
            for (int i = 0; i < n; i++)                             //
            {                                                       //initializing the array
                array[i] = int.Parse(Console.ReadLine());           //
            }
            int maxLeng = 1;
            int subseqLeng = 1;
            for (int j = 0, i = 1; i < n; i++, j++)
            {
                if (array[j] < array[i])
                {
                    subseqLeng++;
                   
                }
                else
                {
                    if (maxLeng<subseqLeng)
                    {
                        maxLeng = subseqLeng;
                    }
                    subseqLeng = 1;
                }
          
            }


            Console.WriteLine(maxLeng);




        }

    }
}
