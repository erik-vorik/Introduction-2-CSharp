using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Bit
{
    class Program
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            int mask = 1 << 2;
            int iAndMask = i & mask;
            int showThridBit = iAndMask >> 2;
            Console.WriteLine(showThridBit);


            //connsole.WriteLine(i >> 2);
        }
    }
}
