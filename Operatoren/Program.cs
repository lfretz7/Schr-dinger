using System;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            bool schnitzel = true;
            bool pommes = false;
            bool schnipo = (schnitzel && pommes);
            bool salatZutaten = true;
            bool essenZuHause = salatZutaten ||
                schnipo;
            ref var bleibeZuHause = ref essenZuHause;
            bleibeZuHause = false;
            Console.WriteLine(essenZuHause);
        }
    }
}
