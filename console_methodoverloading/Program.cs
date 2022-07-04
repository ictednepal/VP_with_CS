//method overloading based on types of parameter
using System;

namespace console_methodoverloading
{
    public class myMath{
        public int add(int a, int b){
            return (a+b);
        }
        public double add(double a, double b){
            return (a+b);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            myMath m1 = new myMath();
            Console.WriteLine("The result is="+m1.add(2,3));
            Console.WriteLine("The result is="+m1.add(2,3.5));
        }
    }
}
