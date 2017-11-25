using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon_Gravity
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Put human's weight on Earth: ");
            float humanOnEarth = float.Parse(Console.ReadLine());
            Console.WriteLine("The weight of a human speciment on the moon is:" + "  " + (humanOnEarth * 0.17) + "kg");
        }
    }
}
