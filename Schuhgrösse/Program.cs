using System;

namespace Schuhgrösse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie Ihre Fusslänge an:");
            double fusslaenge = double.Parse(Console.ReadLine());
            double mitAbstand = fusslaenge + 1.5;
            double schuhgroesse = mitAbstand * 1.5;
            Console.WriteLine("Ihre Schuhgrösse beträgt: " + schuhgroesse);
        }
    }
}
