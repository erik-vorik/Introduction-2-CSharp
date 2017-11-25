using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point__Circle__Rectangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the coordinates of point O (x,y)");
            Console.Write("x= ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y= ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine(((x * x) + (y * y)) <= 25 ? (x >= -1 & y >= 1 ? "ERROR -- The point is in the Cirlcle and the rectangle" : "CORRECT -- The point is in the Circle but OUT of the rectangle") : "The point is OUT of the circle");

        }
    }
}
