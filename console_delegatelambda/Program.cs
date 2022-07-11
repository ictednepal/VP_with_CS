using System;

namespace console_delegatelambda
{
    public delegate int myDel(int num);
    class Program
    {
        static void Main(string[] args)
        {
            myDel d1 = x=>x*x;
            int result = d1(3);
            Console.WriteLine("The result is "+result);
        }
    }
}
