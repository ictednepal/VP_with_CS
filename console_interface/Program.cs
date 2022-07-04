using System;

namespace console_interface
{
    interface IStudent{
        public void study();
    }
    interface ITeacher{
        public void teach();
    }
    class College : IStudent, ITeacher{
        public void study(){
            Console.WriteLine("Hello Student");
        }
        public void teach(){
            Console.WriteLine("Hello Teacher");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            College c1 = new College();
            c1.study();
            c1.teach();
        }
    }
}
