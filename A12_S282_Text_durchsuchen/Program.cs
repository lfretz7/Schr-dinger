﻿using System;

namespace A12_S282_Text_durchsuchen
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Das ist ein Text, in dem ein Wort gesucht werden soll.";
                string search = "Wort";
            bool found = false;
            for (int i = 0; i < text.Length - search.Length; i++)
            {
                found = true;
                for (int j = 0; j < search.Length; j++)
                {
                    if (search[j] != text[i + j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    break;
            }
            if (found)
                Console.WriteLine("Der Text ist enthalten!");
            else
                Console.WriteLine("Der Text ist nicht enthalten");
        }
    }
}
