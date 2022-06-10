using System;

namespace console_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>0)
            {
                Console.WriteLine("The number is {0} positive.",a);
            }
        }
    }
}
