using System;

namespace RecursieFibonacciTraag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibonacciTraag(10));
            Console.WriteLine(FibonacciTraag(50));
        }
        //Rij van Fibonacci = 1 1 2 3 5 8 13 21...
        static decimal FibonacciTraag(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return FibonacciTraag(n - 1) + FibonacciTraag(n - 2);
        }

        
    }
}
