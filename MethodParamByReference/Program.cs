using System;

namespace MethodParamByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = { 10, 20, 30, 40, 50 };

            ModifyArray(getallen);

            foreach (int getal in getallen)
                Console.Write(getal + " ");

        }

        private static void ModifyArray(int[] getallen)//By reference param (Array)
        {
            getallen[0] = 5;
        }
    }
}
