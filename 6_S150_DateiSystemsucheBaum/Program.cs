using System;
using System.IO;

namespace _6_S150_DateiSystemsucheBaum
{
    class Program
    {
        static void Suche(string pfad, string muster)
        {
            string[] dirs = Directory.GetFileSystemEntries(pfad, muster);
            if (dirs.Length > 0)
            {
                if(dirs.Length == 1)
                {
                    string ausgabe = $"\nEs ist eine Datei mit dem Namen {muster} vorhanden:";
                    Console.WriteLine(ausgabe);
                }
                else
                {
                    string ausgabe = $"\nEs sind {dirs.Length} Dateien mit dem Namen {muster} vorhanden:";
                    Console.WriteLine(ausgabe);

                }

                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
            }
            string[] subdirectorys = Directory.GetDirectories(pfad);
            foreach (string sub in subdirectorys)
            {
                Suche(sub, muster);
            }
        }
        static void Main(string[] args)
        {
            Suche(@"C:\Data", "*.db");
        }
    }
}
