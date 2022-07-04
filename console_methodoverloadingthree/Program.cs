using System;

namespace console_methodoverloadingthree
{
    public class Student{
        public void details(int roll, string name){
            Console.WriteLine(roll + " " + name);
        }
        public void details(string name, int roll){
            Console.WriteLine(roll + " " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.details(1,"Ram");
            s1.details("Sita",5);
        }
    }
}
