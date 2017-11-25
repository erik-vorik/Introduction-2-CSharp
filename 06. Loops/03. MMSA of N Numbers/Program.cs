using System;

class Program
{
    static void Main()
    {
        double? current = null;
        
        double sum = 0;
        double? min = null;
        double? max = null;
        double average = 0;
        int n=0;
        do
        {
            n = int.Parse(Console.ReadLine());
        } while (!(n > 1 && n < 1000));
        

        for (int i = 1; i <= n; i++)

        {
            Console.Write("Enter real number {0}:  ", i);
            current = double.Parse(Console.ReadLine());
            sum += (double)current;
            average = sum / n;

           
            if (i==1)
            {
                min = current;
                max = current;
            }

            if (current > max)
            {
                max = current;
            }
            else if (current < min)
            {
                min = current;
            }

   

        }
        Console.WriteLine("min = {0:f2}", min);
        Console.WriteLine("max = {0:f2}", max);
        Console.WriteLine("sum = {0:f2}" , sum);
        Console.WriteLine("avg = {0:f2}" , average);
    }
}

