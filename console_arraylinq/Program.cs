using System;
using System.Linq;

namespace console_arraylinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5] {10,15,16,8,6};
            Console.WriteLine(nums.Max()); //returns 16
            Console.WriteLine(nums.Min()); // returns 6
            Console.WriteLine(nums.Sum()); //returns 55
            Console.WriteLine(nums.Average()); //returns 11
        }
    }
}
