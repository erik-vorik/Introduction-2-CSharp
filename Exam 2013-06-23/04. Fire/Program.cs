using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fire
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter width of the torch: ");
            int n = int.Parse(Console.ReadLine());
            char[] fire = new char[n];
            /////////THE FLAME/////////
            for (int k = 0; k < n * 3 / 4; k++)
            {
                for (int i = 0; i < n; i++)      //initialization of fire array 
                {
                    if (k == n / 2)
                    {
                        break;
                    }
                    if (n / 2 - k - 1 >= 0 && n / 2 + k <= n - 1)     //expanding
                    {
                        if (i == n / 2 - k - 1 || i == n / 2 + k)
                        {
                            fire[i] = '#';
                        }
                        else
                        {
                            fire[i] = '.';
                        }
                    }
                    else                           //narrowing
                    {
                        if (i == k - n / 2 || i == (n - 1) - (k - n / 2))
                        {
                            fire[i] = '#';
                        }
                        else
                        {
                            fire[i] = '.';
                        }
                    }
                }
                for (int i = 0; i < n; i++)     //printing  each new row/array
                {
                    Console.Write(fire[i]);
                }
                Console.WriteLine();
            }
            //////////--------------//////////
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
            //////////  THE HANDLE  //////////
            for (int k = -1; k < n / 2 - 1; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i <= k || i >= n - 1 - k)
                    {
                        fire[i] = '.';
                    }
                    else if (i > k && i < n / 2)
                    {
                        fire[i] = '\\';
                    }
                    else if (i >= n / 2 && i < n - 1 - k)
                    {
                        fire[i] = '/';
                    }
                }
                for (int i = 0; i < n; i++)     //printing  each new row/array
                {
                    Console.Write(fire[i]);
                }
                Console.WriteLine();
            }






        }
    }
}
