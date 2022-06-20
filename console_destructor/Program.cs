using System;

namespace console_destructor
{
    class Student{
        public Student(){
            Console.WriteLine("Constructor created");
        }
        ~Student(){
            Console.WriteLine("Destructor calling");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
        }
    }
}
