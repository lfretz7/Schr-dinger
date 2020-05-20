using System;

namespace _5_S120_Enumeration
{
    class Program
    {
            enum Weekday
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday, 
            Saturday,
            Sunday
        }
            enum WoWVolk
        {
            Menschen, Zwerge, Gnome, Nachtelfen, Draenei, Worgen, Orcs, Untote, Tauren, Trolle, Blutelfen, Goblins, Pandaren
        }
        static void Main(string[] args)
        {
            //S. 120
            Weekday myDay1 = Weekday.Thursday;
            Console.WriteLine(myDay1);
            int weekday = (int)myDay1;
            Console.WriteLine(myDay1.ToString());

            //S. 123
            Console.WriteLine("Bitte englischen Wochentag eingeben:");
            string day = Console.ReadLine();
            Weekday myDay = (Weekday)Enum.Parse(typeof(Weekday), day);
            Console.WriteLine($"Der eingegebene Wochentag im Enum-Typ ist:{myDay}");

            //WoW-Völker S. 124
            WoWVolk meinVolk = WoWVolk.Blutelfen;
            if (meinVolk == WoWVolk.Orcs)
            {
                Console.WriteLine("Dieses Volk spielt Schrödinger.");
            }
            else
            {
                Console.WriteLine($"Aktuell wird das Volk: {meinVolk} gespielt");
            }
        }
    }
}
