using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_in_10_yrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your age");
            int x = 10;
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("your age after 10 yrs will be: " + (age + 10));
        }
    }
}
