using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Länge eines Strings bestimmen (S. 100)
            string myString = "Dieser String hat nichts mit sexy Unterwäsche zu tun.";
            int amountOfChars = myString.IndexOf("D");
            Console.WriteLine(amountOfChars);
            
            //Zugriff auf einzelnes Zeichen (S. 102)
            string text = "Schrödinger ist cool";
            char zeichen = text[0];
            byte zahl = (byte)zeichen;
            Console.WriteLine(zahl);
            
            //Stringbuilder (S. 103)
            string[] words = { "Hallo", "Schrödinger", "wie", "geht", "es", "dir" };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
                sb.Append(words[i]);
            sb.ToString();
            Console.WriteLine(sb.GetType());
            
            //String.Format
            string text1 = "Schrödinger ist cool";
            int len1 = text1.Length;
            string[] words1 = text1.Split(' ');
            string newtext1 = string.Format("Die Länge: {0}. Anzahl der Wörter {1}", len1, words1.Length);
            Console.WriteLine(newtext1);
            Console.WriteLine(words1[1]);
            
            //Beispiel für mehrere Platzhalter (S.105)
            string a =string.Format("{0} {1} {2} {0}", "!","Hallo", "Schrödinger");
            Console.WriteLine(a);
           
            //String.Format mit $-Zeichen (S.106)
            string text2 = "Schrödinger ist cool";
            int len2 = text2.Length;
            string[] words2 = text2.Split(' ');
            string newText2 = $"Die Länge: {len2}. Anzahl der Wörter: {words2.Length}";
            Console.WriteLine(newText2);
            Console.WriteLine(words2[1]);

            //String.Concat (S. 106
            string newText3 = string.Concat("Die Länge", len2, ".Anzahl der Wörter: ", words2.Length);
            Console.WriteLine(newText3);
        }
    }
}
