using System;

namespace _7_S154_Klasse_ausprogrammierter Accessor
{
    class Program
    {
        class Person //neue Klasse: Person
        {
            string firstname;
            public string Firstname //neue Eigenschaft: Firstname, Syntax: Sichtbarkeit Datentyp Name 
            {
                get //um Wert einer Eigenschaft auszulesen
                {
                    return this.firstname = "Harald"; //Standartwert für firstname
                }
                set // um der Eigenschaft einen Wert zuzuweisen. Hier kann auf Gültigkeit überprüft werden. z.B. ob eine korrekte Postleitzahl angegeben wurde.
                {
                    this.firstname = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Person myPerson = new Person();

            Console.WriteLine(myPerson.Firstname);
        }
    }
}
