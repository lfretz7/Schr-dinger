using System;

namespace _7_S182_Strukturen_ueberall
{
    class Program
    {
        struct MinMax
        {
            public int Min { get; set; }
            public int Max { get; set; }

        }
        (int Max, int Min) Range(int[] nums);


        static void Main(string[] args)
        {
            (int Max, int Min) result = Range(new int[] { 2, 4, 3, 5, 1 });
            Console.WriteLine($"Wertebereich: {result.Min} - {result.Max}");
        }
    }
}
