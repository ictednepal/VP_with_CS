using System;

namespace console_inheritancesingle
{
    public class ParentClass{
        public ParentClass(){
            Console.WriteLine("Parent Constructor");
        }
        public void ParentMethod(){
            Console.WriteLine("Parent method");
        }
    }
    class ChildClass : ParentClass
    {
        public ChildClass(){
            Console.WriteLine("Child Constructor");
        }
        public void ChildMethod(){
            Console.WriteLine("Child method");
        }
        static void Main(string[] args)
        {
            ChildClass c1 = new ChildClass();
            c1.ParentMethod();
            c1.ChildMethod();
        }
    }
}
