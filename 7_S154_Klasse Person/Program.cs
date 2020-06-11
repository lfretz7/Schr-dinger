using System;

namespace Schroedinger.Tierarten
{
    public class Program
    {

        public class Animal //neue Klasse: Animal
        {
            string firstname = "Harald"; //Standartwert für firstname
            public string Firstname //neue Eigenschaft: Firstname, Syntax: Sichtbarkeit Datentyp Name 
            {
                get //um Wert einer Eigenschaft auszulesen
                {
                    return this.firstname;
                }
                set // um der Eigenschaft einen Wert zuzuweisen. Hier kann auf Gültigkeit überprüft werden. z.B. ob eine korrekte Postleitzahl angegeben wurde.
                {
                    this.firstname = value;
                }
            }
        }

        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();

            Console.WriteLine(myAnimal.Firstname);
        }
    }
}
