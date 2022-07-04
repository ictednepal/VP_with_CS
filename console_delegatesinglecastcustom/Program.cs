//creating a custom Singlecast delegate and event
using System;

namespace console_delegatesinglecastcustom
{
    class Program
    {
        public delegate void MyDelegate(int a);
        public class SCD
        {
            public event MyDelegate MyEvent;
            public void RaiseEvent()
            {
                MyEvent(20);
                Console.WriteLine("Event Raised");
            }
            public void Display(int x)
            {
                Console.WriteLine("Display Method {0}", x);
            }
        }
        static void Main(string[] args)
        {
            SCD obj = new SCD();
            obj.MyEvent += new MyDelegate(obj.Display);
            obj.RaiseEvent();
        }
    }
}
