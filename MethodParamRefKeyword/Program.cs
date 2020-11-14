using System;

namespace MethodParamRefKeyword
{
    class Program
    {
        static void Main()
        {
            int getal = 3;
            PrintGetal(ref getal);
            Console.WriteLine($"Getal waarde in Main is {getal}");
        }

        private static void PrintGetal(ref int nummer)//passing referentie naar parameter (waarde kan wijzigen)
        {
            nummer = 5;
            Console.WriteLine($"Getal waarde in PrintGetal is {nummer}");
        }
    }
}
