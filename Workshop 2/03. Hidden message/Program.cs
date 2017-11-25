using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hidden_message
{
    class Program
    {
        static void Main()
        {
            string codedMsg = null;
            /////////////
            while (true)
            {
                string indexStart = Console.ReadLine();              // initialization index(string)
                if (indexStart != "end")
                {
                    int indexInt = int.Parse(indexStart);
                    int skip = int.Parse(Console.ReadLine());     // initialization skip(int)
                    string text = Console.ReadLine();                // initialization text(string)
                    if (indexInt >= text.Length)
                    {//if IndexInt is bigger than text lenght then reitarate
                        continue;
                    }
                    if (indexInt >= 0)
                    {
                        for (int i = indexInt; (i >= 0) && (i < text.Length); i += skip)
                        {
                            codedMsg += text[i];
                        }
                    }
                    else if (indexInt < 0)
                    {
                        for (int i = text.Length + indexInt; (i >= 0) && (i < text.Length); i += skip)
                        {
                            codedMsg += text[i];
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(codedMsg);
        }

    }
}

