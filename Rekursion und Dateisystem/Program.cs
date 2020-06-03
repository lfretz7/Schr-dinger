using System;

namespace Rekursion_und_Dateisystem
{
    class Program
    {
        public static int factorialrekursiv(int number) //Rekursive Fakultätsfunktion
        {
            if(number == 0)
            {
                return 1;
            }
            else
               return number * factorialrekursiv(number - 1);
        }
        public static int factorialiterativ(int number) //Iterative Fakultätsfunktion
        {
            int result = 1;
            while(number > 1)
            {
                result *= number;
                number -= 1;
            }
            return result;
        }
        public static int fibonaccirekursiv(int number) //Rekursive Fibonaccifunktion
        {
            if (number <= 0)
                return 0;

            if (number == 1)
                return 1;

            return fibonaccirekursiv(number - 1) + fibonaccirekursiv(number - 2);
        }

        public static int fibonacciiterativ(int number) // Iterative Fibonaccifunktion
        {
            int first = 0, second = 1;

            for (int count = 0; count < number; ++count)
            {
                int swap = first;
                first = second;
                second += swap;
            }

            return first;
        }

        static void Main(string[] args)
        {
            //Abfrage der gewünschten Zahl (Fakultät)
            Console.WriteLine("Von welcher Zahl möchten Sie die Fakultät wissen?"); 
            string eingabe1 = Console.ReadLine();
            int parseNumber1 = int.Parse(eingabe1);
            Console.WriteLine(factorialiterativ(parseNumber1));


            //Abfrage der gewünschten Zahl (Fibonacci)
            Console.WriteLine("Von welcher Zahl möchten Sie die Fibonacci-Folge wissen?");
            string eingabe2 = Console.ReadLine();
            int parseNumber2 = int.Parse(eingabe2);
            Console.WriteLine(fibonaccirekursiv(parseNumber2));
        }
    }
}
