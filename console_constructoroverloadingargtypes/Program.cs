//•	By using different type of arguments
using System;

namespace console_constructoroverloadingargtypes
{
    class ADD
    {
        int x,
            y;
        double f;
        string s;

        //first constructor
        public ADD(int a, double b)
        {
            x = a;
            f = b;
        }

        //second constructor
        public ADD(int a, string b)
        {
            y = a;
            s = b;
        }

        //output from first constructor
        public void displayOne()
        {
            Console.WriteLine("First Constructor (int + double)= " + (x + f));
        }

        //output from second constructor
        public void displayTwo()
        {
            Console.WriteLine("Second Constructor (int + string)= " + (s + y));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //to call first constructor
            ADD m = new ADD(10, 20.25);
            m.displayOne();
            //to call second constructor
            ADD n = new ADD(10, "Roll no is ");
            n.displayTwo();
        }
    }
}
