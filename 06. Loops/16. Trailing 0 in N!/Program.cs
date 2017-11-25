using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Trailing_0_in_N_
{                                                                                                       
    class Program                                                                                       
    {                                                                                                   
        static void Main()                                                                              
        {                                                                                               
                                                                                                        
            Console.Write("enter 'n' for n!: ");                                                        
            int n = int.Parse(Console.ReadLine());                                                      
            int trailingZeroes = 0;                                                                     
            int countOf5s = n / 5;                                                                      
                                                                                                        
                                                                                                        
                                                                                                        
            if (countOf5s > 0)                                                                          
            {                                                                                           
                trailingZeroes = countOf5s;                                                             
                                                                                                        
                                                                                                        
                                                                                                        
                for (int i = 1; i <= countOf5s; i ++)                                                   
                {                                                                                                                                                                                                                                           
                    int temp = i;

                    while (temp % 5 == 0)
                    {
                        temp /= 5;
                        trailingZeroes++;

                    }
                }



                Console.WriteLine("\n\n {0} trailing zeroes \n\n", trailingZeroes);
            }
            else
            {
                Console.WriteLine("\n\nno trailing zeroes\n\n");
            }



        }
    }
}
