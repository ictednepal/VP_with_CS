using System;

namespace console_constructordefault
{
    class Student
    {
        public Student(){
            Console.WriteLine("Hello Kathmandu");
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
        }
    }
}
