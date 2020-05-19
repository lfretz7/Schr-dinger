using System;

namespace ifAbfrage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool freundinDa = true;
            int actionFilm = 1;
            int liebesFilm = 2;
            int tvKanal = freundinDa ? liebesFilm : actionFilm;
            Console.WriteLine(tvKanal);
        }
    }
}
