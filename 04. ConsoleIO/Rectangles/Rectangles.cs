using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Please enter width:\t");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Please enter height:\t");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the rectangle is {0:0.00} and its area is {1:0.00}", (height + width) * 2, height * width);
            //0.00 означава задължително 2 знака след десетичния разделител
            //0.## означава максимум 2 знака след десетичния разделител
            //0.0# означава максимум 2 знака след десетичния разделител, но задължително 1
            //1.00 поставя пред отпечатания резултат цифра 1 ; с максимум 2 знака след десетичния разделител
            //0.01 отпечатаната цифра завършва с 1 и е с максимум 2 знака след десетичния разделител
        }
    }
}
