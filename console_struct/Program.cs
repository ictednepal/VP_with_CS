using System;

namespace console_struct
{
    struct Student{
        public string name;
        public int roll;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1;
            s1.name="Ram Thapa";
            s1.roll = 6;
            Console.WriteLine("The name is "+s1.name);
            Console.WriteLine("The roll is "+s1.roll);
        }
    }
}
