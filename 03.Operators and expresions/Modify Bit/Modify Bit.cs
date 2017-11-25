using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modify_Bit
{
    class Program
    {
        static void Main()
        {
            //--------------Входни данни-----------
            Console.WriteLine("Write a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("position of the bit:");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the new value in position p (0 or 1): ");
            int v = int.Parse(Console.ReadLine());
            //--------------Програма---------------
            num = (v == 0) ? num = num & (~(1 << position)) : num = num | (1 << position);
            Console.WriteLine("Резултат след манипулацията на бита на позиция P: " + " " + num);
        }
    }
}
