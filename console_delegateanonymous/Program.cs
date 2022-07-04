using System;

public delegate void Test();
namespace console_delegateanonymous
{
    class Program
    {
        static int Main(string[] args)
        {
            Test Display = delegate ()
            {
                Console.WriteLine("Anonymous Delegate method");
                Console.ReadLine();
            };
            Display();
            return 0;
        }
    }
}
