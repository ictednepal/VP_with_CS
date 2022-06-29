using System;

namespace console_virtualmethod
{
    public class MyCalc{
        public virtual int add(int a, int b){
            return(a+b);
        }
    }
    public class Calc:MyCalc{
        public override int add(int a, int b)
        {
            return (a+b)*2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc();
            Console.WriteLine("The result is = "+c1.add(2,3));
        }
    }
}
