using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            int variabel1 = 2;
            short variabel2 = 5999;
            int i = 1;
            bool istGerade = (i % 2 == 0);
            Console.WriteLine("Ist 1 eine gerade Zahl?   " + istGerade);
            bool feiertag = true;
            bool sonntag = true;
            bool feiertag = feiertag |= sonntag;
            Console.WriteLine(sonntag);
        }
    }
}
