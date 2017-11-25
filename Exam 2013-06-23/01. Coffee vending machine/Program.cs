using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Coffee_vending_machine
{
    class Program
    {
        static void Main()
        {
            Console.Write("of 0.05 x ");
            decimal n1 = 0.05m;
            int n1Count = int.Parse(Console.ReadLine());
            Console.Write("of 0.10 x ");
            decimal n2 = 0.10m;
            int n2Count = int.Parse(Console.ReadLine());
            Console.Write("of 0.20 x ");
            decimal n3 = 0.20m;
            int n3Count = int.Parse(Console.ReadLine());
            Console.Write("of 0.50 x ");
            decimal n4 =0.50m;
            int n4Count = int.Parse(Console.ReadLine());
            Console.Write("of 1.00 x ");
            decimal n5 = 1m;
            int n5Count = int.Parse(Console.ReadLine());

            Console.Write("client's deposit =  ");
            decimal deposit = decimal.Parse(Console.ReadLine());

            Console.Write("item's price = ");
            decimal price = decimal.Parse(Console.ReadLine());

            decimal initialVendingCash = n1 * n1Count + n2 * n2Count + n3 * n3Count + n4 * n4Count + n5 * n5Count;
            decimal change = deposit - price;
            
            
                if (n5Count > 0)
                {
                    while (change - n5 >= 0 && n5Count > 0)
                    {
                        change -= n5;
                        n5Count--;
                    }
                }
                if (n4Count > 0)
                {
                    while (change - n4 >= 0 && n4Count > 0)
                    {
                        change -= n4;
                        n4Count--;
                    }
                }
                if (n3Count > 0)
                {
                    while (change - n3 >=0 && n3Count > 0)
                    {
                        change -= n3;
                        n3Count--;
                    }
                }
                if (n2Count > 0)
                {
                    while (change - n2 >= 0 && n2Count > 0)
                    {
                        change -= n2;
                        n2Count--;
                    }
              }
              if (n1Count > 0)
              {
                  while (change - n1 >= 0 && n1Count > 0)
                  {
                      change -= n1;
                      n1Count--;
                  }
              }
            
            decimal leftVendingCash = n1 * n1Count + n2 * n2Count + n3 * n3Count + n4 * n4Count + n5 * n5Count;
            if (deposit >= price && change==0)
            {
                Console.WriteLine("Yes {0:f2}", leftVendingCash);
            }
            else if(deposit>price && change!=0)
            {
                Console.WriteLine("No {0:f2}",change);
            }
            else if (deposit< price)
            {
                Console.WriteLine("More {0:f2}", (price-deposit));
            }




        }



    }
}
