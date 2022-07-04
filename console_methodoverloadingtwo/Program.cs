using System;

namespace console_methodoverloadingtwo
{
    public class myMath{
        public int add(int a, int b){
            return (a+b);
        }
        public int add(int a, int b, int c){
            return (a+b+c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myMath m1= new myMath();
            Console.WriteLine("The result is = "+m1.add(2,5));
            Console.WriteLine("The result is = "+m1.add(2,5,8));
        }
    }
}
