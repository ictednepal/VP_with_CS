using System;

namespace console_structtwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1;
            t1.name="Sita Rai";
            t1.address="Ghopte Odar";
            t1.email="cutypie@gmail.com";
            Console.WriteLine("Teacher is "+t1.name);
            Console.WriteLine("Address is "+t1.address);
            Console.WriteLine("Email id is "+t1.email);
        }
    }
    struct Teacher{
        public string name;
        public string address;
        public string email;
    }
}
