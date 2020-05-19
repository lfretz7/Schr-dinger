using System;

namespace Abendgestaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Freundin da? (true,false):");
            bool freundinDa = bool.Parse(Console.ReadLine());
            if (freundinDa == true)
            {
                Console.WriteLine("Kanal auf dem Titanic läuft:");
                int kanal = int.Parse(Console.ReadLine());
                Console.WriteLine("Tja, heute wird Titanic angesehen. Kanal: " + kanal);
            }
            else
            {
                Console.WriteLine("Einen Horrorfilm schauen?");
                bool horror = bool.Parse(Console.ReadLine());
                if (horror)
                    Console.WriteLine("Gute Wahl heute wirds gruselig.");
                else
                    Console.WriteLine("In diesem Fall, ein Actionfilm schauen?");
                bool actionfilm = bool.Parse(Console.ReadLine());
                if (actionfilm == true)
                    Console.WriteLine("Ein Actionfilm passt immer.");
                else
                    Console.WriteLine("Ein Thriller?");
                bool thriller = bool.Parse(Console.ReadLine());
                if (thriller == true)
                    Console.WriteLine("Ein Thriller. Nervenkitzel extrem.");
                else
                    Console.WriteLine("Heute leider kein Fernsehen.");
            }
            Console.ReadKey();
        }
    }
}
