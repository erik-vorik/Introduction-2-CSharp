using System;

namespace alternating_sign_num
{
    class alternatingNumbers
    {
        static void Main()
        {
            for (int i = 2; i <= 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);

                }
            }
        }

    }
}
    

