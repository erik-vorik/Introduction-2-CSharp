using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Neuron_mapping
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter sequence");
            List<int> scanList = new List<int>();
            int n = 0;
            while (n != -1)                                       // initialization of
            {                                                     // the 'scan'
                n = int.Parse(Console.ReadLine());                // sequence by adding
                if (n >= 0)                                        // all non-negative ints
                {                                                 // in a list
                    scanList.Add(n);
                }
                else if (n < 0 && n != -1)
                {
                    Console.WriteLine("type -1 to stop entering");
                }
            }


            List<int> currNumberPosOnes = new List<int>();
            for (int i = 0; i < scanList.Count; i++)
            {                                                        //each element of scanList
                int tempScanNumber = scanList[i];                    //check for positions of  ONES
                currNumberPosOnes.Clear();
                for (int j = 0; tempScanNumber != 0; j++)
                {

                    if ((tempScanNumber & 1) == 1)                   //if there is 1 in pos 0
                    {                                                // add the j-shift in a list
                        currNumberPosOnes.Add(j);                    //representing the initial pos 
                    }                                                // of the 1 in the input 
                    tempScanNumber >>= 1;                            //number
                }
                bool isUnbroken = true;
                for (int j = 0; j < currNumberPosOnes.Count - 1; j++)
                {
                    if (currNumberPosOnes[j] != currNumberPosOnes[j + 1] - 1)
                    {                                     //check same element
                        isUnbroken = false;               // for
                        break;                            // unbroken sequence
                    }
                }
                if (isUnbroken == true)
                {
                    scanList[i] = 0;                             // if Yes - convert scanList[i] to 0
                }
                else
                {                                                 // if No - find inner lower 
                    int lowerL = currNumberPosOnes[0];            // and upper limits of the 1's  
                    int upperL = currNumberPosOnes[currNumberPosOnes.Count - 1];//in b'ween of which lie the 0's
                    for (int j = 0; j + 1 < currNumberPosOnes.Count; j++)//of the input number
                    {
                        if (lowerL == currNumberPosOnes[j + 1] - 1)
                        {
                            lowerL = currNumberPosOnes[j + 1];
                        }
                        if (upperL == currNumberPosOnes[(currNumberPosOnes.Count - 1) - 1 - j] + 1)
                        {
                            upperL = currNumberPosOnes[(currNumberPosOnes.Count - 1) - 1 - j];
                        }
                    }
                    //setting the 1's in the defined 
                    scanList[i] = 0;                        //by the lower and upper limits
                    for (int j = lowerL + 1; j < upperL; j++)
                    {
                        int mask = 1 << j;
                        scanList[i] = scanList[i] | mask;
                    }
                }
            }//printing the result
            for (int i = 0; i < scanList.Count; i++)
            {
                Console.WriteLine(Convert.ToString(scanList[i], 2).PadLeft(32, '0'));
            }








        }
    }
}
