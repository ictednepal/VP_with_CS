using System;

namespace console_classnobj
{
    class Student
    {
        string name; //data member
        int roll; //data member

        public void helloHi()
        {
            Console.WriteLine("Hello all how are you?");
        }
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.name = "Ram Thapa";
            st1.roll = 6;
            st1.helloHi();
            Console.WriteLine("The name is " + st1.name + ".");
            Console.WriteLine("The roll number is " + st1.roll + "."); 
        }
    }
}
