using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            Console.WriteLine("Write a number:");
            uint num = uint.Parse(Console.ReadLine());
            //--проверка за битовете на позиции 3,4,5,24,25,26

            uint mask3 = 1 << 3;
            uint mask4 = 1 << 4;
            uint mask5 = 1 << 5;
            uint mask24 = 1 << 24;
            uint mask25 = 1 << 25;
            uint mask26 = 1 << 26;

            uint nAndMask3 = num & mask3;
            uint nAndMask4 = num & mask4;
            uint nAndMask5 = num & mask5;
            uint nAndMask24 = num & mask24;
            uint nAndMask25 = num & mask25;
            uint nAndMask26 = num & mask26;

            uint bit3 = nAndMask3 >> 3;
            uint bit4 = nAndMask4 >> 4;
            uint bit5 = nAndMask5 >> 5;
            uint bit24 = nAndMask24 >> 24;
            uint bit25 = nAndMask25 >> 25;
            uint bit26 = nAndMask26 >> 26;

            Console.WriteLine("bit in position 3={0}  4={1}  5={2} 24={3} 25={4} 26={5}", bit3, bit4, bit5, bit24, bit25, bit26);
            //--битовете bit1 bit2 bit3   bit4 bit5 bit6    са тези на позициите от горе
            //--започваме подмяна на битовете по двойки
            int t = 0;
            uint firstLevelNum = 0;
            uint secondLevelNum = 0;
            uint thirdLevelNum = 0;
            if (bit3 != bit24)             //преминаваме към битове 3 и 24
            {
                if (bit3 == 0)            //bit3 == 0 //bit24 == 1
                {
                    uint tempNum;
                    uint mask1na24 = 1 << 24;
                    tempNum = num & (~(mask1na24));
                    uint mask1na3 = 1 << 3;
                    firstLevelNum = tempNum | mask1na3;
                }
                else                      //bit3 == 1 //bit24 == 0
                {
                    uint tempNum;
                    uint mask1na3 = 1 << 3;
                    tempNum = num & (~(mask1na3));
                    uint mask1na24 = 1 << 24;
                    firstLevelNum = tempNum | mask1na24;
                }
            }
            if (bit4 != bit25)                //преминаваме към битове 4 и 25
            {
                if (bit4 == 0)                //bit4 == 0 // bit25 == 1
                {
                    if ((bit3 == bit24))
                    {
                        uint tempNum;
                        uint mask1na25 = 1 << 25;
                        tempNum = num & (~(mask1na25));
                        uint mask1na4 = 1 << 4;
                        secondLevelNum = tempNum | mask1na4;
                        Console.WriteLine(secondLevelNum);
                    }
                    else
                    {
                        uint tempNum;
                        uint mask1na25 = 1 << 25;
                        tempNum = firstLevelNum & (~(mask1na25));
                        uint mask1na4 = 1 << 4;
                        secondLevelNum = tempNum | mask1na4;
                        Console.WriteLine(secondLevelNum);
                    }
                }
                else                          //bit4 == 1 // bit25 == 0
                {
                    if ((bit3 == bit24))
                    {
                        uint tempNum;
                        uint mask1na4 = 1 << 4;
                        tempNum = num & (~(mask1na4));
                        uint mask1na25 = 1 << 25;
                        secondLevelNum = tempNum | mask1na25;
                    }
                    else
                    {
                        uint tempNum;
                        uint mask1na4 = 1 << 4;
                        tempNum = firstLevelNum & (~(mask1na4));
                        uint mask1na25 = 1 << 25;
                        secondLevelNum = tempNum | mask1na25;
                    }
                }

            }
            else
            {
                secondLevelNum = firstLevelNum;
            }
            if (bit5 != bit26)              //преминаваме към битове 5 и 26
            {
                if (bit5 == 0)        //bit5 == 0 // bit26 == 1
                {
                    t = 1;
                    uint tempNum;
                    uint mask1na26 = 1 << 26;
                    tempNum = secondLevelNum & (~(mask1na26));
                    uint mask1na5 = 1 << 5;
                    thirdLevelNum = tempNum | mask1na5;
                }


                else                           //bit5 == 1 // bit26 == 0
                {
                    {
                        t = 1;
                        uint tempNum;
                        uint mask1na5 = 1 << 5;
                        tempNum = secondLevelNum & (~(mask1na5));
                        uint mask1na26 = 1 << 26;
                        thirdLevelNum = tempNum | mask1na26;
                    }
                }
            }
            Console.WriteLine(t == 1 ? thirdLevelNum : secondLevelNum);
        }
    }
}
