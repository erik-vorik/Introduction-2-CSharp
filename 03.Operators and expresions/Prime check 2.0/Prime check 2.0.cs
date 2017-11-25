using System;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        int possibleDivisor = 2;
        bool isPrime = true;
        if (n % 2 == 0 && n != 2)
        {
            isPrime = false;
        }

        while (isPrime && (possibleDivisor <= Math.Sqrt(n)))
        {
            if (n % possibleDivisor == 0)
            {
                isPrime = false;
                break;
            }

            possibleDivisor += 2;

        }
        Console.WriteLine(isPrime == true ? "{0}" + "is PRIME" : "{0}" + "is NOT prime. Divisibale of {1}", n, possibleDivisor);

    }
}
