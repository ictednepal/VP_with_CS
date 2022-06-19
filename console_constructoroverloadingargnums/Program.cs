//•	By using different number of arguments
using System;

namespace console_constructoroverloadingargnums
{
    // when the number of parameters are different
    class ADD
    {
        int x, y;
        int f, p, s;

        // 1st constructor
        public ADD(int a, int b)
        {
            x = a;
            y = b;
        }

        // 2nd constructor
        public ADD(int a, int b, int c)
        {
            f = a;
            p = b;
            s = c;
        }

        // showing 1st constructor's result
        public void DisplayOne()
        {
            Console.WriteLine("1st constructor (int + int): {0} ", (x + y));
        }

        // showing 2nd constructor's result
        public void DisplayTwo()
        {
            Console.WriteLine("2nd constructor (int + int + int): {0}", (f + p + s));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // will call 1st constructor
            ADD m = new ADD(10, 20);
            // calling method
            m.DisplayOne();
            // will call 2nd constructor
            ADD n = new ADD(10, 20, 30);
            // calling method
            n.DisplayTwo();
        }
    }
}
