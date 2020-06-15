using System;

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
        }
    }
}
