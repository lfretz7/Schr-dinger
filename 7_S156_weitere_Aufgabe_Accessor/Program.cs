using System;

namespace _7_S156_weitere_Aufgabe_Accessor
{
    class Program
    {
        enum Sex { Male, Female}
        class Person //neue Klasse: Person
        {
            public string Firstname { get; set; }

            DateTime birthday;
            public DateTime Birthday
            {
                get { return this.birthday;}
                set
                {
                    if (value <= DateTime.Now)
                    {
                        this.birthday = value;
                    }
                }
            }
            public Sex Sex { get; set; }
            static void Main(string[] args)
            {
                Person lfretz = new Person(); // Objekt lfretz erstellt
                lfretz.birthday = DateTime.Parse("12.03.2001 12:00:00");
                lfretz.Sex = Sex.Male;
                Console.WriteLine("Geburtsdatum:  " + lfretz.birthday);
                Console.WriteLine("\n \n \n");
                Console.WriteLine("Geschlecht:  " + lfretz.Sex);
            }
        }
    }
}
