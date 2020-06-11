using System;
using S = Schroedinger.Klassen;
using static System.Math;
using A = Schroedinger.Tierarten.Program;

namespace Schroedinger
{
    class Program
    {
        static void Main(string[] args)
        {
            Schroedinger.Klassen.Person p = new Schroedinger.Klassen.Person();
            Klassen.Person p2 = new Klassen.Person();
            S.Person p3 = new S.Person(); // hier wird der Alias "S" verwendent.
            double abs = Math.Abs(-1.0);
            double abs1 = Abs(-1.0); //kann mit einbinden des "System.Math" genutzt werden.
            A.Animal Tiger = new A.Animal();
            Tiger.Firstname = "Peter";
            Console.WriteLine(Tiger.Firstname);
        }
    }
}
