using System;

namespace Recursie_FibonacciSnel
{
    class Program
    {
        static decimal[] fib = new decimal[55];
        static void Main(string[] args)
        {

            Console.WriteLine(FibonacciSnel(10));
            //Console.WriteLine(FibonacciSnel(50));
        }
        static decimal FibonacciSnel(int n)
        {
            if (fib[n] == 0)
            {
                if ((n == 1) || (n == 2))
                    fib[n] = 1;
                else
                    fib[n] = FibonacciSnel(n - 1) + FibonacciSnel(n - 2);
            }
            return fib[n];
        }
    }

    
}
