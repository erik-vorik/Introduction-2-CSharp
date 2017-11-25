using System;


   class Program
   {
       static void Main()
       {
        int? num = null;
        double? realNum = null;
        Console.WriteLine(num + realNum);
        Console.WriteLine(num);
        double? sumReal = realNum + 1;
        Console.WriteLine(realNum );
        int? sumNum = num + 1;
        Console.WriteLine(sumNum);
       }
   }

