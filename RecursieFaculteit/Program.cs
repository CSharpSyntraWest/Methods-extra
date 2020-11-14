using System;

namespace RecursieFaculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            long faculteit = Faculteit(6);
            Console.WriteLine("5 faculteit = " + faculteit);
        }
        static long Faculteit(int getal)
        {
            if (getal == 0) //0 faculteit = 1 -- recursie stopt
                return 1;
            else
               return getal * Faculteit(getal-1); // 5 faculteit = 5 * 4 faculteit...
        }
    }
}
