using System;

namespace console_inheritancehierarchical
{
    public class A
    {
        public int a = 3;
    }

    public class B : A
    {
        public int b = 6;

        public void Add()
        {
            System.Console.WriteLine(a + b);
        }
    }

    public class C : A
    {
        public int c = 7;

        public void Add()
        {
            System.Console.WriteLine(a + c);
        }

        class Program
        {
            static void Main(string[] args)
            {
                B b1 = new B();
                b1.Add();
                C c1 = new C();
                c1.Add();
            }
        }
    }
}
