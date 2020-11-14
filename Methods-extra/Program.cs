using System;

namespace Methods_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcSum(2, 5));
            Console.WriteLine(CalcSum());
            Console.WriteLine(CalcSum(4, -9, 85, 147, 2, 1, 41, 514, 155, 1552, 1551, 155));
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.KeyChar);

        }
        static long CalcSum(params int[] elementen)
        {
            long som = 0;
            foreach (int element in elementen)
            {
                som += element;
            }
            return som;
        }
    }
}
