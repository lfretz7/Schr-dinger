using System;
using System.Numerics;

namespace _4_S111_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ausprobieren mit nullable S. 111
            byte? myVariable = 2;
            if (myVariable.HasValue)
            {
                byte v2 = myVariable.Value;
                Console.WriteLine(v2);
            }
            bool hasValue = myVariable.HasValue;
            Console.WriteLine(myVariable);

            //Nichts im Einsatz S.115
            int? myValue = null;
            Console.WriteLine("Wert setzen (true, false)?");
            bool setValue = bool.Parse(Console.ReadLine());
            if (setValue)
            {
                Console.WriteLine("Wie ist Ihr Wert:");
                myValue = int.Parse(Console.ReadLine());

            if (myValue.HasValue)
            {
                Console.WriteLine("Der Wert ist: {0}.", myValue.Value);
            }

            }
            else
            {
                Console.WriteLine("Wert nicht gesetzt.");
            }
        }
    }
}
