using System;
using System.IO;

namespace Demo_RecursiefCopyFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            CopyFolder(@"C:\temptest", @"C:\tempcopy");
        }

        static void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(destFolder))
            {
                Console.WriteLine($"Aanmaken van folder {destFolder}");
                Directory.CreateDirectory(destFolder);
            }
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string vanBestandsNaam = Path.GetFileName(file);
                string naarPadMetBestandsNaam = Path.Combine(destFolder, vanBestandsNaam);
                Console.WriteLine($"Kopiëren van bestand {vanBestandsNaam} naar {naarPadMetBestandsNaam}");
                File.Copy(file, naarPadMetBestandsNaam);
            }

            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string naam = Path.GetFileName(folder);
                string naarPad = Path.Combine(destFolder, naam);
                Console.WriteLine($"Kopiëren van subfolder {naam} naar {naarPad}");
                CopyFolder(folder, naarPad);
            }
        }
    }
}
