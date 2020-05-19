using System;
using System.Text;

namespace _4_S108_VerdrehteWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text eingeben:");
            string text = Console.ReadLine();
            StringBuilder neuerText = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                neuerText.Append(text[i]);
            }
            Console.WriteLine($"Der Text rückwärts: {neuerText.ToString()}");

        }
    }
}
