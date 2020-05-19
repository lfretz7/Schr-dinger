using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7]; // Index wird als Laufvariable definiert
            // Array befuellen mit Zahlen von 1 bis 7
            for (int i = 0; i < arr.Length; i++) // for-Schleife durchläuft alle Werte des Arrays "arr" mit Hilfe des Index
                arr[i] = i + 1; // Greife auf das i-te Element des Arrays zu und setze es auf i + 1

            // 1. Variante
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]); // Lese das i-te Element des Arrays und gib es auf die Konsole aus
        }
    }
}
