using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Numbers_of_pages
{
    class Program
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            while (digits>0)
            {
                if (digits / 10 == 0)
                {
                    pages++;
                }
                digits--;
            }
        }
    }
}
