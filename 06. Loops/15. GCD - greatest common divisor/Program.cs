using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {


        int a, b;
        string strA = null, strB = null;

        while (true)
        {

        
        do
        {
            Console.WriteLine("enter 2 integers to find their gcd: ");
            string input = Console.ReadLine();


            for (int i = 0, countSpace = 0; i < input.Length; i++)
            {

                if (input[i] == 32)
                {
                    countSpace++;
                }
                switch (countSpace != 0)
                {
                    case false: strA += input[i]; break;
                    case true: strB += input[i]; ; break;

                }

            }
            a = int.Parse(strA);
            b = int.Parse(strB);



        } while ((a == b) && ((a < 2) || (a > 500)) && ((b < 2) || (b > 500)));

        /* и двата метода на Алгоритъма на Евклид са имплементирани   */
        /* отляво с деление , отдясно с изваждане */

        //Euclidean algorithm (with devision)         //Euclidean algorithm (with differences )
        int mod;                                      //int difference = Math.Abs(a - b);                                   
        int modulo;                                   //                                                                    
        if (a > b)                                    //while (difference != 0)                                             
        {                                             //{                                                                   
            mod = a % b;                              //    if (b > difference)                                             
        }                                             //    {                                                               
        else                                          //        int temp = b;                                               
        {                                             //        b = difference;                                             
            int temp = a;                             //        difference = temp;                                          
            a = b;                                    //    }                                                               
            b = temp;                                 //    difference = difference - b;                                    
            mod = a % b;                              //}                                                                   
                                                      //                                                                    
        }                                             //int gcd = b;                                                        
        do                                            //Console.WriteLine("\n/euclidean alg. w.differences/  gcd({0},{1})  is  {2}\n\n", strA, strB, gcd);
        {
            modulo = b % mod;
            b = mod;
            mod = modulo;
        } while (modulo != 0);


        Console.WriteLine("\n/euclidean alg. w.devision/ gcd({0},{1})  is  {2}\n", strA, strB, b);





        }



    }
}
