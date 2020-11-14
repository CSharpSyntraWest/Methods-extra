using System;

namespace MethodParamByValue
{
    class Program
    {
        static void Main()
        {
            int getal = 3;
            PrintGetal(getal);
            Console.WriteLine($"Getal waarde in Main is {getal}");
        }

        private static void PrintGetal(int nummer)//passing param by value (int, double, long, float,..)
        {
            nummer = 5;
            Console.WriteLine($"Getal waarde in PrintGetal is {nummer}");
        }
    }
}
