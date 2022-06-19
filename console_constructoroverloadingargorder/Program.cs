//By changing the Order of the parameters
using System;

namespace console_constructoroverloadingargorder
{
    class student
    {
        public int roll;
        public double Height;
        public string name;
        //1st constructor
        public student(double a, int x, string s)
        {
            roll = x;
            name = s;
            Height = a;
        }
        //2nd constructor
        // order of the argument is different with respect to 1st constructor
        public student(string s, int x, double a)
        {
            Height = a;
            roll = x;
            name = s;
        }
        public void Display()
        {
            Console.WriteLine("Roll Number: " + roll);
            Console.WriteLine("Height: " + Height + "feet");
            Console.WriteLine("Name: " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // invoking 1st constructor
            student s1 = new student(5.7, 10, "Ram Thapa");
            // invoking 2nd constructor
            student s2 = new student("Sita Rai", 11, 6.0);
            Console.WriteLine("First Constructor: ");
            s1.Display();
            Console.WriteLine();
        }
    }

}
