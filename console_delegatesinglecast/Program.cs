//singlecast
using System;

namespace console_delegatesinglecast
{
    class Program
    {
        public delegate void delmethod();
        public class Sano
        {
            public static void display()
            {
                Console.WriteLine("Hello!");
            }
            public static void show()
            {
                Console.WriteLine("Hi!");
            }
            public void print()
            {
                Console.WriteLine("Print");
            }
        }
        static void Main(string[] args)
        {
            // here we have assigned static method show() of class P to delegate delmethod()
            delmethod del1 = Sano.show;
            // here we have assigned static method display() of class P to delegate delmethod() using new operator
            // you can use both ways to assign the delagate
            delmethod del2 = new delmethod(Sano.display);
            Sano obj = new Sano();
            // here first we have create instance of class P and assigned the method print() to the delegate i.e. delegate with class    
            delmethod del3 = obj.print;
            del1();
            del2();
            del3();
        }
    }
}
