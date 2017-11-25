using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Feathers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Bird count: ");
            float birds = int.Parse(Console.ReadLine());
            Console.Write("Feather count: ");
            float feathers = int.Parse(Console.ReadLine());
            double avrgFeatherPerBird = feathers / birds;
            double result;
            if (birds % 2 == 0)
            {
                result = avrgFeatherPerBird * 123123123123;
            }
            else
            {
                result = avrgFeatherPerBird / 317;
            }
            Console.WriteLine("{0:f4}", result);
        }
    }
}
