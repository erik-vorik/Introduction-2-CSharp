using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main()
        {



            Console.Write("enter 'n': ");
            int n = int.Parse(Console.ReadLine());


            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine((numbers[i] = i * 5) + " "); 
            }

            
        }

    }
}
