using System;

namespace Primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                bool isPrim = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrim = false;
                        break;
                    }
                }
                if (isPrim)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}