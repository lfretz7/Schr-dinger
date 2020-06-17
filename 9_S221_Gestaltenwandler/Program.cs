using System;
using allGhosts;

namespace _9_S221_Gestaltenwandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Ghost ghost = new SlimeGhost("Smeargol");
            Ghost ghost2 = new CannibalGhost("Eat");
            Ghost[] ghosts = new Ghost[] { ghost, ghost2 };
            foreach (Ghost g in ghosts)
                g.Haunt();
            //Erklärung: Weil SlimeGhost Haunt() überschrieben hat, wird dieses Haunt () aufgerufen.
            //Cannibalghost hat die Methode nicht überschrieben, also wird Haunt () von Ghost verwendet.
        }
    }
}
