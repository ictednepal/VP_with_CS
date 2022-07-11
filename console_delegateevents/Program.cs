using System;

namespace console_delegateevents
{
    public delegate string HelloMessage(string str);
    class myclass
    {
        event HelloMessage HelloEvent;
        public myclass()
        {
            this.HelloEvent += new HelloMessage(this.HelloUser);
        }
        public string HelloUser(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            string result = obj.HelloEvent("Sanothimi Campus");
            Console.WriteLine(result);
        }
    }

}
