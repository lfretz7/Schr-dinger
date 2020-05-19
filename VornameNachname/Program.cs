using System;

namespace Schrödinger
{
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Bitte Vornamen eingeben:");
            var vorname = Console.ReadLine();
            Console.WriteLine("Bitte Nachnamen eingeben:");
            var nachname = Console.ReadLine();
            Console.WriteLine("Hallo" + " " + vorname + " " + nachname);
            Console.ReadKey();
        }
    }
}
