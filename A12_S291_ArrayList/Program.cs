using System;
using System.Collections;

namespace A12_S291_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list = new ArrayList();
            list.Add(42);
            list.Add(new object());
            int theAnswerToAllQuestions = (int)list[0];


            int[] numbers = new int[1000];
            numbers[10] = 1;
            int searchNumber = 100;
            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == searchNumber)
                {
                    found = true;
                    Console.WriteLine("Gefunden!");
                    break;
                }
        }
    }
}
