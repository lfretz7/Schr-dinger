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
        static (int Max, int Min) Range(int[] nums)
        {
            MinMax range = new MinMax();
            range.Min = int.MaxValue;
            range.Max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < range.Min)
                    range.Min = nums[i];
                if (nums[i] > range.Max)
                    range.Max = nums[i];
            }
            return (range.Max, range.Min);
        }


        static void Main(string[] args)
        {
            (int Max, int Min) result = Range(new int[] { 2, 4, 3, 5, 1 });
            Console.WriteLine($"Wertebereich: {result.Min} - {result.Max}");
        }
    }
}
