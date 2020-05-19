using System;

namespace Schrödinger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Decimal.GetBits(0.1m));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(0.1f)));
        }
    }
}
