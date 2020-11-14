using System;

namespace MethodOutParamUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Geef een geheel getal:");
            //int getal;
            //bool invoerOk = int.TryParse(Console.ReadLine(), out getal);
            //if (invoerOk) Console.WriteLine($"Getal is {getal}");
            int resultaat;
            bool delingOK = OefeningMethodOutParam(10, 0, out resultaat);
            if (delingOK)
                Console.WriteLine($"Quotient is {resultaat}");
            else
                Console.WriteLine("Deling door nul kan niet");

        }

        static bool OefeningMethodOutParam(int deeltal, int deler, out int quotient)
        {
            quotient = 0;
            if (deler == 0)
            {
                return false;//geeft false terug indien deler = 0
            }
            else
            {
                quotient = deeltal / deler;
                return true;
            }
        }

    }
}
