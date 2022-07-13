using System;

namespace console_stringinterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ram";
            string msg = $"Hello {name}.";
            Console.WriteLine(msg);
        }
    }
}
