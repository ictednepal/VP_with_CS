using System;

namespace console_abstractmethodtwo
{
    abstract class test1
    {
        public int add(int i, int j)
        {
            return i + j;
        }
        public abstract int mul(int i, int j);
    }
    class test2 : test1
    {
        public override int mul(int i, int j)
        {
            return i * j;
        }
    }
    class test3 : test1
    {
        public override int mul(int i, int j)
        {
            return i - j;
        }
    }
    class test4 : test2
    {
        public override int mul(int i, int j)
        {
            return i + j;
        }
    }
    class myclass
    {
        static void Main(string[] args)
        {
            test2 ob = new test4();
            int a = ob.mul(2, 4);
            test1 ob1 = new test2();
            int b = ob1.mul(4, 2);
            test1 ob2 = new test3();
            int c = ob2.mul(4, 2);
            Console.Write("{0},{1},{2}", a, b, c);
        }
    }

}
