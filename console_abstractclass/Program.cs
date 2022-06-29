using System;

namespace console_abstractclass
{
    public abstract class MyClass
    {
        public abstract void calculate(double x);
    }
    class Sub1 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Square root is " + Math.Sqrt(x));
        }
    }
    public class Sub2 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Square is :" + (x * x));
        }
    }
    public class Sub3 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Cube is :" + (x * x * x));
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Sub1 obj1 = new Sub1();
            Sub2 obj2 = new Sub2();
            Sub3 obj3 = new Sub3();
            obj1.calculate(9);
            obj2.calculate(9);
            obj3.calculate(9);
        }
    }

}
