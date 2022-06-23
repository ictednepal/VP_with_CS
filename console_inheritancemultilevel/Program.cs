using System;

namespace console_inheritancemultilevel
{
    class A{
        public int a = 5;
    }
    class B : A{
        public int b = 10;
    }
    class C: B{
        public int c = 15;
        public void add(){
            Console.WriteLine("The sum is = "+(a+b+c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c1= new C();
            c1.add();
        }
    }
}
