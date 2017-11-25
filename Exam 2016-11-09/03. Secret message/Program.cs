using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Secret_message
{
    class Program
    {
        static void Main(string[] args)
        {
            string sIndex;
            int lineCount = 0;
            string hiddenMsg=null;
            do
            {
                Console.Write("start index: ");
                sIndex = Console.ReadLine();  //start index 
                if (int.TryParse(sIndex, out int num))
                {
                    Console.Write("end index: ");
                    int e = int.Parse(Console.ReadLine());  // end index 
                    lineCount++;
                    Console.Write("text line: ");
                    string textLine = Console.ReadLine();
                    int s = int.Parse(sIndex);
                    s = s >= 0 ? s : textLine.Length + s;
                    e = e >= 0 ? e : textLine.Length + e;
                    int step = lineCount % 2 == 0 ? 4 : 3;
                    for (int i = s; i <= e; i+=step)
                    {
                        hiddenMsg += textLine[i];
                    }

                }
            } while (sIndex != "end");
            Console.WriteLine("\n\n hidden msg: {0}",hiddenMsg);
        }
    }
}
