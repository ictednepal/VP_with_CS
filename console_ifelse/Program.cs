using System;

namespace console_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 17)
            {
                Console.WriteLine("You are eligible to cast your vote by age.");
            }
            else
            {
                Console.WriteLine("You are not eligible to cast your vote.");
            }
        }
    }
}
