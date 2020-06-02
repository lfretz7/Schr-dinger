using System;

namespace test
{
    class Program
    {
        public static long Fakultaet(long zahl)
        {
            if (zahl == 0)
            {
                return 1;
            }
            return zahl * Fakultaet(zahl - 1);
        }
            static void Main(string[] args)
        {
                Console.Write("Fakultät von n: ");
                string input = Console.ReadLine();

                long eingabe = long.Parse(input);
                Console.WriteLine(Fakultaet(eingabe));
            }
        }
    }
