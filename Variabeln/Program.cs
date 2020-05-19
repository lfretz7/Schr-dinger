using System;

namespace Schrödinger
{
    public class Programm
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bitte Namen eingeben:");
            var name = Console.ReadLine();
            Console.WriteLine("Hallo" + name);
            Console.ReadKey();
        }
    }
}
