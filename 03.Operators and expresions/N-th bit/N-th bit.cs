using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_th_bit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("position of the bit to print ");
            int position = int.Parse(Console.ReadLine());
            int mask = 1 << position;
            int nAndMask = num & mask;
            int bit = nAndMask >> position;
            Console.WriteLine("Returned value of the bit in the specified position:" + " " + bit);
            //вариант 2
            //Console.WriteLine("Число");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Позицията на бита");
            //int position = int.Parse(Console.ReadLine());
            //int mask = 1 << position;
            //int nAndMask = num & mask;
            //int bit = nAndMask >> position;
            //Console.WriteLine(bit == 1 ? "Стойност 1" : "Стойност 0");
        }
    }
}
