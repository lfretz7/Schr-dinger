using System;

namespace For_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + ",");
            }
        }
    }
}
