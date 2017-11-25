using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Number_of_pages
{
    class Program
    {
        static void Main()
        {
            Console.Write("enter digits: ");
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            while (digits > 0)
            {
                pages++;
                if (pages / 10 != 0)
                {
                    int temp = pages;
                    int subtractionFromDigits = 0;
                    do
                    {
                        temp = temp / 10;
                        subtractionFromDigits++;
                    } while (temp != 0);
                    digits -= subtractionFromDigits;
                }
                else            //pages / 10 == 0
                {
                    digits -= 1;
                }
            }
            Console.WriteLine("\n\npages count:  {0}\n\n", pages);

        }
    }
}

