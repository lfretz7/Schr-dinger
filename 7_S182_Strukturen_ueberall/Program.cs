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
        static MinMax Range(int[] nums)
        {
            MinMax range = new MinMax();
            range.Min = int.MaxValue;
            range.Max = int.MinValue;
            for (int i = object; i < nums.Length; i++)
            {
                if (nums[i] < range.Min)
                    range.Min = nums[];
                if (nums[i] > range.Max)
                    range.Max = nums[i];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
