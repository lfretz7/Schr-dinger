using System;
using System.Runtime.CompilerServices;

namespace A12_S285_Buchstabensuppe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = GenerateLetters();
            PrintLetters(letters);
            MixLetters(letters);
            PrintLetters(letters);
        }
        private static char[] GenerateLetters()
        {
            char[] buchstaben = new char[90 - 65 + 1];
            for (int i = 65; i <= 90; i++)
                buchstaben[i - 65] = (char)i;
            return buchstaben;
        }
        private static void MixLetters(char[] letters)
        {
            Random rnd = new Random();
            for (int i = 0; i < letters.Length; i++)
            {
                int fromIndex = rnd.Next(0, letters.Length);
                int toIndex = rnd.Next(0, letters.Length);
                char temp = letters[fromIndex];
                letters[fromIndex] = letters[toIndex];
                letters[toIndex] = temp;
            }
        }
        private static void PrintLetters(char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
                Console.WriteLine(letters[i]);
            Console.WriteLine();
        }
    }
}
