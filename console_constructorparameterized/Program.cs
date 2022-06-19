using System;

namespace console_constructorparameterized
{
    public class Student{
        public int roll;
        public string name;
        public string address;
        public Student(int r, string n, string a){
            roll = r;
            name =n;
            address = a;
        }
        public void display(){
            Console.WriteLine(roll + " " + name + " " + address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(25,"Ram","Kathmandu");
            s1.display();
        }
    }
}
