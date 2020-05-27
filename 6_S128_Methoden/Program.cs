using System;
using System.Reflection.Metadata.Ecma335;

namespace _6_S128_Methoden
{
    class Program
    {
        static void Increment(ref int number)
        {
            number++;
        }
        static bool Divide(double c, double d, out double result)
        {
            result = 0.0;
            if (d == 0.0)
            {
                return false;
            }
            else
            {
                result = c / d;
                return true;
            }
        }
        static void Main(string[] args)
        {
            //Sommerschlussverkauf S.138
            int number;
            if (int.TryParse("2", out number))
                Console.WriteLine("Parse hat funktioniert.");
            else
                Console.WriteLine("Keine gültige Zahl.");
            Console.WriteLine(number);
            //Beispiel Ausgangsparameter S.139
            double x = 12;
            double d = 3;

            bool canDivide = Divide(x, d, out double result);
            Console.WriteLine("Ist Division möglich: "+canDivide);
            Console.WriteLine("Resultat = "+result);



            //Methodenaufruf mit ref S.138
            int a = 12;
            Increment(ref a);
            Console.WriteLine(a);

            //BMI-Rechner S. 145
            Console.WriteLine("Grösse eingeben:");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Gewicht eingeben:");
            float test1 = float.Parse(Console.ReadLine());
            float bmi = CalculateBMI(weight : test1, height);
            Console.WriteLine(bmi);

        }
        static float CalculateBMI(float weight, float height = 1.80F)
        {
            return weight / (height * height);
        }
    }
}
