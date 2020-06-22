using System;
using allGhosts;

namespace _9_S208_Erben_ohne_Sterben
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Ghost ghost1 = new Ghost("Spooky");
            ghost1.Haunt();

            SlimeGhost ghost2 = new SlimeGhost("Slimey");
            Console.WriteLine("Slime Ghost Name is: {0}", ghost2.Name);
            ghost2.Haunt();

            SlimeGhost ghost3 = new SlimeGhost("Smeargol");
            ghost3.Size = 5;
            ghost3.Haunt();

            //Übung Seite 213
            SlimeGhost victim = new SlimeGhost("Smeargol");
            victim.Size = 5;
            CannibalGhost hungryGhost = new CannibalGhost("Hungry Boy");
            hungryGhost.Size = 1;
            hungryGhost.Eat(ref victim);
            Console.WriteLine("Die Grösse von {0}: {1}", hungryGhost.Name, hungryGhost.Size); ;

        }
    }
}
