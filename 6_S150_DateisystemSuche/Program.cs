using System;
using System.IO;

namespace _6_S150_DateisystemSuche
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentdir = Directory.GetCurrentDirectory();
            Console.WriteLine(currentdir);

            Console.WriteLine("Wie lautet Ihr Suchkriterium:");
            string searchPattern = Console.ReadLine();

            string[] dirs = Directory.GetFileSystemEntries(currentdir, searchPattern);

            if (dirs.Length > 0)
            {
                Console.WriteLine("Es ist eine Datei mit dem Namen {0} vorhanden:", searchPattern);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Es ist keine Datei mit dem Namen {0} vorhanden.", searchPattern);
                Console.ReadKey();
            }
        }
    }
}

