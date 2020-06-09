using System;

namespace _7_S172_Konstruktor
{
    class Program
    {
        class Person
        {
            public Person()
            {

            }
            public Person(string name): this(name, 0)
            {

            }
            public Person(string name, float weight)
            {
                this.Name = name;
                this.Weight = weight;
            }
            public string Name { get; set; }
            public float Weight { get; set; }
        }

        static void Main(string[] args)
        {
            Person p1 = new Person("Schrödinger");
            Person p2 = new Person("er", 99);
            Person p3 = new Person("Noch wer", 70);
            Console.WriteLine(p2.Name + " " + p2.Weight);
        }
    }
}
