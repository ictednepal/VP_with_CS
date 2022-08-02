using System;

namespace console_arraysort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5]{10,15,16,8,6};
            //Array.Sort(nums); //sorts array
            //Array.Reverse(nums); //sorts array in decending order
            Array.ForEach(nums, n=>Console.WriteLine(n));
        }
    }
}
