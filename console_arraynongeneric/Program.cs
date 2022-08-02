using System;

namespace console_arraynongeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {23,45,87,11,34};
            string[] names = {"Ram","Sita","Hari","Gita"};
            
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
