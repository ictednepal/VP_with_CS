using System;

namespace console_delegatetwo
{
    public delegate void myDel(int num);
    class calc{
        public static void sqr(int num){
            Console.WriteLine("The square value is = "+(num*num));
        }
        public static void cube(int num){
            Console.WriteLine("The cube value is = "+(num*num*num));
        }
    }
    class Program : calc
    {
        static void Main(string[] args)
        {
            myDel md1 = sqr;
            md1.Invoke(5);
            md1 = cube;
            md1(3);
        }
    }
}
