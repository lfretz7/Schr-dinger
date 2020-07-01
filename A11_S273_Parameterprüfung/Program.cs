using System;
using Schroedinger.Klassen;

namespace A11_S273_Parameterprüfung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = null;
            PrintPersonInfo(p);
        }
        public static void PrintPersonInfo(Person p)
        {
            if (p == null)
                throw new ArgumentNullException("p");
            if (p.Name == null)
                throw new ArgumentException("The Name property is null.", nameof(p));
            if (p.Name.Contains("Schrödinger"))
                Console.WriteLine("Unser Held: {0}", p.Name);
            else
                Console.WriteLine(p.Name);
        }
    }
}
