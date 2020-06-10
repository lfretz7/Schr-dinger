using System;

namespace _7_S182_Strukturen_ueberall
{
    class Program
    {


        static (int Max, int Min) Range(int[] nums)
        {

            var min = int.MaxValue;
            var max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                    min = nums[i];
                if (nums[i] > max)
                    max = nums[i];
            }
            return (max, min);
        }

        static void Main(string[] args)
        {
            (int Max, int Min) result = Range(new int[] { 2, 4, 3, 5, 1 });
            Console.WriteLine($"Wertebereich: {result.Min} - {result.Max}");
        }
    }
}
