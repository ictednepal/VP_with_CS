using System;

namespace console_interfacetwo
{
    interface IStudent{
        public void address();
    }
    interface ITeacher{
        public void address();
    }
    class College : IStudent, ITeacher{
        void IStudent.address(){
            Console.WriteLine("Student address");
        }
        void ITeacher.address(){
            Console.WriteLine("Teacher address");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IStudent s1 = new College();
            ITeacher t1 = new College();
            s1.address();
            t1.address();
        }
    }
}
