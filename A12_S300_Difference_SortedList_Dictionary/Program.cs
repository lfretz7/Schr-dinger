using System;
using System.Collections.Generic;

namespace A12_S300_Difference_SortedList_Dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> myDict = new Dictionary<int, string>();
            if (!myDict.ContainsKey(4))
            {
                myDict.Add(4, "Schrödinger");
            }

            myDict.Add(1, "Freundin");
            foreach (KeyValuePair<int, string> item in myDict)
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

        }
    }
}
