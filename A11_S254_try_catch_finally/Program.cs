using System;

namespace A11_S254_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string text = System.IO.File.ReadAllText("C:\\Temp\\HTML.html");
                Console.WriteLine("Der Text in der Datei lautet:");
                Console.WriteLine(text);
            }
            catch(System.IO.FileNotFoundException)
            {
                Console.WriteLine("Die Datei gibt's ja gar nicht!");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Der Ordner zur Datei existiert nicht.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Der Zugriff auf die Datei wurde verweigert. Ätsch!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Hoppala. Da hat es etwas ganz Komisches:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
