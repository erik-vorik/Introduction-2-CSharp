using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Busses
{
    class Program
    {
        static void Main()
        {
            Console.Write("buss count: ");
            int busCount = int.Parse(Console.ReadLine());
            int busGroupCount = 0;
            int[] busSpeed = new int[busCount];
            for (int i = 0; i < busCount; i++)
            {
                int k = i + 1;
                Console.Write("bus {0}: ", k);
                busSpeed[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < busCount;)
            {
                if (i == busCount - 1)
                {
                    busGroupCount++;
                    break;
                }
                for (int j = i + 1; j < busCount; j++)
                {
                    if (busSpeed[j] != busSpeed[j - 1])
                    {
                        if (busSpeed[i] >= busSpeed[j])
                        {
                            i = j;
                            busGroupCount++;
                            break;
                        }
                        else if (busSpeed[i] < busSpeed[j] && j == busCount - 1)
                        {
                            i = j;
                            busGroupCount++;
                            i++;
                        }
                    }
                    else
                    {
                        i = j;
                        busGroupCount++;
                        break;
                    }
                }
            }
            Console.WriteLine("\n\n{0}", busGroupCount);




        }
    }
}
