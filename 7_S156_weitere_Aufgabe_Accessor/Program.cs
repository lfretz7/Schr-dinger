using System;

namespace Schroedinger.Klassen
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person lfretz = new Person(); // Objekt lfretz erstellt
            lfretz.Birthday = DateTime.Parse("12.03.2001 12:00:00");
            lfretz.Sex = Sex.Male;
            Console.WriteLine("Geburtsdatum:  " + lfretz.Birthday);
            Console.WriteLine("\n \n \n");
            Console.WriteLine("Geschlecht:  " + lfretz.Sex);
        }

    }
}
