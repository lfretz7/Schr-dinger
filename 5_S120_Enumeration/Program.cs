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

        }
    }
}
