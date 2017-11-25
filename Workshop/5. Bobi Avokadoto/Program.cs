using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Bobi_Avokadoto
{
    class Program
    {
        static void Main()
        {
            Console.Write("hairs: ");                              //initializing hair count
            int hairs = int.Parse(Console.ReadLine());             //and number of colmbs 
            Console.Write("number of colmbs: ");                   //plus each colmb's numerical
            int numberOfColmbs = int.Parse(Console.ReadLine());    //representation
            int[] colmbs = new int[numberOfColmbs];                
            List<int> colmbsUseful = new List<int>();
            for (int i = 0; i < numberOfColmbs; i++)
            {
                colmbs[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numberOfColmbs; i++)                //checking which colmbs
            {                                                       //are going to meet the requiremnt
                if ((hairs & colmbs[i]) == 0)                       // to have no overlapping
                {                                                   //sets of 1s
                    colmbsUseful.Add(colmbs[i]);                    
                }
            }

            if (colmbsUseful.Count > 0)                             
            {
                int[] storingColmbUsefulCountOfOnes = new int[colmbsUseful.Count];
                for (int i = 0; i < colmbsUseful.Count; i++)        //each number stored in
                {                                                   //the colmbsUseful
                    int countOfOnes = 0;                            //is being checked how many times  
                    int timesDividedByTwo = 0;                      //can be devided by 2
                    int currentColmbUseful = colmbsUseful[i];
                    do
                    {
                        currentColmbUseful = currentColmbUseful / 2;
                        timesDividedByTwo++;
                    } while (currentColmbUseful > 0);

                    int tempColmbUseful = colmbsUseful[i];
                    for (int j = 0; j < timesDividedByTwo; j++)     //each number stored in
                    {                                               //the colmbsUseful
                                                                    //is being checked how many ONEs  
                        if ((tempColmbUseful & 1) == 0)             //it has
                        {
                            tempColmbUseful >>= 1;
                        }
                        else
                        {
                            countOfOnes++;
                            tempColmbUseful >>= 1;
                        }
                    }
                    storingColmbUsefulCountOfOnes[i] = countOfOnes;
                }
                int theBestColmb = 0;
                for (int i = 0, j = i + 1; j < storingColmbUsefulCountOfOnes.Length; j++)
                {
                    if (storingColmbUsefulCountOfOnes[i] > storingColmbUsefulCountOfOnes[j])
                    {
                        theBestColmb = i;
                    }
                    else if (storingColmbUsefulCountOfOnes[i] < storingColmbUsefulCountOfOnes[j])
                    {
                        theBestColmb = j;
                        i = j;
                    }
                    else if (storingColmbUsefulCountOfOnes[i] == storingColmbUsefulCountOfOnes[j])
                    {
                        theBestColmb = i;
                    }
                }
                Console.WriteLine("\n\nThe best colmb is: {0}",colmbsUseful[theBestColmb]);
            }                                      //resulting best colmb,  if any
            else                                                              
            {
                Console.WriteLine("\n\nNo useful colmbs !!!");
            }

        }
    }
}
