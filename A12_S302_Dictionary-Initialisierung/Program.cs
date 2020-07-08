using System;
using System.Collections;
using System.Collections.Generic;

namespace A12_S302_Dictionary_Initialisierung
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<int, string> myDict1 = new Dictionary<int, string>();
            myDict1.Add(0, "zero");
            myDict1.Add(1, "one");
            myDict1.Add(2, "two");


            IDictionary<int, string> myDict2 = new Dictionary<int, string>()
            {
                {0, "zero" },
                {1, "one" },
                {2, "two" }
            };


            IDictionary<int, string> myDict3 = new Dictionary<int, string>()
            {
                [0] = "zero",
                [1] = "one",
                [2] = "two"
            };

        }
    }
}
