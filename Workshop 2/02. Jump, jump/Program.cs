using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Jump__jump
{
    class Program
    {
        static void Main()
        {
            string danceSteps = Console.ReadLine();

            for (int i = 0; i < danceSteps.Length;)
            {
                if (int.TryParse(Convert.ToString(danceSteps[i]), out int currDigit))
                {
                    if (currDigit % 2 == 0 && currDigit != 0)     //Even
                    {
                        if (i + currDigit >= 0 && i + currDigit < danceSteps.Length)         // jumping forward
                        {
                            i += currDigit;
                        }
                        else                                      // jumping off the stage
                        {
                            Console.WriteLine("you fell off the dance floor at pos {0}", i+currDigit);
                            break;
                        }
                    }
                    else if (currDigit % 2 != 0)  // Odd
                    {
                        if (currDigit >= 0 && currDigit < danceSteps.Length)         // jumping backwards
                        {
                            i -= currDigit;
                        }
                        else                                      // jumping off the stage
                        {
                            Console.WriteLine("you fell off the dance floor at pos {0}", i-currDigit);
                            break;
                        }
                    }
                    else if (currDigit == 0)      // Zero  
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", i);
                        break;
                    }
                }
                else if (danceSteps[i] == '^')   //
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                    break;
                }



            }
        }
    }
}
