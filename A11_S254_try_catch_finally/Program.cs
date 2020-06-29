using System;

namespace A11_S254_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = System.IO.File.ReadAllText("c:\\myFile.txt");
                Console.WriteLine("Der Text in der Datei lautet:");
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hoppala. Da gibt es ein Problem:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
