using System;

namespace console_classnobjtwo
{
    public class Student{
        public string name;
        public int roll;

        public void insert(string n, int r){
            name = n;
            roll = r;
        }
        public void display(){
            Console.WriteLine(roll+ " " + name);
        }
    }
    public class TestStudent
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student();
            st1.insert("Ram",6);
            st1.display();
            st2.insert("Sita",7);
            st2.display();
        }
    }
}
