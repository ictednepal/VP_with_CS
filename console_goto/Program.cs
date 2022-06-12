using System;

namespace console_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            ineligible:
            Console.WriteLine("You cannot cast your vote.");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                goto ineligible;
            }
            else
            {
                Console.WriteLine("You can cast your vote.");
            }
        }
    }
}
