using System;

namespace console_nestedif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check zero, positive or negative:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num != 0)
            {
                if (num > 0)
                {
                    Console.WriteLine("The number is +ve.");
                }
                else
                {
                    Console.WriteLine("The number is -ve.");
                }
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
