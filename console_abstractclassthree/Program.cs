using System;

namespace console_abstractclassthree
{
    abstract class mcn
    {
        public int add(int a, int b)
        {
            return (a + b);
        }
    }
    class mcn1 : mcn
    {
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            mcn1 ob = new mcn1();
            int result = ob.add(5, 10);
            Console.WriteLine("The result is {0}", result);
        }
    }

}
